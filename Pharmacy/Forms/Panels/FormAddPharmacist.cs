using Pharmacy.Classes;
using Pharmacy.Data.Classes;
using Pharmacy.Managers;
using System;
using System.Windows.Forms;

namespace Pharmacy.Forms.Panels
{
	public partial class FormAddPharmacist : Form
	{
		private DatabaseManager _databaseManager;

		public Pharmacist UpdatePharmacist { get; set; } = null;

		private FormAddPharmacist()
		{
			InitializeComponent();

			textBoxName.LostFocus += TextBoxName_LostFocus;
			textBoxName.GotFocus += TextBoxName_GotFocus;

			textBoxSurname.LostFocus += TextBoxSurname_LostFocus;
			textBoxSurname.GotFocus += TextBoxSurname_GotFocus;

			textBoxLogin.GotFocus += TextBoxLogin_GotFocus;
			textBoxLogin.LostFocus += TextBoxLogin_LostFocus;

			textBoxPassword.GotFocus += TextBoxPassword_GotFocus;
			textBoxPassword.LostFocus += TextBoxPassword_LostFocus;

			Load += FormAddPharmacist_Load;
			_databaseManager = DatabaseManager.Create();
		}

		private void FormAddPharmacist_Load(object sender, EventArgs e)
		{
			FormPlacer.ToScreenCenter(this);
			this.ActiveControl = labelOk;

			if (UpdatePharmacist != null)
			{
				textBoxName.Text = UpdatePharmacist.Name;
				textBoxSurname.Text = UpdatePharmacist.Surname;
				textBoxLogin.Text = UpdatePharmacist.Login;
				textBoxPassword.Text = UpdatePharmacist.Password;
			}
		}

		public static void ShowAdd()
		{
			FormAddPharmacist form = new FormAddPharmacist();
			form.ShowDialog();
		}

		public static void ShowUpdate(Pharmacist pharmacist)
		{
			FormAddPharmacist form = new FormAddPharmacist();
			form.UpdatePharmacist = pharmacist;
			form.ShowDialog();
		}

		private void TextBoxPassword_LostFocus(object sender, EventArgs e)
		{
			if (textBoxPassword.Text == string.Empty) textBoxPassword.Text = "Пароль";
		}

		private void TextBoxPassword_GotFocus(object sender, EventArgs e)
		{
			if (textBoxPassword.Text == "Пароль") textBoxPassword.Text = string.Empty;
		}

		private void TextBoxLogin_LostFocus(object sender, EventArgs e)
		{
			if (textBoxLogin.Text == string.Empty) textBoxLogin.Text = "Логин";
		}

		private void TextBoxLogin_GotFocus(object sender, EventArgs e)
		{
			if (textBoxLogin.Text == "Логин") textBoxLogin.Text = string.Empty;
		}

		private void TextBoxName_GotFocus(object sender, EventArgs e)
		{
			if (textBoxName.Text == "Имя") textBoxName.Text = string.Empty;
		}

		private void TextBoxName_LostFocus(object sender, EventArgs e)
		{
			if (textBoxName.Text == string.Empty) textBoxName.Text = "Имя";
		}

		private void TextBoxSurname_GotFocus(object sender, EventArgs e)
		{
			if (textBoxSurname.Text == "Фамилия") textBoxSurname.Text = string.Empty;
		}

		private void TextBoxSurname_LostFocus(object sender, EventArgs e)
		{
			if (textBoxSurname.Text == string.Empty) textBoxSurname.Text = "Фамилия";
		}

		private async void labelOk_Click(object sender, EventArgs e)
		{
			if (textBoxName.Text == "Имя" || textBoxSurname.Text == "Фамилия" || textBoxLogin.Text == "Логин" 
				|| textBoxPassword.Text == "Пароль" || textBoxLogin.Text == string.Empty || textBoxPassword.Text == string.Empty
				|| textBoxName.Text == string.Empty || textBoxSurname.Text == string.Empty)
			{
				PharmacyMessageBox.Show("ВНИМАНИЕ", "Какие-то поля остались пустыми!");
				return;
			}

			Pharmacist pharmacist = UpdatePharmacist == null ? new Pharmacist() : new Pharmacist(UpdatePharmacist.Id);
			pharmacist.Surname = textBoxSurname.Text;
			pharmacist.Name = textBoxName.Text;
			pharmacist.Login = textBoxLogin.Text;
			pharmacist.Password = textBoxPassword.Text;

			if (UpdatePharmacist == null)
			{
				if (await _databaseManager.AddPharmacistAsync(pharmacist))
				{
					PharmacyMessageBox.Show("Успех", $"Фармацевт успешно добавлен!\nЛогин: {pharmacist.Login} | Пароль: {pharmacist.Password}");
					Close();
				}
				else
					PharmacyMessageBox.Show("ОШИБКА", "Не удалось добавить фармацевта!");
			}
			else
			{
				if (await _databaseManager.UpdatePharmacistAsync(pharmacist))
				{
					PharmacyMessageBox.Show("Успех", $"Фармацевт успешно обновлен!\nЛогин: {pharmacist.Login} | Пароль: {pharmacist.Password}");
					Close();
				}
				else
					PharmacyMessageBox.Show("ОШИБКА", "Не удалось обновить фармацевта!");
			}
		}

		private void labelCancel_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
