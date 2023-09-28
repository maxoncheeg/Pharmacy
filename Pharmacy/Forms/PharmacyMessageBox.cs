using Pharmacy.Classes;
using System;
using System.Windows.Forms;

namespace Pharmacy.Forms
{
	public partial class PharmacyMessageBox : Form
	{
		private static bool _result;

		private PharmacyMessageBox()
		{
			InitializeComponent();
			_result = false;
		}

		public void SetText(string title, string text)
		{
			labelTitle.Text = title;
			labelText.Text = text;
		}

		public static void Show(string title, string text)
		{
			PharmacyMessageBox form = new PharmacyMessageBox();
			form.SetText(title, text);
			form.HideCancelButton();
			form.ShowDialog();
		}

		public void HideCancelButton()
		{
			loginPanel1.Visible = false;
		}

		public static bool ShowOkCancel(string title, string text)
		{
			PharmacyMessageBox form = new PharmacyMessageBox();
			form.SetText(title, text);
			form.ShowDialog();

			return _result;
		}

		private void PharmacyMessageBox_Load(object sender, EventArgs e)
		{
			FormPlacer.ToScreenCenter(this);
		}

		private void labelCancel_Click(object sender, EventArgs e)
		{
			_result = false;
			this.Close();
		}

		private void label1_Click(object sender, EventArgs e)
		{
			_result = true;
			this.Close();
		}
	}
}
