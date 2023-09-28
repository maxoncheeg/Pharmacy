namespace Pharmacy.Forms
{
	partial class FormAuthorization
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
			this.labelButtonLogin = new System.Windows.Forms.Label();
			this.loginPanel2 = new Pharmacy.Forms.Elements.LoginPanel();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.loginPanel1 = new Pharmacy.Forms.Elements.LoginPanel();
			this.textBoxLogin = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.authorizationPanel1.SuspendLayout();
			this.loginButton.SuspendLayout();
			this.loginPanel2.SuspendLayout();
			this.loginPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// authorizationPanel1
			// 
			this.authorizationPanel1.BackColor = System.Drawing.Color.Transparent;
			this.authorizationPanel1.Controls.Add(this.loginButton);
			this.authorizationPanel1.Controls.Add(this.loginPanel2);
			this.authorizationPanel1.Controls.Add(this.loginPanel1);
			this.authorizationPanel1.Controls.Add(this.label1);
			this.authorizationPanel1.Location = new System.Drawing.Point(356, 208);
			this.authorizationPanel1.Name = "authorizationPanel1";
			this.authorizationPanel1.Size = new System.Drawing.Size(386, 274);
			this.authorizationPanel1.TabIndex = 1;
			// 
			// loginButton
			// 
			this.loginButton.BackColor = System.Drawing.Color.Transparent;
			this.loginButton.Controls.Add(this.labelButtonLogin);
			this.loginButton.Location = new System.Drawing.Point(126, 208);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(140, 41);
			this.loginButton.TabIndex = 4;
			// 
			// labelButtonLogin
			// 
			this.labelButtonLogin.AutoSize = true;
			this.labelButtonLogin.BackColor = System.Drawing.Color.Transparent;
			this.labelButtonLogin.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelButtonLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(203)))), ((int)(((byte)(208)))));
			this.labelButtonLogin.Location = new System.Drawing.Point(3, 0);
			this.labelButtonLogin.Name = "labelButtonLogin";
			this.labelButtonLogin.Size = new System.Drawing.Size(137, 37);
			this.labelButtonLogin.TabIndex = 5;
			this.labelButtonLogin.Text = "  Войти  ";
			// 
			// loginPanel2
			// 
			this.loginPanel2.BackColor = System.Drawing.Color.Transparent;
			this.loginPanel2.Controls.Add(this.textBoxPassword);
			this.loginPanel2.Location = new System.Drawing.Point(41, 140);
			this.loginPanel2.Name = "loginPanel2";
			this.loginPanel2.Size = new System.Drawing.Size(317, 44);
			this.loginPanel2.TabIndex = 3;
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
			this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxPassword.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxPassword.ForeColor = System.Drawing.Color.DimGray;
			this.textBoxPassword.Location = new System.Drawing.Point(16, 3);
			this.textBoxPassword.MaxLength = 20;
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.Size = new System.Drawing.Size(284, 36);
			this.textBoxPassword.TabIndex = 1;
			this.textBoxPassword.Text = "Пароль";
			// 
			// loginPanel1
			// 
			this.loginPanel1.BackColor = System.Drawing.Color.Transparent;
			this.loginPanel1.Controls.Add(this.textBoxLogin);
			this.loginPanel1.Location = new System.Drawing.Point(41, 77);
			this.loginPanel1.Name = "loginPanel1";
			this.loginPanel1.Size = new System.Drawing.Size(317, 44);
			this.loginPanel1.TabIndex = 2;
			// 
			// textBoxLogin
			// 
			this.textBoxLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
			this.textBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxLogin.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxLogin.ForeColor = System.Drawing.Color.DimGray;
			this.textBoxLogin.Location = new System.Drawing.Point(16, 3);
			this.textBoxLogin.MaxLength = 20;
			this.textBoxLogin.Name = "textBoxLogin";
			this.textBoxLogin.Size = new System.Drawing.Size(284, 36);
			this.textBoxLogin.TabIndex = 0;
			this.textBoxLogin.Text = "Логин";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(203)))), ((int)(((byte)(208)))));
			this.label1.Location = new System.Drawing.Point(94, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(215, 34);
			this.label1.TabIndex = 0;
			this.label1.Text = "АВТОРИЗАЦИЯ";
			// 
			// FormAuthorization
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Pharmacy.Properties.Resources.background;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1082, 693);
			this.Controls.Add(this.authorizationPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FormAuthorization";
			this.Text = "FormAuthorization";
			this.Load += new System.EventHandler(this.FormAuthorization_Load);
			this.authorizationPanel1.ResumeLayout(false);
			this.authorizationPanel1.PerformLayout();
			this.loginButton.ResumeLayout(false);
			this.loginButton.PerformLayout();
			this.loginPanel2.ResumeLayout(false);
			this.loginPanel2.PerformLayout();
			this.loginPanel1.ResumeLayout(false);
			this.loginPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private Elements.AuthorizationPanel authorizationPanel1;
		private System.Windows.Forms.Label label1;
		private Elements.LoginPanel loginPanel1;
		private Elements.LoginPanel loginPanel2;
		private System.Windows.Forms.TextBox textBoxLogin;
		private System.Windows.Forms.TextBox textBoxPassword;
		private Elements.LoginPanel loginButton;
		private System.Windows.Forms.Label labelButtonLogin;
	}
}