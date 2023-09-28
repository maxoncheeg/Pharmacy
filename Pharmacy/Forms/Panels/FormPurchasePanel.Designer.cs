namespace Pharmacy.Forms.Panels
{
	partial class FormPurchasePanel
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.itemPanel3 = new Pharmacy.Forms.Elements.ItemPanel();
			this.labelAmount = new System.Windows.Forms.Label();
			this.labelMedicationName = new System.Windows.Forms.Label();
			this.actionPanel4 = new Pharmacy.Forms.Elements.ActionPanel();
			this.label9 = new System.Windows.Forms.Label();
			this.actionPanel3 = new Pharmacy.Forms.Elements.ActionPanel();
			this.labelPurchase = new System.Windows.Forms.Label();
			this.itemPanel2 = new Pharmacy.Forms.Elements.ItemPanel();
			this.labelDiscount = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.labelTotalPrice = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.labelDiscountPrice = new System.Windows.Forms.Label();
			this.actionPanel2 = new Pharmacy.Forms.Elements.ActionPanel();
			this.label2 = new System.Windows.Forms.Label();
			this.actionPanel1 = new Pharmacy.Forms.Elements.ActionPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.itemPanel1 = new Pharmacy.Forms.Elements.ItemPanel();
			this.listBoxCartMedication = new System.Windows.Forms.ListBox();
			this.itemPanel3.SuspendLayout();
			this.actionPanel4.SuspendLayout();
			this.actionPanel3.SuspendLayout();
			this.itemPanel2.SuspendLayout();
			this.actionPanel2.SuspendLayout();
			this.actionPanel1.SuspendLayout();
			this.itemPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// itemPanel3
			// 
			this.itemPanel3.ActionBox = null;
			this.itemPanel3.BackColor = System.Drawing.Color.Transparent;
			this.itemPanel3.Controls.Add(this.labelAmount);
			this.itemPanel3.Controls.Add(this.labelMedicationName);
			this.itemPanel3.DeleteBox = null;
			this.itemPanel3.FirstLabel = null;
			this.itemPanel3.Location = new System.Drawing.Point(477, 111);
			this.itemPanel3.Name = "itemPanel3";
			this.itemPanel3.SecondLabel = null;
			this.itemPanel3.Size = new System.Drawing.Size(538, 100);
			this.itemPanel3.TabIndex = 5;
			this.itemPanel3.ThirdLabel = null;
			// 
			// labelAmount
			// 
			this.labelAmount.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelAmount.Location = new System.Drawing.Point(281, 30);
			this.labelAmount.Name = "labelAmount";
			this.labelAmount.Size = new System.Drawing.Size(230, 38);
			this.labelAmount.TabIndex = 7;
			this.labelAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelMedicationName
			// 
			this.labelMedicationName.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelMedicationName.Location = new System.Drawing.Point(19, 19);
			this.labelMedicationName.Name = "labelMedicationName";
			this.labelMedicationName.Size = new System.Drawing.Size(256, 61);
			this.labelMedicationName.TabIndex = 5;
			this.labelMedicationName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// actionPanel4
			// 
			this.actionPanel4.BackColor = System.Drawing.Color.Transparent;
			this.actionPanel4.Controls.Add(this.label9);
			this.actionPanel4.Location = new System.Drawing.Point(418, 39);
			this.actionPanel4.Name = "actionPanel4";
			this.actionPanel4.Size = new System.Drawing.Size(312, 57);
			this.actionPanel4.TabIndex = 4;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label9.Location = new System.Drawing.Point(3, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(306, 51);
			this.label9.TabIndex = 0;
			this.label9.Text = "Кол-во препарата";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// actionPanel3
			// 
			this.actionPanel3.BackColor = System.Drawing.Color.Transparent;
			this.actionPanel3.Controls.Add(this.labelPurchase);
			this.actionPanel3.Location = new System.Drawing.Point(703, 469);
			this.actionPanel3.Name = "actionPanel3";
			this.actionPanel3.Size = new System.Drawing.Size(312, 57);
			this.actionPanel3.TabIndex = 4;
			// 
			// labelPurchase
			// 
			this.labelPurchase.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelPurchase.Location = new System.Drawing.Point(3, 0);
			this.labelPurchase.Name = "labelPurchase";
			this.labelPurchase.Size = new System.Drawing.Size(306, 51);
			this.labelPurchase.TabIndex = 0;
			this.labelPurchase.Text = "  Продать";
			this.labelPurchase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelPurchase.Click += new System.EventHandler(this.labelPurchase_Click);
			// 
			// itemPanel2
			// 
			this.itemPanel2.ActionBox = null;
			this.itemPanel2.BackColor = System.Drawing.Color.Transparent;
			this.itemPanel2.Controls.Add(this.labelDiscount);
			this.itemPanel2.Controls.Add(this.label6);
			this.itemPanel2.Controls.Add(this.labelTotalPrice);
			this.itemPanel2.Controls.Add(this.label4);
			this.itemPanel2.Controls.Add(this.labelDiscountPrice);
			this.itemPanel2.DeleteBox = null;
			this.itemPanel2.FirstLabel = null;
			this.itemPanel2.Location = new System.Drawing.Point(477, 313);
			this.itemPanel2.Name = "itemPanel2";
			this.itemPanel2.SecondLabel = null;
			this.itemPanel2.Size = new System.Drawing.Size(538, 141);
			this.itemPanel2.TabIndex = 4;
			this.itemPanel2.ThirdLabel = null;
			// 
			// labelDiscount
			// 
			this.labelDiscount.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelDiscount.Location = new System.Drawing.Point(310, 19);
			this.labelDiscount.Name = "labelDiscount";
			this.labelDiscount.Size = new System.Drawing.Size(216, 37);
			this.labelDiscount.TabIndex = 4;
			this.labelDiscount.Text = "0%";
			this.labelDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(19, 18);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(228, 38);
			this.label6.TabIndex = 3;
			this.label6.Text = "Размер скидки";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelTotalPrice
			// 
			this.labelTotalPrice.Font = new System.Drawing.Font("Century Gothic", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelTotalPrice.ForeColor = System.Drawing.Color.DarkGray;
			this.labelTotalPrice.Location = new System.Drawing.Point(310, 107);
			this.labelTotalPrice.Name = "labelTotalPrice";
			this.labelTotalPrice.Size = new System.Drawing.Size(216, 23);
			this.labelTotalPrice.TabIndex = 3;
			this.labelTotalPrice.Text = "0";
			this.labelTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(14, 70);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(233, 37);
			this.label4.TabIndex = 1;
			this.label4.Text = "Стоимость";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelDiscountPrice
			// 
			this.labelDiscountPrice.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelDiscountPrice.Location = new System.Drawing.Point(310, 70);
			this.labelDiscountPrice.Name = "labelDiscountPrice";
			this.labelDiscountPrice.Size = new System.Drawing.Size(216, 37);
			this.labelDiscountPrice.TabIndex = 2;
			this.labelDiscountPrice.Text = "0 р.";
			this.labelDiscountPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// actionPanel2
			// 
			this.actionPanel2.BackColor = System.Drawing.Color.Transparent;
			this.actionPanel2.Controls.Add(this.label2);
			this.actionPanel2.Location = new System.Drawing.Point(421, 236);
			this.actionPanel2.Name = "actionPanel2";
			this.actionPanel2.Size = new System.Drawing.Size(312, 57);
			this.actionPanel2.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(3, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(306, 51);
			this.label2.TabIndex = 0;
			this.label2.Text = "Итоговая стоимость";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// actionPanel1
			// 
			this.actionPanel1.BackColor = System.Drawing.Color.Transparent;
			this.actionPanel1.Controls.Add(this.label1);
			this.actionPanel1.Location = new System.Drawing.Point(75, 39);
			this.actionPanel1.Name = "actionPanel1";
			this.actionPanel1.Size = new System.Drawing.Size(312, 57);
			this.actionPanel1.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(306, 51);
			this.label1.TabIndex = 0;
			this.label1.Text = "Корзина";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// itemPanel1
			// 
			this.itemPanel1.ActionBox = null;
			this.itemPanel1.BackColor = System.Drawing.Color.Transparent;
			this.itemPanel1.Controls.Add(this.listBoxCartMedication);
			this.itemPanel1.DeleteBox = null;
			this.itemPanel1.FirstLabel = null;
			this.itemPanel1.Location = new System.Drawing.Point(72, 111);
			this.itemPanel1.Name = "itemPanel1";
			this.itemPanel1.SecondLabel = null;
			this.itemPanel1.Size = new System.Drawing.Size(318, 415);
			this.itemPanel1.TabIndex = 1;
			this.itemPanel1.ThirdLabel = null;
			// 
			// listBoxCartMedication
			// 
			this.listBoxCartMedication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
			this.listBoxCartMedication.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listBoxCartMedication.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
			this.listBoxCartMedication.FormattingEnabled = true;
			this.listBoxCartMedication.ItemHeight = 19;
			this.listBoxCartMedication.Location = new System.Drawing.Point(3, 19);
			this.listBoxCartMedication.Name = "listBoxCartMedication";
			this.listBoxCartMedication.Size = new System.Drawing.Size(312, 342);
			this.listBoxCartMedication.TabIndex = 0;
			// 
			// FormPurchasePanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Pharmacy.Properties.Resources.background2;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(1071, 554);
			this.Controls.Add(this.itemPanel3);
			this.Controls.Add(this.actionPanel4);
			this.Controls.Add(this.actionPanel3);
			this.Controls.Add(this.itemPanel2);
			this.Controls.Add(this.actionPanel2);
			this.Controls.Add(this.actionPanel1);
			this.Controls.Add(this.itemPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormPurchasePanel";
			this.itemPanel3.ResumeLayout(false);
			this.actionPanel4.ResumeLayout(false);
			this.actionPanel3.ResumeLayout(false);
			this.itemPanel2.ResumeLayout(false);
			this.actionPanel2.ResumeLayout(false);
			this.actionPanel1.ResumeLayout(false);
			this.itemPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox listBoxCartMedication;
		private Elements.ItemPanel itemPanel1;
		private Elements.ActionPanel actionPanel1;
		private System.Windows.Forms.Label label1;
		private Elements.ActionPanel actionPanel2;
		private System.Windows.Forms.Label label2;
		private Elements.ItemPanel itemPanel2;
		private System.Windows.Forms.Label labelDiscount;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label labelTotalPrice;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label labelDiscountPrice;
		private Elements.ActionPanel actionPanel3;
		private System.Windows.Forms.Label labelPurchase;
		private Elements.ActionPanel actionPanel4;
		private System.Windows.Forms.Label label9;
		private Elements.ItemPanel itemPanel3;
		private System.Windows.Forms.Label labelAmount;
		private System.Windows.Forms.Label labelMedicationName;
	}
}