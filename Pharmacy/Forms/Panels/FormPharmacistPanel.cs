using Pharmacy.Classes;
using Pharmacy.Data.Classes;
using Pharmacy.Forms.Elements;
using Pharmacy.Managers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pharmacy.Forms.Panels
{
	public partial class FormPharmacistPanel : Form
	{
		private DatabaseManager _databaseManager;
		private List<Pharmacist> _pharmacists;
		private List<Pharmacist> _scrollPharmacists;
		private List<ItemPanel> _panels;

		public FormPharmacistPanel()
		{
			InitializeComponent();

			textBoxSearch.GotFocus += TextBoxSearch_GotFocus;
			textBoxSearch.LostFocus += TextBoxSearch_LostFocus;
			textBoxSearch.TextChanged += TextBoxSearch_TextChanged;
			PanelInitialization();

			_databaseManager = DatabaseManager.Create();
			_panels = new List<ItemPanel>() { itemPanel1, itemPanel2, itemPanel3, itemPanel4 };
			foreach (var item in _panels)
				item.ActionBox.Click += ActionBox_Click;


			Load += FormPharmacistPanel_Load;
			MouseWheel += FormPharmacistPanel_MouseWheel;
			vScrollBar.ValueChanged += VScrollBar_ValueChanged;
		}

		private void VScrollBar_ValueChanged(object sender, EventArgs e)
		{
			vScrollBar_Scroll(null, null);
		}

		private void FormPharmacistPanel_MouseWheel(object sender, MouseEventArgs e)
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

		private void ActionBox_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < _panels.Count; i++)
				if (_panels[i].ActionBox == sender as PictureBox)
					FormAddPharmacist.ShowUpdate(_scrollPharmacists[i]);

			TextBoxSearch_TextChanged(null, null);
		}

		private void PanelInitialization()
		{
			itemPanel1.FirstLabel = labelSurname1;
			itemPanel1.SecondLabel = labelName1;
			itemPanel1.ThirdLabel = labelPurchase1;
			itemPanel1.ActionBox = pictureBoxAction1;

			itemPanel2.FirstLabel = labelSurname2;
			itemPanel2.SecondLabel = labelName2;
			itemPanel2.ThirdLabel = labelPurchase2;
			itemPanel2.ActionBox = pictureBoxAction2;

			itemPanel3.FirstLabel = labelSurname3;
			itemPanel3.SecondLabel = labelName3;
			itemPanel3.ThirdLabel = labelPurchase3;
			itemPanel3.ActionBox = pictureBoxAction3;

			itemPanel4.FirstLabel = labelSurname4;
			itemPanel4.SecondLabel = labelName4;
			itemPanel4.ThirdLabel = labelPurchase4;
			itemPanel4.ActionBox = pictureBoxAction4;
		}

		private void FormPharmacistPanel_Load(object sender, EventArgs e)
		{
			FormPlacer.ToScreenCenter(this);
			this.ActiveControl = labelButtonAdd;
			TextBoxSearch_TextChanged(null, null);
		}

		private void TextBoxSearch_LostFocus(object sender, EventArgs e)
		{
			if (textBoxSearch.Text == string.Empty) textBoxSearch.Text = "Поиск";
		}

		private void TextBoxSearch_GotFocus(object sender, EventArgs e)
		{
			if (textBoxSearch.Text == "Поиск") textBoxSearch.Text = string.Empty;
		}

		private async void TextBoxSearch_TextChanged(object sender, EventArgs e)
		{
			vScrollBar.Value = 0;
			if (textBoxSearch.Text == "Поиск")
				_pharmacists = await _databaseManager.GetPharmacistAsync("");
			else
				_pharmacists = await _databaseManager.GetPharmacistAsync(textBoxSearch.Text);

			int scrollAmount = 0, amount = _pharmacists.Count;
			while (amount > 0)
			{
				if (amount - 4 > 0)
					scrollAmount++;
				amount -= 4;
			}
			vScrollBar.Maximum = scrollAmount;

			vScrollBar_Scroll(new Pharmacist(), null);
		}

		private void labelButtonAdd_Click(object sender, EventArgs e)
		{
			this.ActiveControl = labelButtonAdd;
			FormAddPharmacist.ShowAdd();

			TextBoxSearch_TextChanged(null, null);
		}

		private async void vScrollBar_Scroll(object sender, ScrollEventArgs e)
		{
			_scrollPharmacists = new List<Pharmacist>();

			for (int i = vScrollBar.Value * 4; i < vScrollBar.Value * 4 + 4 && i < _pharmacists.Count; i++)
				_scrollPharmacists.Add(_pharmacists[i]);

			for (int j = 0; j < _panels.Count; j++)
				if (j >= _scrollPharmacists.Count)
					_panels[j].Hide();
				else _panels[j].Visible = true;

			for (int i = 0; i < _panels.Count && _scrollPharmacists.Count > i; i++)
			{
				_panels[i].FirstLabel.Text = _scrollPharmacists[i].Surname;//заливаем информацию на палели
				_panels[i].SecondLabel.Text = _scrollPharmacists[i].Name;
				_panels[i].ThirdLabel.Text = $"Продаж за месяц: {await _databaseManager.GetPurchaseAmountAsync(_scrollPharmacists[i].Id)}";
			}
		}
	}
}
