using Pharmacy.Classes;
using Pharmacy.Data.Classes;
using Pharmacy.Managers;
using System;
using System.Windows.Forms;

namespace Pharmacy.Forms.Panels
{
	public partial class FormAddClientPanel : Form
	{
		private DatabaseManager _databaseManager;
		private LoginManager _loginManager;

		public FormAddClientPanel(LoginManager _loginManager)
		{
			InitializeComponent();
			this.Load += FormAddClientPanel_Load;//при загрузке формы
			this._loginManager = _loginManager;

			textBoxName.LostFocus += TextBoxName_LostFocus;//это нужно для реализации Placeholder (текст который показывает что нужно вводить)
			textBoxName.GotFocus += TextBoxName_GotFocus;

			textBoxSurname.LostFocus += TextBoxSurname_LostFocus;
			textBoxSurname.GotFocus += TextBoxSurname_GotFocus;

			textBoxBirthDate.LostFocus += TextBoxBirthDate_LostFocus;
			textBoxBirthDate.GotFocus += TextBoxBirthDate_GotFocus;

			_databaseManager = DatabaseManager.Create();

			if (_loginManager.LoginResult == LoginResult.Pharmacist)//если мы подключились как фармацевт, то кнопка добавления нам не нужна
				addPanelCancel.Visible = false;
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

		private void FormAddClientPanel_Load(object sender, EventArgs e)
		{
			FormPlacer.ToScreenCenter(this);//центрируем форму
			this.ActiveControl = labelCancel;//это нужно чтобы изначально у нас оставались placeholder
			//мы переводим фокус на любой объект кроме TextBox
		}

		private async void labelOk_Click(object sender, EventArgs e)
		{
			if (textBoxBirthDate.Text == "Дата рождения" || textBoxName.Text == "Имя" || textBoxSurname.Text == "Фамилия"
				|| textBoxBirthDate.Text == string.Empty || textBoxName.Text == string.Empty || textBoxSurname.Text == string.Empty)
			{
				PharmacyMessageBox.Show("ВНИМАНИЕ", "Какие-то поля остались пустыми!");
				return;//проверка полей на пустоту
			}

			DateTime date;

			if(!DateTime.TryParse(textBoxBirthDate.Text, out date))
			{
				PharmacyMessageBox.Show("ОШИБКА", "Введите дату верно\nФормат: Год-Месяц-День\nНапример: 1999-12-31");
				return;//проверка на правильность даты
			}

			Client client = new Client()
			{
				Surname = textBoxSurname.Text,
				Name = textBoxName.Text,
				BirthDate = date,
			};

			if (!await _databaseManager.AddClientAsync(client))
			{//добавляем клиента
				PharmacyMessageBox.Show("ОШИБКА", "Не удалось добавить клиента.");
				return;
			}
			else
			{
				textBoxBirthDate.Text = "Дата рождения";
				textBoxName.Text = "Имя Отчество";
				textBoxSurname.Text = "Фамилия";
				PharmacyMessageBox.Show("Успех", "Клиент успешно добавлен.");//если успех

				if(_loginManager.LoginResult == LoginResult.Administrator)//если это админ
				{//то у него это будет не панель, а форма, поэтому ее надо закрыть
					this.Close();
					return;
				}

				this.ActiveControl = labelCancel;
			}
		}

		private void labelCancel_Click(object sender, EventArgs e)
		{
			if (_loginManager.LoginResult == LoginResult.Administrator)
				Close();
		}
	}
}
