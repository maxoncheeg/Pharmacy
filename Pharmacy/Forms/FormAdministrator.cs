using Pharmacy.Classes;
using Pharmacy.Data.Classes;
using Pharmacy.Forms.Panels;
using Pharmacy.Managers;
using System;
using System.Windows.Forms;

namespace Pharmacy.Forms
{
	public partial class FormAdministrator : Form
	{
		private LoginManager _loginManager;
		private Form _panelForm;
		private FormAuthorization _authorization;

		public FormAdministrator(LoginManager _loginManager, FormAuthorization _authorization)
		{
			InitializeComponent();

			this._loginManager = _loginManager;
			this.Load += FormAdministrator_Load;
			this._authorization = _authorization;
			this.FormClosed += FormAdministrator_FormClosed;
			_authorization.Hide();//прячем форму авторизации

			//схема: мы будет загружать на panelWindow разные формы, чтобы не менять каждую форму
			//на этой форме будет вылазить разные, которые есть в меню
			//изначально грузим препараты
			_panelForm = new FormMedicationPanel(_loginManager);
			_panelForm.TopLevel = false;
			_panelForm.TopMost = true;
			_panelForm.Dock = DockStyle.Fill;//настройти для того, чтобы можно было показать форму на панели
			_panelForm.FormBorderStyle = FormBorderStyle.None;

			panelWindow.Controls.Add(_panelForm as FormMedicationPanel);//добавляем форму на панель
			_panelForm.Show();//показываем форму

			ToolTip tip = new ToolTip();//это всплывашка при наведении
			tip.SetToolTip(pictureBoxFAQ, "Меню администратора");

			tip.SetToolTip(labelClient, "Клиенты: добавление, редактирование, удаление");
			tip.SetToolTip(labelMedication, "Препараты: добавление, редактирование, удаление");
			tip.SetToolTip(labelPharmacist, "Фармацевты: добавление, редактирование");
		}

		private void FormAdministrator_FormClosed(object sender, FormClosedEventArgs e)
		{
			_authorization.Visible = true;//при закрытии формы показываем форму авторизации
		}

		private void FormAdministrator_Load(object sender, EventArgs e)
		{
			FormPlacer.ToScreenCenter(this);//центрируем
		}

		private void labelMedication_Click(object sender, EventArgs e)
		{
			if (_panelForm != null)//если что-то есть в панели
			{
				if (panelWindow.Controls[panelWindow.Controls.Count - 1] is FormMedicationPanel) return;//если это и есть эта панель, то выходим
				panelWindow.Controls.RemoveAt(panelWindow.Controls.Count - 1);//иначе удаляем
			}

			_panelForm = new FormMedicationPanel(_loginManager);
			_panelForm.TopLevel = false;
			_panelForm.TopMost = true;
			_panelForm.Dock = DockStyle.Fill;
			_panelForm.FormBorderStyle = FormBorderStyle.None;

			panelWindow.Controls.Add(_panelForm as FormMedicationPanel);

			_panelForm.Show();//также открываем форму
		}

		private void pictureBoxExit_Click(object sender, EventArgs e)
		{
			Close();//закрытие формы
		}

		private void labelClient_Click(object sender, EventArgs e)
		{
			if (_panelForm != null)
			{
				if (panelWindow.Controls[panelWindow.Controls.Count - 1] is FormClientPanel) return;
				panelWindow.Controls.RemoveAt(panelWindow.Controls.Count - 1);
			}

			_panelForm = new FormClientPanel(_loginManager);
			_panelForm.TopLevel = false;
			_panelForm.TopMost = true;
			_panelForm.Dock = DockStyle.Fill;
			_panelForm.FormBorderStyle = FormBorderStyle.None;

			panelWindow.Controls.Add(_panelForm as FormClientPanel);

			_panelForm.Show();
		}

		private void pictureBoxAccount_Click(object sender, EventArgs e)
		{
			Administrator administrator = _loginManager.LoginUser as Administrator;//окно для показа текущего пользователя
			PharmacyMessageBox.Show("Здравствуйте", $"{administrator.Surname} {administrator.Name} ({administrator.Login}), хорошего Вам дня!");
		}

		private void labelPharmacist_Click(object sender, EventArgs e)
		{
			if (_panelForm != null)
			{
				if (panelWindow.Controls[panelWindow.Controls.Count - 1] is FormPharmacistPanel) return;
				panelWindow.Controls.RemoveAt(panelWindow.Controls.Count - 1);
			}

			_panelForm = new FormPharmacistPanel();
			_panelForm.TopLevel = false;
			_panelForm.TopMost = true;
			_panelForm.Dock = DockStyle.Fill;
			_panelForm.FormBorderStyle = FormBorderStyle.None;

			panelWindow.Controls.Add(_panelForm as FormPharmacistPanel);

			_panelForm.Show();
		}
	}
}
