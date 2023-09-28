using Pharmacy.Classes;
using Pharmacy.Data.Classes;
using Pharmacy.Managers;
using System;
using System.Windows.Forms;

namespace Pharmacy.Forms
{
	public partial class PharmacyAmountBox : Form
	{
		private DatabaseManager _databaseManager;
		private Medication _medication;
		public PharmacyAmountBox()
		{
			InitializeComponent();
			_databaseManager = DatabaseManager.Create();

			Load += PharmacyAmountBox_Load;
		}

		private void PharmacyAmountBox_Load(object sender, EventArgs e)
		{
			FormPlacer.ToScreenCenter(this);
		}

		private void labelCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			Close();
		}

		private void labelButtonOk_Click(object sender, EventArgs e)
		{
			_databaseManager.Cart.Add(_medication.Id, (long)numericUpDownAmount.Value);
			_databaseManager.CartMedications.Add(_medication);
			this.DialogResult = DialogResult.OK;
			Close();
		}


		public void SetFormData(string title, Medication medication)
		{
			labelMedication.Text = title;
			numericUpDownAmount.Maximum = medication.Amount;
			_medication = medication;
		}

		public static DialogResult Show(string title, Medication medication)
		{
			PharmacyAmountBox form = new PharmacyAmountBox();
			form.SetFormData(title, medication);
			return form.ShowDialog();
		}
	}
}
