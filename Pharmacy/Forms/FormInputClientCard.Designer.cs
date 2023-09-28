namespace Pharmacy.Forms
{
	partial class FormInputClientCard
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
			this.label1 = new System.Windows.Forms.Label();
			this.addPanelCancel = new Pharmacy.Forms.Elements.AddPanel();
			this.labelCancel = new System.Windows.Forms.Label();
			this.addPanel4 = new Pharmacy.Forms.Elements.AddPanel();
			this.labelOk = new System.Windows.Forms.Label();
			this.addPanel1 = new Pharmacy.Forms.Elements.AddPanel();
			this.numericUpDownCard = new System.Windows.Forms.NumericUpDown();
			this.labelPurchaseWithoutCard = new System.Windows.Forms.Label();
			this.itemPanel1.SuspendLayout();
			this.addPanelCancel.SuspendLayout();
			this.addPanel4.SuspendLayout();
			this.addPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownCard)).BeginInit();
			this.SuspendLayout();
			// 
			// itemPanel1
			// 
			this.itemPanel1.ActionBox = null;
			this.itemPanel1.BackColor = System.Drawing.Color.Transparent;
			this.itemPanel1.Controls.Add(this.labelPurchaseWithoutCard);
			this.itemPanel1.Controls.Add(this.label1);
			this.itemPanel1.Controls.Add(this.addPanelCancel);
			this.itemPanel1.Controls.Add(this.addPanel4);
			this.itemPanel1.Controls.Add(this.addPanel1);
			this.itemPanel1.DeleteBox = null;
			this.itemPanel1.FirstLabel = null;
			this.itemPanel1.Location = new System.Drawing.Point(93, 49);
			this.itemPanel1.Name = "itemPanel1";
			this.itemPanel1.SecondLabel = null;
			this.itemPanel1.Size = new System.Drawing.Size(460, 368);
			this.itemPanel1.TabIndex = 1;
			this.itemPanel1.ThirdLabel = null;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(81, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(281, 44);
			this.label1.TabIndex = 5;
			this.label1.Text = "Номер карты:";
			// 
			// addPanelCancel
			// 
			this.addPanelCancel.BackColor = System.Drawing.Color.Transparent;
			this.addPanelCancel.Controls.Add(this.labelCancel);
			this.addPanelCancel.Location = new System.Drawing.Point(237, 232);
			this.addPanelCancel.Name = "addPanelCancel";
			this.addPanelCancel.Size = new System.Drawing.Size(186, 57);
			this.addPanelCancel.TabIndex = 4;
			// 
			// labelCancel
			// 
			this.labelCancel.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelCancel.Location = new System.Drawing.Point(0, 0);
			this.labelCancel.Name = "labelCancel";
			this.labelCancel.Size = new System.Drawing.Size(183, 57);
			this.labelCancel.TabIndex = 1;
			this.labelCancel.Text = "ОТМЕНА";
			this.labelCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelCancel.Click += new System.EventHandler(this.labelCancel_Click);
			// 
			// addPanel4
			// 
			this.addPanel4.BackColor = System.Drawing.Color.Transparent;
			this.addPanel4.Controls.Add(this.labelOk);
			this.addPanel4.Location = new System.Drawing.Point(26, 232);
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
			this.labelOk.Click += new System.EventHandler(this.labelOk_Click);
			// 
			// addPanel1
			// 
			this.addPanel1.BackColor = System.Drawing.Color.Transparent;
			this.addPanel1.Controls.Add(this.numericUpDownCard);
			this.addPanel1.Location = new System.Drawing.Point(26, 132);
			this.addPanel1.Name = "addPanel1";
			this.addPanel1.Size = new System.Drawing.Size(410, 54);
			this.addPanel1.TabIndex = 0;
			// 
			// numericUpDownCard
			// 
			this.numericUpDownCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
			this.numericUpDownCard.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.numericUpDownCard.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold);
			this.numericUpDownCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.numericUpDownCard.Location = new System.Drawing.Point(29, 3);
			this.numericUpDownCard.Name = "numericUpDownCard";
			this.numericUpDownCard.Size = new System.Drawing.Size(356, 48);
			this.numericUpDownCard.TabIndex = 0;
			this.numericUpDownCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// labelPurchaseWithoutCard
			// 
			this.labelPurchaseWithoutCard.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelPurchaseWithoutCard.Location = new System.Drawing.Point(68, 310);
			this.labelPurchaseWithoutCard.Name = "labelPurchaseWithoutCard";
			this.labelPurchaseWithoutCard.Size = new System.Drawing.Size(327, 39);
			this.labelPurchaseWithoutCard.TabIndex = 1;
			this.labelPurchaseWithoutCard.Text = "Продать без карты";
			this.labelPurchaseWithoutCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPurchaseWithoutCard.Click += new System.EventHandler(this.labelPurchaseWithoutCard_Click);
			// 
			// FormInputClientCard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Pharmacy.Properties.Resources.background2;
			this.ClientSize = new System.Drawing.Size(652, 478);
			this.Controls.Add(this.itemPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FormInputClientCard";
			this.Text = "FormInputClientCard";
			this.itemPanel1.ResumeLayout(false);
			this.itemPanel1.PerformLayout();
			this.addPanelCancel.ResumeLayout(false);
			this.addPanel4.ResumeLayout(false);
			this.addPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownCard)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Elements.ItemPanel itemPanel1;
		private Elements.AddPanel addPanelCancel;
		private System.Windows.Forms.Label labelCancel;
		private Elements.AddPanel addPanel4;
		private System.Windows.Forms.Label labelOk;
		private Elements.AddPanel addPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUpDownCard;
		private System.Windows.Forms.Label labelPurchaseWithoutCard;
	}
}