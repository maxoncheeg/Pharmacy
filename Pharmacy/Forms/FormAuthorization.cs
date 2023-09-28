using Pharmacy.Classes;
using Pharmacy.Managers;
using System;
using System.Windows.Forms;

namespace Pharmacy.Forms
{
	public partial class FormAuthorization : Form
	{
		private DatabaseManager _databaseManager;//объявляем менеджер баз данных
		public FormAuthorization()
		{
			InitializeComponent();

			labelButtonLogin.Click += LabelButtonLogin_Click;

			textBoxLogin.GotFocus += TextBoxLogin_GotFocus;
			textBoxLogin.LostFocus += TextBoxLogin_LostFocus;

			textBoxPassword.GotFocus += TextBoxPassword_GotFocus;
			textBoxPassword.LostFocus += TextBoxPassword_LostFocus;
		}

		private async void LabelButtonLogin_Click(object sender, EventArgs e)
		{
			LoginManager loginManager = LoginManager.Create();//создаем менеджер входа

			LoginResult result;
			if (Classes.LoginResult.Failed != (result = (await loginManager.Login(textBoxLogin.Text, textBoxPassword.Text))))
			{//если не произошла ошибка входа
				_databaseManager = DatabaseManager.CreateSingleton();//создаем синглтон, полностью новый класс
				if (result == LoginResult.Pharmacist) new FormPharmacist(loginManager, this).ShowDialog();//если фармацевт, то его форму
				else if(result == LoginResult.Administrator) new FormAdministrator(loginManager, this).ShowDialog();//иначе админ
			}
			else
				PharmacyMessageBox.Show("ОШИБКА", "Неправильный логин или пароль");//сообщение об ошибке
		}


		private void TextBoxPassword_LostFocus(object sender, EventArgs e)
		{
			if (textBoxPassword.Text == string.Empty)
			{
				textBoxPassword.PasswordChar = '\0';
				textBoxPassword.Text = "Пароль";
			}
		}

		private void TextBoxPassword_GotFocus(object sender, EventArgs e)
		{
			if (textBoxPassword.Text == "Пароль") textBoxPassword.Text = string.Empty;
			textBoxPassword.PasswordChar = '*';//тут добавляется PasswordChar - это символ для скрытия ввода пароля
		}

		private void TextBoxLogin_LostFocus(object sender, EventArgs e)
		{
			if (textBoxLogin.Text == string.Empty) textBoxLogin.Text = "Логин";
		}

		private void TextBoxLogin_GotFocus(object sender, EventArgs e)
		{
			if (textBoxLogin.Text == "Логин") textBoxLogin.Text = string.Empty;
		}

		private void FormAuthorization_Load(object sender, EventArgs e)
		{
			FormPlacer.ToScreenCenter(this);
			this.ActiveControl = label1;
		}
	}
}
