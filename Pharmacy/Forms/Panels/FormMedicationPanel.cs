using Pharmacy.Data.Classes;
using Pharmacy.Forms.Elements;
using Pharmacy.Managers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.Forms.Panels
{
	public partial class FormMedicationPanel : Form
	{
		private List<ItemPanel> _panels;
		private List<Medication> _medications;
		private List<Medication> _scrollMedications;

		private LoginManager _loginManager;
		private DatabaseManager _databaseManager;

		public FormMedicationPanel(LoginManager _loginManager)
		{
			InitializeComponent();

			textBoxSearch.GotFocus += TextBoxSearch_GotFocus;
			textBoxSearch.LostFocus += TextBoxSearch_LostFocus;

			this._loginManager = _loginManager;

			this.Load += FormMedicationPanel_Load;
			this.AutoScroll= true;
			this.MouseWheel += FormMedicationPanel_MouseWheel;
			PanelInitialization();
			_panels = new List<ItemPanel>() { itemPanel1, itemPanel2, itemPanel3, itemPanel4 };

			_databaseManager = DatabaseManager.Create();

			textBoxSearch.TextChanged += TextBoxSearch_TextChanged;

			foreach (var item in _panels)
			{
				item.ActionBox.Image = _loginManager.LoginResult == Classes.LoginResult.Administrator ?
					Properties.Resources.edit : Properties.Resources.add;

				item.DeleteBox.Visible = _loginManager.LoginResult == Classes.LoginResult.Administrator;

				if (_loginManager.LoginResult == Classes.LoginResult.Administrator)
					item.ActionBox.Click += ActionAdministratorBox_Click;
				else
					item.ActionBox.Click += ActionPharmacistBox_Click;

				item.DeleteBox.Click += DeleteBox_Click;
			}

			if (_loginManager.LoginResult != Classes.LoginResult.Administrator)
				actionPanelButton.Hide();

			vScrollBar.ValueChanged += VScrollBar_ValueChanged;

		}

		private void VScrollBar_ValueChanged(object sender, EventArgs e)
		{
			vScrollBar_Scroll(null, null);
		}

		private void FormMedicationPanel_MouseWheel(object sender, MouseEventArgs e)
		{
			if (e.Delta < 0)
			{
				if (vScrollBar.Value == vScrollBar.Maximum) return;
				vScrollBar.Value++;
			}
			else
			{
				if (vScrollBar.Value == 0) return;
				vScrollBar.Value--;
			}
		}

		private async void DeleteBox_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < _panels.Count; i++)
				if (_panels[i].DeleteBox == sender as PictureBox)
				{
					Medication onDelete = _scrollMedications[i];
					onDelete.Amount = 0;
					if (await _databaseManager.UpdateMedicationAsync(onDelete))
					{
						PharmacyMessageBox.Show("Успех", $"Количество {onDelete.Name} равно 0.");
						TextBoxSearch_TextChanged(null, null);
						return;
					}
					else
					{
						PharmacyMessageBox.Show("Ошибка", $"Не удалось убрать товар со склада.");
					}
				}
		}

		private void ActionAdministratorBox_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < _panels.Count; i++)
				if (_panels[i].ActionBox == sender as PictureBox)
				{
					if (FormMedicationChange.ShowUpdate(_scrollMedications[i]))
					{
						TextBoxSearch_TextChanged(null, null);
					}

					return;
				}
		}

		private void ActionPharmacistBox_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < _panels.Count; i++)
				if (_panels[i].ActionBox == sender as PictureBox)
				{
					Medication onAction = _scrollMedications[i];
					if (_databaseManager.Cart.ContainsKey(onAction.Id))
					{
						_databaseManager.Cart.Remove(onAction.Id);
						_databaseManager.CartMedications.Remove(onAction);
						TextBoxSearch_TextChanged(null, null);
						return;
					}
					else
					{
						PharmacyAmountBox.Show(onAction.Name, onAction);
						break;
					}
				}
		}

		private void FormMedicationPanel_Load(object sender, EventArgs e)
		{
			this.ActiveControl = labelButtonAdd;
			Search("");
		}

		private void PanelInitialization()
		{
			itemPanel1.FirstLabel = labelName1;
			itemPanel1.SecondLabel = labelAmount1;
			itemPanel1.ThirdLabel = labelPrice1;
			itemPanel1.ActionBox = pictureBoxAction1;
			itemPanel1.DeleteBox = pictureBoxDelete1;

			itemPanel2.FirstLabel = labelName2;
			itemPanel2.SecondLabel = labelAmount2;
			itemPanel2.ThirdLabel = labelPrice2;
			itemPanel2.ActionBox = pictureBoxAction2;
			itemPanel2.DeleteBox = pictureBoxDelete2;

			itemPanel3.FirstLabel = labelName3;
			itemPanel3.SecondLabel = labelAmount3;
			itemPanel3.ThirdLabel = labelPrice3;
			itemPanel3.ActionBox = pictureBoxAction3;
			itemPanel3.DeleteBox = pictureBoxDelete3;

			itemPanel4.FirstLabel = labelName4;
			itemPanel4.SecondLabel = labelAmount4;
			itemPanel4.ThirdLabel = labelPrice4;
			itemPanel4.ActionBox = pictureBoxAction4;
			itemPanel4.DeleteBox = pictureBoxDelete4;
		}

		private void TextBoxSearch_LostFocus(object sender, EventArgs e)
		{
			if (textBoxSearch.Text == string.Empty) textBoxSearch.Text = "Поиск";
		}

		private void TextBoxSearch_GotFocus(object sender, EventArgs e)
		{
			if (textBoxSearch.Text == "Поиск") textBoxSearch.Text = string.Empty;
		}

		private void TextBoxSearch_TextChanged(object sender, EventArgs e)
		{
			Search(textBoxSearch.Text);
		}

		bool isSearching = false;
		private async void Search(string text)
		{
			if (isSearching) return;
			isSearching = true;
			vScrollBar.Value = 0;
			if (text == "Поиск")
				_medications = await _databaseManager.GetMedicationsAsync("");
			else
				_medications = await _databaseManager.GetMedicationsAsync(text);

			if (_loginManager.LoginResult == Classes.LoginResult.Pharmacist)
				_medications = _medications.FindAll(x => x.Amount > 0);

			for (int i = 0; i < _panels.Count; i++)
				if (i >= _medications.Count)
					_panels[i].Hide();
				else _panels[i].Visible = true;

			int scrollAmount = 0, amount = _medications.Count;
			while (amount > 0)
			{
				if (amount - 4 > 0)
					scrollAmount++;
				amount -= 4;
			}
			vScrollBar.Maximum = scrollAmount;

			for (int i = 0; i < _panels.Count && _medications.Count > i; i++)
			{
				_panels[i].FirstLabel.Text = _medications[i].Name;
				_panels[i].SecondLabel.Text = _medications[i].Amount.ToString() + "шт.";
				_panels[i].ThirdLabel.Text = _medications[i].Price.ToString() + " р.";

				if (_loginManager.LoginResult == Classes.LoginResult.Pharmacist)
				{
					if (_databaseManager.Cart.ContainsKey(_medications[i].Id))
						_panels[i].ActionBox.Image = Properties.Resources.remv;
					else
						_panels[i].ActionBox.Image = Properties.Resources.add;
				}
			}

			isSearching = false;
			vScrollBar_Scroll(null, null);
		}

		private void labelButtonAdd_Click(object sender, EventArgs e)
		{
			this.ActiveControl = labelButtonAdd;
			if (FormMedicationChange.ShowAdd())
			{
				if (textBoxSearch.Text != "Поиск")
					Search(textBoxSearch.Text);
				else Search("");
			}
		}

		private void vScrollBar_Scroll(object sender, ScrollEventArgs e)
		{
			_scrollMedications = new List<Medication>();

			for (int i = vScrollBar.Value * 4; i < vScrollBar.Value * 4 + 4 && i < _medications.Count; i++)
				_scrollMedications.Add(_medications[i]);

			for (int j = 0; j < _panels.Count; j++)
				if (j >= _scrollMedications.Count)
					_panels[j].Hide();
				else _panels[j].Visible = true;

			for (int i = 0; i < _panels.Count && _scrollMedications.Count > i; i++)
			{
				_panels[i].FirstLabel.Text = _scrollMedications[i].Name;//заливаем информацию на палели
				_panels[i].SecondLabel.Text = _scrollMedications[i].Amount.ToString() + "шт.";
				_panels[i].ThirdLabel.Text = _scrollMedications[i].Price.ToString() + " р.";
			}
		}
	}
}
