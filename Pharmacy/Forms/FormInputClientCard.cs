using Pharmacy.Classes;
using Pharmacy.Managers;
using System;
using System.Windows.Forms;

namespace Pharmacy.Forms
{
	public partial class FormInputClientCard : Form
	{
		private static long _result = -1;
		DatabaseManager _databaseManager;

		private FormInputClientCard()
		{
			InitializeComponent();
			_databaseManager = DatabaseManager.Create();
			this.Load += FormInputClientCard_Load;
		}

		private void FormInputClientCard_Load(object sender, EventArgs e)
		{
			FormPlacer.ToScreenCenter(this);
		}

		public static long Show()
		{
			FormInputClientCard form = new FormInputClientCard();
			form.ShowDialog();
			return _result;
		}

		private async void labelOk_Click(object sender, EventArgs e)
		{
			if (await _databaseManager.IsCardExistAsync((long)numericUpDownCard.Value))
			{
				_result = (long)numericUpDownCard.Value;
				Close();
			}
			else
				PharmacyMessageBox.Show("ОШИБКА", "Карта не найдена!");
		}

		private void labelCancel_Click(object sender, EventArgs e)
		{
			_result = -1;
			Close();
		}

		private async void labelPurchaseWithoutCard_Click(object sender, EventArgs e)
		{
			await _databaseManager.PurchaseMedicationAsync();

			_result = -1;
			Close();
		}
	}
}
