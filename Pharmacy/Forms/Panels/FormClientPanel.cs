using Pharmacy.Data.Classes;
using Pharmacy.Forms.Elements;
using Pharmacy.Managers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pharmacy.Forms.Panels
{
	public partial class FormClientPanel : Form
	{
		private List<Client> _clients;
		private List<Client> _scrollClients;
		private DatabaseManager _databaseManager;
		private List<ItemPanel> _panels;
		private LoginManager _loginManager;

		public FormClientPanel(LoginManager _loginManager)
		{
			InitializeComponent();

			textBoxSearch.GotFocus += TextBoxSearch_GotFocus;
			textBoxSearch.LostFocus += TextBoxSearch_LostFocus;
			textBoxSearch.TextChanged += TextBoxSearch_TextChanged; //при изменении текста

			vScrollBar.ValueChanged += vScrollBar_Scroll;

			this._databaseManager = DatabaseManager.Create();
			this._loginManager = _loginManager;
			this.MouseWheel += new MouseEventHandler(OnScroll);

			PanelInitialization();//объявляем для каждой панели textBox

			_panels = new List<ItemPanel>() { itemPanel1, itemPanel2, itemPanel3, itemPanel4 }; //делаем лист панелей

			foreach (var item in _panels)//для панелей добавляем события на кнопки
			{
				item.ActionBox.Click += ActionBox_Click;
				item.DeleteBox.Click += DeleteBox_Click;
			}

			this.Load += FormClientPanel_Load;
		}

		private void OnScroll(object sender, MouseEventArgs args)
		{
			if (args.Delta < 0)
			{
				if (vScrollBar.Value == vScrollBar.Maximum) return;
				vScrollBar.Value++;
			}
			else {
				if (vScrollBar.Value == 0) return;
				vScrollBar.Value--;
			}
		}

		private async void DeleteBox_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < _panels.Count; i++)//ищем нужную кнопку, индекс панели, чтобы найти нужного клиента
				if (_panels[i].DeleteBox == sender as PictureBox)
				{
					Client onDelete = _scrollClients[i];
					if (PharmacyMessageBox.ShowOkCancel("Внимание", "Вы хотите удалить всю информацию о клиенте?"))
					{
						if (await _databaseManager.DeleteClientAsync(onDelete))//удаляем
							PharmacyMessageBox.Show("Успех", "Клиент успешно удален!");
						else
							PharmacyMessageBox.Show("Ошибка", "Не удалость удалить клиента!");
					}
				}

			TextBoxSearch_TextChanged(null, null);//обновляем
		}

		private void ActionBox_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < _panels.Count; i++)//та же схема
				if (_panels[i].ActionBox == sender as PictureBox)
					FormClientChange.Show(_scrollClients[i]);//запускаем форму изменения

			TextBoxSearch_TextChanged(null, null);//обновляем
		}

		private void FormClientPanel_Load(object sender, EventArgs e)
		{
			this.ActiveControl = panel1;
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

		bool isSearching = false;
		private async void TextBoxSearch_TextChanged(object sender, EventArgs e)
		{
			if (isSearching) return;
			isSearching = true;
			vScrollBar.Value = 0;
			if (textBoxSearch.Text == "Поиск")//это слово placeholder. но для пользователя  это ""
				_clients = await _databaseManager.GetClientsAsync("");
			else
				_clients = await _databaseManager.GetClientsAsync(textBoxSearch.Text); //иначе то, что там написано

			int scrollAmount = 0, amount = _clients.Count;
			while(amount > 0)
			{
				if(amount - 4 > 0)
					scrollAmount++;
				amount -= 4;
			}
			vScrollBar.Maximum = scrollAmount;

			vScrollBar_Scroll(null, null);
			isSearching = false;
		}

		private void PanelInitialization()
		{
			itemPanel1.FirstLabel = labelSurname1;
			itemPanel1.SecondLabel = labelName1;
			itemPanel1.ThirdLabel = labelBirthDate1;
			itemPanel1.ActionBox = pictureBoxAction1;
			itemPanel1.DeleteBox = pictureBoxDelete1;

			itemPanel2.FirstLabel = labelSurname2;
			itemPanel2.SecondLabel = labelName2;
			itemPanel2.ThirdLabel = labelBirthDate2;
			itemPanel2.ActionBox = pictureBoxAction2;
			itemPanel2.DeleteBox = pictureBoxDelete2;

			itemPanel3.FirstLabel = labelSurname3;
			itemPanel3.SecondLabel = labelName3;
			itemPanel3.ThirdLabel = labelBirthDate3;
			itemPanel3.ActionBox = pictureBoxAction3;
			itemPanel3.DeleteBox = pictureBoxDelete3;

			itemPanel4.FirstLabel = labelSurname4;
			itemPanel4.SecondLabel = labelName4;
			itemPanel4.ThirdLabel = labelBirthDate4;
			itemPanel4.ActionBox = pictureBoxAction4;
			itemPanel4.DeleteBox = pictureBoxDelete4;
		}

		private void labelButtonAdd_Click(object sender, EventArgs e)//добавление клиента
		{
			this.ActiveControl = labelButtonAdd;
			Panels.FormAddClientPanel form = new FormAddClientPanel(_loginManager);
			form.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			form.ShowDialog();

			TextBoxSearch_TextChanged(null, null);
		}

		private void vScrollBar_Scroll(object sender, EventArgs e)
		{
			_scrollClients = new List<Client>();

			for (int i = vScrollBar.Value * 4; i < vScrollBar.Value * 4 + 4 && i < _clients.Count; i++)
				_scrollClients.Add(_clients[i]);

			for (int j = 0; j < _panels.Count; j++)
				if (j >= _scrollClients.Count)
					_panels[j].Hide();
				else _panels[j].Visible = true;

			for (int i = 0; i < _panels.Count && _scrollClients.Count > i; i++)
			{
				_panels[i].FirstLabel.Text = _scrollClients[i].Surname;//заливаем информацию на палели
				_panels[i].SecondLabel.Text = _scrollClients[i].Name;
				_panels[i].ThirdLabel.Text = _scrollClients[i].BirthDate.ToShortDateString();
			}
		}
	}
}
