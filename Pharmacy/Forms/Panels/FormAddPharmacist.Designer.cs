namespace Pharmacy.Forms.Panels
{
	partial class FormAddPharmacist
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
			this.addPanelCancel = new Pharmacy.Forms.Elements.AddPanel();
			this.labelCancel = new System.Windows.Forms.Label();
			this.addPanel4 = new Pharmacy.Forms.Elements.AddPanel();
			this.labelOk = new System.Windows.Forms.Label();
			this.addPanel2 = new Pharmacy.Forms.Elements.AddPanel();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.addPanel1 = new Pharmacy.Forms.Elements.AddPanel();
			this.textBoxSurname = new System.Windows.Forms.TextBox();
			this.addPanel5 = new Pharmacy.Forms.Elements.AddPanel();
			this.textBoxLogin = new System.Windows.Forms.TextBox();
			this.addPanel6 = new Pharmacy.Forms.Elements.AddPanel();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.itemPanel1.SuspendLayout();
			this.addPanelCancel.SuspendLayout();
			this.addPanel4.SuspendLayout();
			this.addPanel2.SuspendLayout();
			this.addPanel1.SuspendLayout();
			this.addPanel5.SuspendLayout();
			this.addPanel6.SuspendLayout();
			this.SuspendLayout();
			// 
			// itemPanel1
			// 
			this.itemPanel1.ActionBox = null;
			this.itemPanel1.BackColor = System.Drawing.Color.Transparent;
			this.itemPanel1.Controls.Add(this.addPanel6);
			this.itemPanel1.Controls.Add(this.addPanel5);
			this.itemPanel1.Controls.Add(this.addPanelCancel);
			this.itemPanel1.Controls.Add(this.addPanel4);
			this.itemPanel1.Controls.Add(this.addPanel2);
			this.itemPanel1.Controls.Add(this.addPanel1);
			this.itemPanel1.DeleteBox = null;
			this.itemPanel1.FirstLabel = null;
			this.itemPanel1.Location = new System.Drawing.Point(132, 58);
			this.itemPanel1.Name = "itemPanel1";
			this.itemPanel1.SecondLabel = null;
			this.itemPanel1.Size = new System.Drawing.Size(537, 473);
			this.itemPanel1.TabIndex = 1;
			this.itemPanel1.ThirdLabel = null;
			// 
			// addPanelCancel
			// 
			this.addPanelCancel.BackColor = System.Drawing.Color.Transparent;
			this.addPanelCancel.Controls.Add(this.labelCancel);
			this.addPanelCancel.Location = new System.Drawing.Point(250, 370);
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
			this.addPanel4.Location = new System.Drawing.Point(39, 370);
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
			// addPanel2
			// 
			this.addPanel2.BackColor = System.Drawing.Color.Transparent;
			this.addPanel2.Controls.Add(this.textBoxName);
			this.addPanel2.Location = new System.Drawing.Point(39, 123);
			this.addPanel2.Name = "addPanel2";
			this.addPanel2.Size = new System.Drawing.Size(471, 54);
			this.addPanel2.TabIndex = 2;
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
			this.textBoxName.Text = "Имя";
			// 
			// addPanel1
			// 
			this.addPanel1.BackColor = System.Drawing.Color.Transparent;
			this.addPanel1.Controls.Add(this.textBoxSurname);
			this.addPanel1.Location = new System.Drawing.Point(39, 53);
			this.addPanel1.Name = "addPanel1";
			this.addPanel1.Size = new System.Drawing.Size(471, 54);
			this.addPanel1.TabIndex = 0;
			// 
			// textBoxSurname
			// 
			this.textBoxSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
			this.textBoxSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxSurname.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.textBoxSurname.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.textBoxSurname.Location = new System.Drawing.Point(25, 3);
			this.textBoxSurname.MaxLength = 20;
			this.textBoxSurname.Name = "textBoxSurname";
			this.textBoxSurname.Size = new System.Drawing.Size(422, 45);
			this.textBoxSurname.TabIndex = 1;
			this.textBoxSurname.Text = "Фамилия";
			// 
			// addPanel5
			// 
			this.addPanel5.BackColor = System.Drawing.Color.Transparent;
			this.addPanel5.Controls.Add(this.textBoxLogin);
			this.addPanel5.Location = new System.Drawing.Point(39, 196);
			this.addPanel5.Name = "addPanel5";
			this.addPanel5.Size = new System.Drawing.Size(471, 54);
			this.addPanel5.TabIndex = 3;
			// 
			// textBoxLogin
			// 
			this.textBoxLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
			this.textBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.textBoxLogin.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.textBoxLogin.Location = new System.Drawing.Point(25, 3);
			this.textBoxLogin.MaxLength = 20;
			this.textBoxLogin.Name = "textBoxLogin";
			this.textBoxLogin.Size = new System.Drawing.Size(422, 45);
			this.textBoxLogin.TabIndex = 1;
			this.textBoxLogin.Text = "Логин";
			// 
			// addPanel6
			// 
			this.addPanel6.BackColor = System.Drawing.Color.Transparent;
			this.addPanel6.Controls.Add(this.textBoxPassword);
			this.addPanel6.Location = new System.Drawing.Point(39, 268);
			this.addPanel6.Name = "addPanel6";
			this.addPanel6.Size = new System.Drawing.Size(471, 54);
			this.addPanel6.TabIndex = 4;
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
			this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.textBoxPassword.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.textBoxPassword.Location = new System.Drawing.Point(25, 3);
			this.textBoxPassword.MaxLength = 20;
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.Size = new System.Drawing.Size(422, 45);
			this.textBoxPassword.TabIndex = 1;
			this.textBoxPassword.Text = "Пароль";
			// 
			// FormAddPharmacist
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Pharmacy.Properties.Resources.background2;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(800, 590);
			this.Controls.Add(this.itemPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FormAddPharmacist";
			this.Text = "FormAddPharmacist";
			this.itemPanel1.ResumeLayout(false);
			this.addPanelCancel.ResumeLayout(false);
			this.addPanel4.ResumeLayout(false);
			this.addPanel2.ResumeLayout(false);
			this.addPanel2.PerformLayout();
			this.addPanel1.ResumeLayout(false);
			this.addPanel1.PerformLayout();
			this.addPanel5.ResumeLayout(false);
			this.addPanel5.PerformLayout();
			this.addPanel6.ResumeLayout(false);
			this.addPanel6.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Elements.ItemPanel itemPanel1;
		private Elements.AddPanel addPanel6;
		private System.Windows.Forms.TextBox textBoxPassword;
		private Elements.AddPanel addPanel5;
		private System.Windows.Forms.TextBox textBoxLogin;
		private Elements.AddPanel addPanelCancel;
		private System.Windows.Forms.Label labelCancel;
		private Elements.AddPanel addPanel4;
		private System.Windows.Forms.Label labelOk;
		private Elements.AddPanel addPanel2;
		private System.Windows.Forms.TextBox textBoxName;
		private Elements.AddPanel addPanel1;
		private System.Windows.Forms.TextBox textBoxSurname;
	}
}