using Pharmacy.Classes;
using Pharmacy.Data.Classes;
using Pharmacy.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.Forms.Panels
{
	public partial class FormPurchasePanel : Form
	{
		private long _cardNumber;
		private DatabaseManager _databaseManager;
		private LoginManager _loginManager;

		public FormPurchasePanel(LoginManager _loginManager, long _cardNumber)
		{
			InitializeComponent();
			this.Load += FormPurchasePanel_Load;

			this._cardNumber = _cardNumber;
			this._loginManager = _loginManager;
			_databaseManager = DatabaseManager.Create();
			listBoxCartMedication.SelectedIndexChanged += ListBoxCartMedication_SelectedIndexChanged;
			listBoxCartMedication.DoubleClick += ListBoxCartMedication_DoubleClick;
		}

		private void ListBoxCartMedication_DoubleClick(object sender, EventArgs e)
		{
			if (listBoxCartMedication.SelectedIndex != -1)
			{
				_databaseManager.CartMedications.RemoveAt(listBoxCartMedication.SelectedIndex);
				_databaseManager.Cart.Remove(_databaseManager.Cart.Keys.ElementAt(listBoxCartMedication.SelectedIndex));

				UpdateListAsync();
				SetPrice();
			}
		}

		private void ListBoxCartMedication_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(listBoxCartMedication.SelectedIndex != -1)
			{
				labelMedicationName.Text = _databaseManager.CartMedications[listBoxCartMedication.SelectedIndex].Name;
				labelAmount.Text = _databaseManager.Cart[_databaseManager.CartMedications[listBoxCartMedication.SelectedIndex].Id].ToString() + " шт.";
			}
		}

		private void FormPurchasePanel_Load(object sender, EventArgs e)
		{
			FormPlacer.ToScreenCenter(this);
			this.ActiveControl = label1;
			UpdateListAsync();
			SetPrice();

			if(listBoxCartMedication.Items.Count > 0)
			{
				listBoxCartMedication.SelectedIndex = 0;
			}
		}

		private void UpdateListAsync()
		{
			listBoxCartMedication.Items.Clear();

			foreach (var medicationId in _databaseManager.Cart.Keys)
			{
				Medication medication = _databaseManager.CartMedications.Find(x => x.Id == medicationId);
				long amount;
				_databaseManager.Cart.TryGetValue(medicationId, out amount);
				listBoxCartMedication.Items.Add(
					$"{medication.Name} | {medication.Price} руб. | {amount} шт.");
			}
		}

		private double _totalPrice = 0;
		private async void SetPrice()
		{
			double totalPrice = 0, discountPrice = 0;
			int discount = 0;
			foreach (var medicationId in _databaseManager.Cart.Keys)
			{
				Medication medication = _databaseManager.CartMedications.Find(x => x.Id == medicationId);
				long amount;
				_databaseManager.Cart.TryGetValue(medicationId, out amount);
				totalPrice += medication.Price * amount;
			}

			discount = await _databaseManager.GetDiscountAsync(_cardNumber);
			discountPrice = totalPrice - totalPrice / 100 * discount;
			_totalPrice = discountPrice;
			labelTotalPrice.Text = totalPrice.ToString() + "р.";
			labelDiscountPrice.Text = discountPrice.ToString() + "р.";
			labelDiscount.Text = discount.ToString() + "%";

			if(discount == 0)
				labelTotalPrice.Visible = false;
			else labelTotalPrice.Visible = true;
		}

		private async void labelPurchase_Click(object sender, EventArgs e)
		{
			if (_databaseManager.Cart.Count == 0) return;

			if (!await _databaseManager.PurchaseMedicationAsync(_loginManager.LoginUser as Pharmacist, _cardNumber, _totalPrice))
				PharmacyMessageBox.Show("Ошибка", "Не удалось совершить продажу");
			else
			{
				PharmacyMessageBox.Show("Продано", "Препараты успешно проданы");
			}

			UpdateListAsync();
			SetPrice();
		}
	}
}
