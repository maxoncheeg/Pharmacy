using Pharmacy.Classes;
using Pharmacy.Data.Classes;
using Pharmacy.Managers;
using System;
using System.Windows.Forms;

namespace Pharmacy.Forms
{
	public partial class FormClientChange : Form
	{
		private DatabaseManager _databaseManager;
		private Client _client;

		private FormClientChange(Client client)
		{
			InitializeComponent();

			textBoxName.LostFocus += TextBoxName_LostFocus;
			textBoxName.GotFocus += TextBoxName_GotFocus;

			textBoxSurname.LostFocus += TextBoxSurname_LostFocus;
			textBoxSurname.GotFocus += TextBoxSurname_GotFocus;

			textBoxBirthDate.LostFocus += TextBoxBirthDate_LostFocus;
			textBoxBirthDate.GotFocus += TextBoxBirthDate_GotFocus;

			textBoxName.Text = client.Name;
			textBoxSurname.Text = client.Surname;
			textBoxBirthDate.Text = client.BirthDate.ToString("yyyy-MM-dd");

			Load += FormClientChange_Load;

			_client = client;

			_databaseManager = DatabaseManager.Create();
		}

		public static void Show(Client client)
		{
			FormClientChange form = new FormClientChange(client);
			form.ShowDialog();
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

		private void TextBoxBirthDate_GotFocus(object sender, EventArgs e)
		{
			if (textBoxBirthDate.Text == "Дата рождения") textBoxBirthDate.Text = string.Empty;
		}

		private void TextBoxBirthDate_LostFocus(object sender, EventArgs e)
		{
			if (textBoxBirthDate.Text == string.Empty) textBoxBirthDate.Text = "Дата рождения";
		}

		private void FormClientChange_Load(object sender, EventArgs e)
		{
			FormPlacer.ToScreenCenter(this);
			this.ActiveControl = labelCancel;
		}

		private async void labelOk_Click(object sender, EventArgs e)
		{
			if (textBoxBirthDate.Text == "Дата рождения" || textBoxName.Text == "Имя" || textBoxSurname.Text == "Фамилия"
				|| textBoxBirthDate.Text == string.Empty || textBoxName.Text == string.Empty || textBoxSurname.Text == string.Empty)
			{
				PharmacyMessageBox.Show("ВНИМАНИЕ", "Какие-то поля остались пустыми!");
				return;
			}

			DateTime date;

			if (!DateTime.TryParse(textBoxBirthDate.Text, out date))
			{
				PharmacyMessageBox.Show("ОШИБКА", "Введите дату верно\nФормат: Год-Месяц-День\nНапример: 1999-12-31");
				return;
			}

			Client client = new Client(_client.Id)
			{
				Surname = textBoxSurname.Text,
				Name = textBoxName.Text,
				BirthDate = date,
			};

			if (!await _databaseManager.UpdateClientAsync(client))
			{
				PharmacyMessageBox.Show("ОШИБКА", "Не удалось обновить клиента.");
				return;
			}
			else
			{
				PharmacyMessageBox.Show("Успех", "Клиент успешно обновлен.");

				this.Close();
			}
		}

		private void labelCancel_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
