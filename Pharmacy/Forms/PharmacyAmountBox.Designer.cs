namespace Pharmacy.Forms
{
	partial class PharmacyAmountBox
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
			this.authorizationPanel1 = new Pharmacy.Forms.Elements.AuthorizationPanel();
			this.loginButton = new Pharmacy.Forms.Elements.LoginPanel();
			this.labelButtonOk = new System.Windows.Forms.Label();
			this.labelMedication = new System.Windows.Forms.Label();
			this.itemPanel3 = new Pharmacy.Forms.Elements.ItemPanel();
			this.label11 = new System.Windows.Forms.Label();
			this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
			this.loginPanel1 = new Pharmacy.Forms.Elements.LoginPanel();
			this.labelCancel = new System.Windows.Forms.Label();
			this.authorizationPanel1.SuspendLayout();
			this.loginButton.SuspendLayout();
			this.itemPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
			this.loginPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// authorizationPanel1
			// 
			this.authorizationPanel1.BackColor = System.Drawing.Color.Transparent;
			this.authorizationPanel1.Controls.Add(this.loginPanel1);
			this.authorizationPanel1.Controls.Add(this.itemPanel3);
			this.authorizationPanel1.Controls.Add(this.loginButton);
			this.authorizationPanel1.Controls.Add(this.labelMedication);
			this.authorizationPanel1.Location = new System.Drawing.Point(110, 43);
			this.authorizationPanel1.Name = "authorizationPanel1";
			this.authorizationPanel1.Size = new System.Drawing.Size(386, 274);
			this.authorizationPanel1.TabIndex = 3;
			// 
			// loginButton
			// 
			this.loginButton.BackColor = System.Drawing.Color.Transparent;
			this.loginButton.Controls.Add(this.labelButtonOk);
			this.loginButton.Location = new System.Drawing.Point(61, 206);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(114, 41);
			this.loginButton.TabIndex = 4;
			// 
			// labelButtonOk
			// 
			this.labelButtonOk.AutoSize = true;
			this.labelButtonOk.BackColor = System.Drawing.Color.Transparent;
			this.labelButtonOk.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelButtonOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(203)))), ((int)(((byte)(208)))));
			this.labelButtonOk.Location = new System.Drawing.Point(3, 0);
			this.labelButtonOk.Name = "labelButtonOk";
			this.labelButtonOk.Size = new System.Drawing.Size(109, 37);
			this.labelButtonOk.TabIndex = 5;
			this.labelButtonOk.Text = "   ОК   ";
			this.labelButtonOk.Click += new System.EventHandler(this.labelButtonOk_Click);
			// 
			// labelMedication
			// 
			this.labelMedication.BackColor = System.Drawing.Color.Transparent;
			this.labelMedication.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMedication.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
			this.labelMedication.Location = new System.Drawing.Point(23, 14);
			this.labelMedication.Name = "labelMedication";
			this.labelMedication.Size = new System.Drawing.Size(345, 57);
			this.labelMedication.TabIndex = 0;
			this.labelMedication.Text = "ПРЕПАРАТ";
			this.labelMedication.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// itemPanel3
			// 
			this.itemPanel3.ActionBox = null;
			this.itemPanel3.BackColor = System.Drawing.Color.Transparent;
			this.itemPanel3.Controls.Add(this.label11);
			this.itemPanel3.Controls.Add(this.numericUpDownAmount);
			this.itemPanel3.DeleteBox = null;
			this.itemPanel3.FirstLabel = null;
			this.itemPanel3.Location = new System.Drawing.Point(61, 87);
			this.itemPanel3.Name = "itemPanel3";
			this.itemPanel3.SecondLabel = null;
			this.itemPanel3.Size = new System.Drawing.Size(276, 100);
			this.itemPanel3.TabIndex = 6;
			this.itemPanel3.ThirdLabel = null;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label11.Location = new System.Drawing.Point(174, 26);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(99, 38);
			this.label11.TabIndex = 7;
			this.label11.Text = "шт.";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// numericUpDownAmount
			// 
			this.numericUpDownAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
			this.numericUpDownAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.numericUpDownAmount.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.numericUpDownAmount.Location = new System.Drawing.Point(16, 32);
			this.numericUpDownAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDownAmount.Name = "numericUpDownAmount";
			this.numericUpDownAmount.Size = new System.Drawing.Size(125, 32);
			this.numericUpDownAmount.TabIndex = 6;
			this.numericUpDownAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDownAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// loginPanel1
			// 
			this.loginPanel1.BackColor = System.Drawing.Color.Transparent;
			this.loginPanel1.Controls.Add(this.labelCancel);
			this.loginPanel1.Location = new System.Drawing.Point(181, 206);
			this.loginPanel1.Name = "loginPanel1";
			this.loginPanel1.Size = new System.Drawing.Size(156, 41);
			this.loginPanel1.TabIndex = 6;
			// 
			// labelCancel
			// 
			this.labelCancel.BackColor = System.Drawing.Color.Transparent;
			this.labelCancel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(203)))), ((int)(((byte)(208)))));
			this.labelCancel.Location = new System.Drawing.Point(3, 0);
			this.labelCancel.Name = "labelCancel";
			this.labelCancel.Size = new System.Drawing.Size(150, 37);
			this.labelCancel.TabIndex = 5;
			this.labelCancel.Text = "ОТМЕНА";
			this.labelCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelCancel.Click += new System.EventHandler(this.labelCancel_Click);
			// 
			// PharmacyAmountBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Pharmacy.Properties.Resources.background2;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(606, 360);
			this.Controls.Add(this.authorizationPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "PharmacyAmountBox";
			this.Text = "PharmacyAmountBox";
			this.authorizationPanel1.ResumeLayout(false);
			this.loginButton.ResumeLayout(false);
			this.loginButton.PerformLayout();
			this.itemPanel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
			this.loginPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Elements.AuthorizationPanel authorizationPanel1;
		private Elements.LoginPanel loginButton;
		private System.Windows.Forms.Label labelButtonOk;
		private System.Windows.Forms.Label labelMedication;
		private Elements.LoginPanel loginPanel1;
		private System.Windows.Forms.Label labelCancel;
		private Elements.ItemPanel itemPanel3;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.NumericUpDown numericUpDownAmount;
	}
}