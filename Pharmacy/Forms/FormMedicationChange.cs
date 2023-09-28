using Pharmacy.Classes;
using Pharmacy.Data.Classes;
using Pharmacy.Managers;
using System;
using System.Windows.Forms;

namespace Pharmacy.Forms
{
	public partial class FormMedicationChange : Form
	{
		private static bool _isSuccess = false;
		private DatabaseManager _databaseManager;
		private Medication _medication;

		private FormMedicationChange()
		{
			InitializeComponent();

			this.Load += FormMedicationChange_Load;
			textBoxName.LostFocus += TextBoxName_LostFocus;
			textBoxName.GotFocus += TextBoxName_GotFocus;

			_databaseManager = DatabaseManager.Create();
		}

		private void FormMedicationChange_Load(object sender, EventArgs e)
		{
			FormPlacer.ToScreenCenter(this);
		}

		private void TextBoxName_GotFocus(object sender, EventArgs e)
		{
			if (textBoxName.Text == "Название") textBoxName.Text = string.Empty;
		}

		private void TextBoxName_LostFocus(object sender, EventArgs e)
		{
			if (textBoxName.Text == string.Empty) textBoxName.Text = "Название";
		}

		public void SetUpdate(Medication medication)
		{
			_medication = medication;
			textBoxName.Text = medication.Name;
			numericUpDownPrice.Value = (int)(medication.Price);
			numericUpDownPricePart.Value = (int)(medication.Price * 100) % 100;
			numericUpDownAmount.Value = (int)(medication.Amount);

			labelOk.Click += LabelOk_Update;
		}

		private async void LabelOk_Update(object sender, EventArgs e)
		{
			if (textBoxName.Text == string.Empty || textBoxName.Text == "Название")
			{
				PharmacyMessageBox.Show("ОШИБКА", "Не все поля введены.");
				return;
			}

			Medication medication = new Medication(_medication.Id)
			{
				Name = textBoxName.Text,
				Amount = (long)numericUpDownAmount.Value,
				Price = (double)numericUpDownPrice.Value + (double)(numericUpDownPricePart.Value / 100),
			};

			if (await _databaseManager.UpdateMedicationAsync(medication))
			{
				PharmacyMessageBox.Show("Успех", "Препарат успешно обновлен.");
				_isSuccess = true;
				this.Close();
				return;
			}
			else
				PharmacyMessageBox.Show("ОШИБКА", "Не удалось обновить препарат.");
		}

		public void SetAdd()
		{
			labelOk.Click += LabelOk_Add;
		}

		private async void LabelOk_Add(object sender, EventArgs e)
		{
			if(textBoxName.Text == string.Empty || textBoxName.Text == "Название")
			{
				PharmacyMessageBox.Show("ОШИБКА", "Не все поля введены.");
				return;
			}

			Medication medication = new Medication()
			{
				Name = textBoxName.Text,
				Amount = (long)numericUpDownAmount.Value,
				Price = (double)numericUpDownPrice.Value + (double)(numericUpDownPricePart.Value / 100),
			};

			if(await _databaseManager.AddMedicationAsync(medication))
			{
				PharmacyMessageBox.Show("Успех", "Препарат успешно добавлен.");
				_isSuccess = true;
				this.Close();
				return;
			}
			else
				PharmacyMessageBox.Show("ОШИБКА", "Не удалось добавить препарат.");
		}

		public static bool ShowAdd()
		{
			FormMedicationChange form = new FormMedicationChange();
			form.SetAdd();
			form.ShowDialog();

			return _isSuccess;
		}

		public static bool ShowUpdate(Medication medication)
		{
			FormMedicationChange form = new FormMedicationChange();
			form.SetUpdate(medication);
			form.ShowDialog();

			return _isSuccess;
		}

		private void labelCancel_Click(object sender, EventArgs e)
		{
			_isSuccess = false;
			Close();
		}
	}
}
