using Pharmacy.Classes;
using Pharmacy.Data.Classes;
using Pharmacy.Data.Tables;
using Pharmacy.Forms.Panels;
using Pharmacy.Managers;
using System;
using System.Windows.Forms;

namespace Pharmacy.Forms
{
	public partial class FormPharmacist : Form
	{
		private LoginManager _loginManager;
		private Form _panelForm;
		private FormAuthorization _authorization;
		private DatabaseManager _databaseManager;

		public FormPharmacist(LoginManager _loginManager, FormAuthorization _authorization)
		{
			InitializeComponent();

			this._loginManager = _loginManager;
			this._authorization = _authorization;
			_authorization.Hide();
			this.Load += FormPharmacist_Load;
			this.FormClosed += FormPharmacist_FormClosed;

			_databaseManager = DatabaseManager.Create();
			_panelForm = new FormMedicationPanel(_loginManager);
			_panelForm.TopLevel = false;
			_panelForm.TopMost = true;
			_panelForm.Dock = DockStyle.Fill;
			_panelForm.FormBorderStyle = FormBorderStyle.None;

			panelWindow.Controls.Add(_panelForm as FormMedicationPanel);
			_panelForm.Show();

			System.Windows.Forms.ToolTip tip = new System.Windows.Forms.ToolTip();
			tip.SetToolTip(labelClient, "Клиенты: добавление");
			tip.SetToolTip(labelMedication, "Препараты: добавление в корзину");
			tip.SetToolTip(labelPurchase, "Продажа: продать по карте, продать без карты");
			tip.SetToolTip(pictureBoxFAQ, "Меню фармацевта");
		}

		private void FormPharmacist_FormClosed(object sender, FormClosedEventArgs e)
		{
			_authorization.Visible = true;
		}

		private void FormPharmacist_Load(object sender, EventArgs e)
		{
			FormPlacer.ToScreenCenter(this);
		}

		private void labelClient_Click(object sender, EventArgs e)
		{
			if (_panelForm != null)
			{
				if (panelWindow.Controls[panelWindow.Controls.Count - 1] is FormAddClientPanel) return;
				panelWindow.Controls.RemoveAt(panelWindow.Controls.Count - 1);
			}

			_panelForm = new FormAddClientPanel(_loginManager);
			_panelForm.TopLevel = false;
			_panelForm.TopMost = true;
			_panelForm.Dock = DockStyle.Fill;
			_panelForm.FormBorderStyle = FormBorderStyle.None;

			panelWindow.Controls.Add(_panelForm);

			_panelForm.Show();
		}

		private void labelMedication_Click(object sender, EventArgs e)
		{
			if (_panelForm != null)
			{
				if (panelWindow.Controls[panelWindow.Controls.Count - 1] is FormMedicationPanel) return;
				panelWindow.Controls.RemoveAt(panelWindow.Controls.Count - 1);
			}

			_panelForm = new FormMedicationPanel(_loginManager);
			_panelForm.TopLevel = false;
			_panelForm.TopMost = true;
			_panelForm.Dock = DockStyle.Fill;
			_panelForm.FormBorderStyle = FormBorderStyle.None;

			panelWindow.Controls.Add(_panelForm as FormMedicationPanel);

			_panelForm.Show();
		}

		private void labelPurchase_Click(object sender, EventArgs e)
		{
			if(_databaseManager.Cart.Count == 0)
			{
				PharmacyMessageBox.Show("ВНИМАНИЕ", "Корзина пуста");
				return;
			}

			long cardNumber = FormInputClientCard.Show();
			if (cardNumber == -1)
			{
				if (_panelForm is FormMedicationPanel)
				{
					_panelForm = null;
					panelWindow.Controls.RemoveAt(panelWindow.Controls.Count - 1);
					labelMedication_Click(null, null);
				}
					return;
			}

			if (_panelForm != null)
			{
				if (panelWindow.Controls[panelWindow.Controls.Count - 1] is FormPurchasePanel) return;
				panelWindow.Controls.RemoveAt(panelWindow.Controls.Count - 1);
			}

			_panelForm = new FormPurchasePanel(_loginManager, cardNumber);
			_panelForm.TopLevel = false;
			_panelForm.TopMost = true;
			_panelForm.Dock = DockStyle.Fill;
			_panelForm.FormBorderStyle = FormBorderStyle.None;

			panelWindow.Controls.Add(_panelForm as FormPurchasePanel);

			_panelForm.Show();
		}

		private void pictureBoxExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private async void pictureBoxAccount_Click(object sender, EventArgs e)
		{
			Pharmacist pharmacist = _loginManager.LoginUser as Pharmacist;
			PharmacyMessageBox.Show("Здравствуйте", $"{pharmacist.Surname} {pharmacist.Name} ({pharmacist.Login}), хорошего Вам дня!" +
				$"\n Кол-во продаж за месяц: {await _databaseManager.GetPurchaseAmountAsync(pharmacist.Id)}");
		}
	}
}
