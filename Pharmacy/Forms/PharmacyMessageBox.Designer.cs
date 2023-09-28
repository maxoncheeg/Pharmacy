namespace Pharmacy.Forms
{
	partial class PharmacyMessageBox
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
			this.loginPanel1 = new Pharmacy.Forms.Elements.LoginPanel();
			this.labelCancel = new System.Windows.Forms.Label();
			this.labelText = new System.Windows.Forms.Label();
			this.loginButton = new Pharmacy.Forms.Elements.LoginPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.labelButtonOk = new System.Windows.Forms.Label();
			this.labelTitle = new System.Windows.Forms.Label();
			this.authorizationPanel1.SuspendLayout();
			this.loginPanel1.SuspendLayout();
			this.loginButton.SuspendLayout();
			this.SuspendLayout();
			// 
			// authorizationPanel1
			// 
			this.authorizationPanel1.BackColor = System.Drawing.Color.Transparent;
			this.authorizationPanel1.Controls.Add(this.loginPanel1);
			this.authorizationPanel1.Controls.Add(this.labelText);
			this.authorizationPanel1.Controls.Add(this.loginButton);
			this.authorizationPanel1.Controls.Add(this.labelTitle);
			this.authorizationPanel1.Location = new System.Drawing.Point(110, 37);
			this.authorizationPanel1.Name = "authorizationPanel1";
			this.authorizationPanel1.Size = new System.Drawing.Size(386, 308);
			this.authorizationPanel1.TabIndex = 2;
			// 
			// loginPanel1
			// 
			this.loginPanel1.BackColor = System.Drawing.Color.Transparent;
			this.loginPanel1.Controls.Add(this.labelCancel);
			this.loginPanel1.Location = new System.Drawing.Point(119, 255);
			this.loginPanel1.Name = "loginPanel1";
			this.loginPanel1.Size = new System.Drawing.Size(163, 41);
			this.loginPanel1.TabIndex = 7;
			// 
			// labelCancel
			// 
			this.labelCancel.BackColor = System.Drawing.Color.Transparent;
			this.labelCancel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(203)))), ((int)(((byte)(208)))));
			this.labelCancel.Location = new System.Drawing.Point(3, 0);
			this.labelCancel.Name = "labelCancel";
			this.labelCancel.Size = new System.Drawing.Size(160, 37);
			this.labelCancel.TabIndex = 6;
			this.labelCancel.Text = "ОТМЕНА";
			this.labelCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelCancel.Click += new System.EventHandler(this.labelCancel_Click);
			// 
			// labelText
			// 
			this.labelText.BackColor = System.Drawing.Color.Transparent;
			this.labelText.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(203)))), ((int)(((byte)(208)))));
			this.labelText.Location = new System.Drawing.Point(34, 67);
			this.labelText.Name = "labelText";
			this.labelText.Size = new System.Drawing.Size(321, 138);
			this.labelText.TabIndex = 5;
			this.labelText.Text = "Неправильно\r\nвведены данные";
			this.labelText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// loginButton
			// 
			this.loginButton.BackColor = System.Drawing.Color.Transparent;
			this.loginButton.Controls.Add(this.label1);
			this.loginButton.Controls.Add(this.labelButtonOk);
			this.loginButton.Location = new System.Drawing.Point(142, 208);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(114, 41);
			this.loginButton.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(203)))), ((int)(((byte)(208)))));
			this.label1.Location = new System.Drawing.Point(3, 2);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 37);
			this.label1.TabIndex = 6;
			this.label1.Text = "   ОК   ";
			this.label1.Click += new System.EventHandler(this.label1_Click);
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
			// 
			// labelTitle
			// 
			this.labelTitle.BackColor = System.Drawing.Color.Transparent;
			this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
			this.labelTitle.Location = new System.Drawing.Point(0, 11);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(383, 46);
			this.labelTitle.TabIndex = 0;
			this.labelTitle.Text = "ОШИБКА";
			this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// PharmacyMessageBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Pharmacy.Properties.Resources.background;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(606, 407);
			this.Controls.Add(this.authorizationPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "PharmacyMessageBox";
			this.Text = "PharmacyMessageBox";
			this.Load += new System.EventHandler(this.PharmacyMessageBox_Load);
			this.authorizationPanel1.ResumeLayout(false);
			this.loginPanel1.ResumeLayout(false);
			this.loginButton.ResumeLayout(false);
			this.loginButton.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Elements.AuthorizationPanel authorizationPanel1;
		private System.Windows.Forms.Label labelText;
		private Elements.LoginPanel loginButton;
		private System.Windows.Forms.Label labelButtonOk;
		private System.Windows.Forms.Label labelTitle;
		private Elements.LoginPanel loginPanel1;
		private System.Windows.Forms.Label labelCancel;
		private System.Windows.Forms.Label label1;
	}
}