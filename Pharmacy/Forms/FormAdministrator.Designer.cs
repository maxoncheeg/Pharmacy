namespace Pharmacy.Forms
{
	partial class FormAdministrator
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
			this.pictureBoxExit = new System.Windows.Forms.PictureBox();
			this.pictureBoxAccount = new System.Windows.Forms.PictureBox();
			this.pictureBoxFAQ = new System.Windows.Forms.PictureBox();
			this.labelPharmacist = new System.Windows.Forms.Label();
			this.labelClient = new System.Windows.Forms.Label();
			this.labelMedication = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panelWindow = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxFAQ)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxExit
			// 
			this.pictureBoxExit.Image = global::Pharmacy.Properties.Resources.exit;
			this.pictureBoxExit.Location = new System.Drawing.Point(1012, 36);
			this.pictureBoxExit.Name = "pictureBoxExit";
			this.pictureBoxExit.Size = new System.Drawing.Size(59, 54);
			this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxExit.TabIndex = 15;
			this.pictureBoxExit.TabStop = false;
			this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
			// 
			// pictureBoxAccount
			// 
			this.pictureBoxAccount.Image = global::Pharmacy.Properties.Resources.acc;
			this.pictureBoxAccount.Location = new System.Drawing.Point(929, 26);
			this.pictureBoxAccount.Name = "pictureBoxAccount";
			this.pictureBoxAccount.Size = new System.Drawing.Size(77, 73);
			this.pictureBoxAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxAccount.TabIndex = 14;
			this.pictureBoxAccount.TabStop = false;
			this.pictureBoxAccount.Click += new System.EventHandler(this.pictureBoxAccount_Click);
			// 
			// pictureBoxFAQ
			// 
			this.pictureBoxFAQ.Image = global::Pharmacy.Properties.Resources.faq;
			this.pictureBoxFAQ.Location = new System.Drawing.Point(868, 36);
			this.pictureBoxFAQ.Name = "pictureBoxFAQ";
			this.pictureBoxFAQ.Size = new System.Drawing.Size(55, 54);
			this.pictureBoxFAQ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxFAQ.TabIndex = 13;
			this.pictureBoxFAQ.TabStop = false;
			// 
			// labelPharmacist
			// 
			this.labelPharmacist.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelPharmacist.Location = new System.Drawing.Point(609, -1);
			this.labelPharmacist.Name = "labelPharmacist";
			this.labelPharmacist.Size = new System.Drawing.Size(253, 125);
			this.labelPharmacist.TabIndex = 12;
			this.labelPharmacist.Text = "ФАРМАЦЕВТЫ";
			this.labelPharmacist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPharmacist.Click += new System.EventHandler(this.labelPharmacist_Click);
			// 
			// labelClient
			// 
			this.labelClient.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelClient.Location = new System.Drawing.Point(384, -1);
			this.labelClient.Name = "labelClient";
			this.labelClient.Size = new System.Drawing.Size(219, 125);
			this.labelClient.TabIndex = 11;
			this.labelClient.Text = "КЛИЕНТЫ";
			this.labelClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelClient.Click += new System.EventHandler(this.labelClient_Click);
			// 
			// labelMedication
			// 
			this.labelMedication.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelMedication.Location = new System.Drawing.Point(136, -1);
			this.labelMedication.Name = "labelMedication";
			this.labelMedication.Size = new System.Drawing.Size(242, 125);
			this.labelMedication.TabIndex = 10;
			this.labelMedication.Text = "ПРЕПАРАТЫ";
			this.labelMedication.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelMedication.Click += new System.EventHandler(this.labelMedication_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBox1.Image = global::Pharmacy.Properties.Resources.logo;
			this.pictureBox1.InitialImage = global::Pharmacy.Properties.Resources.логотип;
			this.pictureBox1.Location = new System.Drawing.Point(13, -1);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(127, 122);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			// 
			// panelWindow
			// 
			this.panelWindow.Location = new System.Drawing.Point(-1, 127);
			this.panelWindow.Name = "panelWindow";
			this.panelWindow.Size = new System.Drawing.Size(1084, 567);
			this.panelWindow.TabIndex = 8;
			// 
			// FormAdministrator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
			this.ClientSize = new System.Drawing.Size(1082, 693);
			this.Controls.Add(this.pictureBoxExit);
			this.Controls.Add(this.pictureBoxAccount);
			this.Controls.Add(this.pictureBoxFAQ);
			this.Controls.Add(this.labelPharmacist);
			this.Controls.Add(this.labelClient);
			this.Controls.Add(this.labelMedication);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panelWindow);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FormAdministrator";
			this.Text = "FormAdministrator";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxFAQ)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxExit;
		private System.Windows.Forms.PictureBox pictureBoxAccount;
		private System.Windows.Forms.PictureBox pictureBoxFAQ;
		private System.Windows.Forms.Label labelPharmacist;
		private System.Windows.Forms.Label labelClient;
		private System.Windows.Forms.Label labelMedication;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panelWindow;
	}
}