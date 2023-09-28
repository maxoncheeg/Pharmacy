namespace Pharmacy.Forms
{
	partial class FormMedicationChange
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
			this.itemPanel1 = new Pharmacy.Forms.Elements.ItemPanel();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.addPanelCancel = new Pharmacy.Forms.Elements.AddPanel();
			this.labelCancel = new System.Windows.Forms.Label();
			this.addPanel4 = new Pharmacy.Forms.Elements.AddPanel();
			this.labelOk = new System.Windows.Forms.Label();
			this.addPanel3 = new Pharmacy.Forms.Elements.AddPanel();
			this.numericUpDownPricePart = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
			this.addPanel2 = new Pharmacy.Forms.Elements.AddPanel();
			this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
			this.addPanel1 = new Pharmacy.Forms.Elements.AddPanel();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.itemPanel1.SuspendLayout();
			this.addPanelCancel.SuspendLayout();
			this.addPanel4.SuspendLayout();
			this.addPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPricePart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
			this.addPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
			this.addPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// itemPanel1
			// 
			this.itemPanel1.ActionBox = null;
			this.itemPanel1.BackColor = System.Drawing.Color.Transparent;
			this.itemPanel1.Controls.Add(this.label3);
			this.itemPanel1.Controls.Add(this.label2);
			this.itemPanel1.Controls.Add(this.label1);
			this.itemPanel1.Controls.Add(this.addPanelCancel);
			this.itemPanel1.Controls.Add(this.addPanel4);
			this.itemPanel1.Controls.Add(this.addPanel3);
			this.itemPanel1.Controls.Add(this.addPanel2);
			this.itemPanel1.Controls.Add(this.addPanel1);
			this.itemPanel1.DeleteBox = null;
			this.itemPanel1.FirstLabel = null;
			this.itemPanel1.Location = new System.Drawing.Point(159, 80);
			this.itemPanel1.Name = "itemPanel1";
			this.itemPanel1.SecondLabel = null;
			this.itemPanel1.Size = new System.Drawing.Size(538, 428);
			this.itemPanel1.TabIndex = 1;
			this.itemPanel1.ThirdLabel = null;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(137, 10);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(257, 57);
			this.label3.TabIndex = 2;
			this.label3.Text = "Препарат";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(43, 241);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(222, 37);
			this.label2.TabIndex = 5;
			this.label2.Text = "Стоимость";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(43, 144);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(222, 37);
			this.label1.TabIndex = 2;
			this.label1.Text = "Количество";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// addPanelCancel
			// 
			this.addPanelCancel.BackColor = System.Drawing.Color.Transparent;
			this.addPanelCancel.Controls.Add(this.labelCancel);
			this.addPanelCancel.Location = new System.Drawing.Point(249, 350);
			this.addPanelCancel.Name = "addPanelCancel";
			this.addPanelCancel.Size = new System.Drawing.Size(260, 57);
			this.addPanelCancel.TabIndex = 4;
			// 
			// labelCancel
			// 
			this.labelCancel.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelCancel.Location = new System.Drawing.Point(0, 0);
			this.labelCancel.Name = "labelCancel";
			this.labelCancel.Size = new System.Drawing.Size(257, 57);
			this.labelCancel.TabIndex = 1;
			this.labelCancel.Text = "ОТМЕНА";
			this.labelCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelCancel.Click += new System.EventHandler(this.labelCancel_Click);
			// 
			// addPanel4
			// 
			this.addPanel4.BackColor = System.Drawing.Color.Transparent;
			this.addPanel4.Controls.Add(this.labelOk);
			this.addPanel4.Location = new System.Drawing.Point(38, 350);
			this.addPanel4.Name = "addPanel4";
			this.addPanel4.Size = new System.Drawing.Size(181, 57);
			this.addPanel4.TabIndex = 3;
			// 
			// labelOk
			// 
			this.labelOk.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelOk.Location = new System.Drawing.Point(3, 0);
			this.labelOk.Name = "labelOk";
			this.labelOk.Size = new System.Drawing.Size(178, 57);
			this.labelOk.TabIndex = 0;
			this.labelOk.Text = "OK";
			this.labelOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// addPanel3
			// 
			this.addPanel3.BackColor = System.Drawing.Color.Transparent;
			this.addPanel3.Controls.Add(this.numericUpDownPricePart);
			this.addPanel3.Controls.Add(this.numericUpDownPrice);
			this.addPanel3.Location = new System.Drawing.Point(38, 279);
			this.addPanel3.Name = "addPanel3";
			this.addPanel3.Size = new System.Drawing.Size(471, 54);
			this.addPanel3.TabIndex = 2;
			// 
			// numericUpDownPricePart
			// 
			this.numericUpDownPricePart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
			this.numericUpDownPricePart.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.numericUpDownPricePart.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold);
			this.numericUpDownPricePart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.numericUpDownPricePart.Location = new System.Drawing.Point(307, 3);
			this.numericUpDownPricePart.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
			this.numericUpDownPricePart.Name = "numericUpDownPricePart";
			this.numericUpDownPricePart.Size = new System.Drawing.Size(125, 48);
			this.numericUpDownPricePart.TabIndex = 2;
			this.numericUpDownPricePart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDownPricePart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// numericUpDownPrice
			// 
			this.numericUpDownPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
			this.numericUpDownPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.numericUpDownPrice.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold);
			this.numericUpDownPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.numericUpDownPrice.Location = new System.Drawing.Point(57, 3);
			this.numericUpDownPrice.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
			this.numericUpDownPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDownPrice.Name = "numericUpDownPrice";
			this.numericUpDownPrice.Size = new System.Drawing.Size(244, 48);
			this.numericUpDownPrice.TabIndex = 1;
			this.numericUpDownPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDownPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// addPanel2
			// 
			this.addPanel2.BackColor = System.Drawing.Color.Transparent;
			this.addPanel2.Controls.Add(this.numericUpDownAmount);
			this.addPanel2.Location = new System.Drawing.Point(38, 184);
			this.addPanel2.Name = "addPanel2";
			this.addPanel2.Size = new System.Drawing.Size(471, 54);
			this.addPanel2.TabIndex = 2;
			// 
			// numericUpDownAmount
			// 
			this.numericUpDownAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
			this.numericUpDownAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.numericUpDownAmount.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold);
			this.numericUpDownAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.numericUpDownAmount.Location = new System.Drawing.Point(57, 3);
			this.numericUpDownAmount.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.numericUpDownAmount.Name = "numericUpDownAmount";
			this.numericUpDownAmount.Size = new System.Drawing.Size(356, 48);
			this.numericUpDownAmount.TabIndex = 1;
			this.numericUpDownAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDownAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// addPanel1
			// 
			this.addPanel1.BackColor = System.Drawing.Color.Transparent;
			this.addPanel1.Controls.Add(this.textBoxName);
			this.addPanel1.Location = new System.Drawing.Point(38, 81);
			this.addPanel1.Name = "addPanel1";
			this.addPanel1.Size = new System.Drawing.Size(471, 54);
			this.addPanel1.TabIndex = 0;
			// 
			// textBoxName
			// 
			this.textBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
			this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.textBoxName.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.textBoxName.Location = new System.Drawing.Point(25, 3);
			this.textBoxName.MaxLength = 20;
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(422, 45);
			this.textBoxName.TabIndex = 1;
			this.textBoxName.Text = "Название";
			// 
			// FormMedicationChange
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImage = global::Pharmacy.Properties.Resources.background2;
			this.ClientSize = new System.Drawing.Size(841, 562);
			this.Controls.Add(this.itemPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FormMedicationChange";
			this.Text = "FormMedicationChange";
			this.itemPanel1.ResumeLayout(false);
			this.addPanelCancel.ResumeLayout(false);
			this.addPanel4.ResumeLayout(false);
			this.addPanel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPricePart)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
			this.addPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
			this.addPanel1.ResumeLayout(false);
			this.addPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Elements.ItemPanel itemPanel1;
		private Elements.AddPanel addPanelCancel;
		private System.Windows.Forms.Label labelCancel;
		private Elements.AddPanel addPanel4;
		private System.Windows.Forms.Label labelOk;
		private Elements.AddPanel addPanel3;
		private Elements.AddPanel addPanel2;
		private Elements.AddPanel addPanel1;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUpDownPrice;
		private System.Windows.Forms.NumericUpDown numericUpDownAmount;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown numericUpDownPricePart;
	}
}