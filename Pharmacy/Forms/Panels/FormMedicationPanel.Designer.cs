namespace Pharmacy.Forms.Panels
{
	partial class FormMedicationPanel
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMedicationPanel));
			this.actionPanelButton = new Pharmacy.Forms.Elements.ActionPanel();
			this.labelButtonAdd = new System.Windows.Forms.Label();
			this.actionPanel1 = new Pharmacy.Forms.Elements.ActionPanel();
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.itemPanel1 = new Pharmacy.Forms.Elements.ItemPanel();
			this.pictureBoxDelete1 = new System.Windows.Forms.PictureBox();
			this.pictureBoxAction1 = new System.Windows.Forms.PictureBox();
			this.labelPrice1 = new System.Windows.Forms.Label();
			this.labelAmount1 = new System.Windows.Forms.Label();
			this.labelName1 = new System.Windows.Forms.Label();
			this.itemPanel2 = new Pharmacy.Forms.Elements.ItemPanel();
			this.pictureBoxDelete2 = new System.Windows.Forms.PictureBox();
			this.pictureBoxAction2 = new System.Windows.Forms.PictureBox();
			this.labelPrice2 = new System.Windows.Forms.Label();
			this.labelAmount2 = new System.Windows.Forms.Label();
			this.labelName2 = new System.Windows.Forms.Label();
			this.itemPanel3 = new Pharmacy.Forms.Elements.ItemPanel();
			this.pictureBoxDelete3 = new System.Windows.Forms.PictureBox();
			this.pictureBoxAction3 = new System.Windows.Forms.PictureBox();
			this.labelPrice3 = new System.Windows.Forms.Label();
			this.labelAmount3 = new System.Windows.Forms.Label();
			this.labelName3 = new System.Windows.Forms.Label();
			this.itemPanel4 = new Pharmacy.Forms.Elements.ItemPanel();
			this.pictureBoxDelete4 = new System.Windows.Forms.PictureBox();
			this.pictureBoxAction4 = new System.Windows.Forms.PictureBox();
			this.labelPrice4 = new System.Windows.Forms.Label();
			this.labelAmount4 = new System.Windows.Forms.Label();
			this.labelName4 = new System.Windows.Forms.Label();
			this.vScrollBar = new System.Windows.Forms.VScrollBar();
			this.actionPanelButton.SuspendLayout();
			this.actionPanel1.SuspendLayout();
			this.itemPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAction1)).BeginInit();
			this.itemPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAction2)).BeginInit();
			this.itemPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAction3)).BeginInit();
			this.itemPanel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAction4)).BeginInit();
			this.SuspendLayout();
			// 
			// actionPanelButton
			// 
			this.actionPanelButton.BackColor = System.Drawing.Color.Transparent;
			this.actionPanelButton.Controls.Add(this.labelButtonAdd);
			this.actionPanelButton.Location = new System.Drawing.Point(551, 42);
			this.actionPanelButton.Name = "actionPanelButton";
			this.actionPanelButton.Size = new System.Drawing.Size(442, 57);
			this.actionPanelButton.TabIndex = 2;
			// 
			// labelButtonAdd
			// 
			this.labelButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelButtonAdd.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelButtonAdd.Location = new System.Drawing.Point(3, 3);
			this.labelButtonAdd.Name = "labelButtonAdd";
			this.labelButtonAdd.Size = new System.Drawing.Size(439, 54);
			this.labelButtonAdd.TabIndex = 0;
			this.labelButtonAdd.Text = "  Добавить";
			this.labelButtonAdd.Click += new System.EventHandler(this.labelButtonAdd_Click);
			// 
			// actionPanel1
			// 
			this.actionPanel1.BackColor = System.Drawing.Color.Transparent;
			this.actionPanel1.Controls.Add(this.textBoxSearch);
			this.actionPanel1.Location = new System.Drawing.Point(51, 42);
			this.actionPanel1.Name = "actionPanel1";
			this.actionPanel1.Size = new System.Drawing.Size(442, 57);
			this.actionPanel1.TabIndex = 1;
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
			this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.textBoxSearch.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.textBoxSearch.Location = new System.Drawing.Point(26, 3);
			this.textBoxSearch.MaxLength = 50;
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(393, 45);
			this.textBoxSearch.TabIndex = 0;
			this.textBoxSearch.Text = "Поиск";
			// 
			// itemPanel1
			// 
			this.itemPanel1.ActionBox = null;
			this.itemPanel1.BackColor = System.Drawing.Color.Transparent;
			this.itemPanel1.Controls.Add(this.pictureBoxDelete1);
			this.itemPanel1.Controls.Add(this.pictureBoxAction1);
			this.itemPanel1.Controls.Add(this.labelPrice1);
			this.itemPanel1.Controls.Add(this.labelAmount1);
			this.itemPanel1.Controls.Add(this.labelName1);
			this.itemPanel1.DeleteBox = null;
			this.itemPanel1.FirstLabel = null;
			this.itemPanel1.Location = new System.Drawing.Point(51, 146);
			this.itemPanel1.Name = "itemPanel1";
			this.itemPanel1.SecondLabel = null;
			this.itemPanel1.Size = new System.Drawing.Size(442, 158);
			this.itemPanel1.TabIndex = 0;
			this.itemPanel1.ThirdLabel = null;
			// 
			// pictureBoxDelete1
			// 
			this.pictureBoxDelete1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDelete1.Image")));
			this.pictureBoxDelete1.Location = new System.Drawing.Point(372, 91);
			this.pictureBoxDelete1.Name = "pictureBoxDelete1";
			this.pictureBoxDelete1.Size = new System.Drawing.Size(47, 47);
			this.pictureBoxDelete1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxDelete1.TabIndex = 7;
			this.pictureBoxDelete1.TabStop = false;
			// 
			// pictureBoxAction1
			// 
			this.pictureBoxAction1.Image = global::Pharmacy.Properties.Resources.add;
			this.pictureBoxAction1.Location = new System.Drawing.Point(372, 25);
			this.pictureBoxAction1.Name = "pictureBoxAction1";
			this.pictureBoxAction1.Size = new System.Drawing.Size(47, 47);
			this.pictureBoxAction1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxAction1.TabIndex = 6;
			this.pictureBoxAction1.TabStop = false;
			// 
			// labelPrice1
			// 
			this.labelPrice1.AutoSize = true;
			this.labelPrice1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPrice1.ForeColor = System.Drawing.Color.Black;
			this.labelPrice1.Location = new System.Drawing.Point(24, 109);
			this.labelPrice1.Name = "labelPrice1";
			this.labelPrice1.Size = new System.Drawing.Size(68, 23);
			this.labelPrice1.TabIndex = 5;
			this.labelPrice1.Text = "100 р.";
			// 
			// labelAmount1
			// 
			this.labelAmount1.AutoSize = true;
			this.labelAmount1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelAmount1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.labelAmount1.Location = new System.Drawing.Point(24, 62);
			this.labelAmount1.Name = "labelAmount1";
			this.labelAmount1.Size = new System.Drawing.Size(66, 23);
			this.labelAmount1.TabIndex = 4;
			this.labelAmount1.Text = "N шт.";
			// 
			// labelName1
			// 
			this.labelName1.AutoSize = true;
			this.labelName1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelName1.Location = new System.Drawing.Point(23, 25);
			this.labelName1.Name = "labelName1";
			this.labelName1.Size = new System.Drawing.Size(127, 28);
			this.labelName1.TabIndex = 3;
			this.labelName1.Text = "Название";
			// 
			// itemPanel2
			// 
			this.itemPanel2.ActionBox = null;
			this.itemPanel2.BackColor = System.Drawing.Color.Transparent;
			this.itemPanel2.Controls.Add(this.pictureBoxDelete2);
			this.itemPanel2.Controls.Add(this.pictureBoxAction2);
			this.itemPanel2.Controls.Add(this.labelPrice2);
			this.itemPanel2.Controls.Add(this.labelAmount2);
			this.itemPanel2.Controls.Add(this.labelName2);
			this.itemPanel2.DeleteBox = null;
			this.itemPanel2.FirstLabel = null;
			this.itemPanel2.Location = new System.Drawing.Point(551, 146);
			this.itemPanel2.Name = "itemPanel2";
			this.itemPanel2.SecondLabel = null;
			this.itemPanel2.Size = new System.Drawing.Size(442, 158);
			this.itemPanel2.TabIndex = 8;
			this.itemPanel2.ThirdLabel = null;
			// 
			// pictureBoxDelete2
			// 
			this.pictureBoxDelete2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDelete2.Image")));
			this.pictureBoxDelete2.Location = new System.Drawing.Point(374, 91);
			this.pictureBoxDelete2.Name = "pictureBoxDelete2";
			this.pictureBoxDelete2.Size = new System.Drawing.Size(47, 47);
			this.pictureBoxDelete2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxDelete2.TabIndex = 7;
			this.pictureBoxDelete2.TabStop = false;
			// 
			// pictureBoxAction2
			// 
			this.pictureBoxAction2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAction2.Image")));
			this.pictureBoxAction2.Location = new System.Drawing.Point(374, 25);
			this.pictureBoxAction2.Name = "pictureBoxAction2";
			this.pictureBoxAction2.Size = new System.Drawing.Size(47, 47);
			this.pictureBoxAction2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxAction2.TabIndex = 6;
			this.pictureBoxAction2.TabStop = false;
			// 
			// labelPrice2
			// 
			this.labelPrice2.AutoSize = true;
			this.labelPrice2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPrice2.ForeColor = System.Drawing.Color.Black;
			this.labelPrice2.Location = new System.Drawing.Point(24, 109);
			this.labelPrice2.Name = "labelPrice2";
			this.labelPrice2.Size = new System.Drawing.Size(68, 23);
			this.labelPrice2.TabIndex = 5;
			this.labelPrice2.Text = "100 р.";
			// 
			// labelAmount2
			// 
			this.labelAmount2.AutoSize = true;
			this.labelAmount2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelAmount2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.labelAmount2.Location = new System.Drawing.Point(24, 62);
			this.labelAmount2.Name = "labelAmount2";
			this.labelAmount2.Size = new System.Drawing.Size(66, 23);
			this.labelAmount2.TabIndex = 4;
			this.labelAmount2.Text = "N шт.";
			// 
			// labelName2
			// 
			this.labelName2.AutoSize = true;
			this.labelName2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelName2.Location = new System.Drawing.Point(23, 25);
			this.labelName2.Name = "labelName2";
			this.labelName2.Size = new System.Drawing.Size(127, 28);
			this.labelName2.TabIndex = 3;
			this.labelName2.Text = "Название";
			// 
			// itemPanel3
			// 
			this.itemPanel3.ActionBox = null;
			this.itemPanel3.BackColor = System.Drawing.Color.Transparent;
			this.itemPanel3.Controls.Add(this.pictureBoxDelete3);
			this.itemPanel3.Controls.Add(this.pictureBoxAction3);
			this.itemPanel3.Controls.Add(this.labelPrice3);
			this.itemPanel3.Controls.Add(this.labelAmount3);
			this.itemPanel3.Controls.Add(this.labelName3);
			this.itemPanel3.DeleteBox = null;
			this.itemPanel3.FirstLabel = null;
			this.itemPanel3.Location = new System.Drawing.Point(51, 339);
			this.itemPanel3.Name = "itemPanel3";
			this.itemPanel3.SecondLabel = null;
			this.itemPanel3.Size = new System.Drawing.Size(442, 158);
			this.itemPanel3.TabIndex = 9;
			this.itemPanel3.ThirdLabel = null;
			// 
			// pictureBoxDelete3
			// 
			this.pictureBoxDelete3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDelete3.Image")));
			this.pictureBoxDelete3.Location = new System.Drawing.Point(372, 91);
			this.pictureBoxDelete3.Name = "pictureBoxDelete3";
			this.pictureBoxDelete3.Size = new System.Drawing.Size(47, 47);
			this.pictureBoxDelete3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxDelete3.TabIndex = 7;
			this.pictureBoxDelete3.TabStop = false;
			// 
			// pictureBoxAction3
			// 
			this.pictureBoxAction3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAction3.Image")));
			this.pictureBoxAction3.Location = new System.Drawing.Point(372, 25);
			this.pictureBoxAction3.Name = "pictureBoxAction3";
			this.pictureBoxAction3.Size = new System.Drawing.Size(47, 47);
			this.pictureBoxAction3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxAction3.TabIndex = 6;
			this.pictureBoxAction3.TabStop = false;
			// 
			// labelPrice3
			// 
			this.labelPrice3.AutoSize = true;
			this.labelPrice3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPrice3.ForeColor = System.Drawing.Color.Black;
			this.labelPrice3.Location = new System.Drawing.Point(24, 109);
			this.labelPrice3.Name = "labelPrice3";
			this.labelPrice3.Size = new System.Drawing.Size(68, 23);
			this.labelPrice3.TabIndex = 5;
			this.labelPrice3.Text = "100 р.";
			// 
			// labelAmount3
			// 
			this.labelAmount3.AutoSize = true;
			this.labelAmount3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelAmount3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.labelAmount3.Location = new System.Drawing.Point(24, 62);
			this.labelAmount3.Name = "labelAmount3";
			this.labelAmount3.Size = new System.Drawing.Size(66, 23);
			this.labelAmount3.TabIndex = 4;
			this.labelAmount3.Text = "N шт.";
			// 
			// labelName3
			// 
			this.labelName3.AutoSize = true;
			this.labelName3.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelName3.Location = new System.Drawing.Point(23, 25);
			this.labelName3.Name = "labelName3";
			this.labelName3.Size = new System.Drawing.Size(127, 28);
			this.labelName3.TabIndex = 3;
			this.labelName3.Text = "Название";
			// 
			// itemPanel4
			// 
			this.itemPanel4.ActionBox = null;
			this.itemPanel4.BackColor = System.Drawing.Color.Transparent;
			this.itemPanel4.Controls.Add(this.pictureBoxDelete4);
			this.itemPanel4.Controls.Add(this.pictureBoxAction4);
			this.itemPanel4.Controls.Add(this.labelPrice4);
			this.itemPanel4.Controls.Add(this.labelAmount4);
			this.itemPanel4.Controls.Add(this.labelName4);
			this.itemPanel4.DeleteBox = null;
			this.itemPanel4.FirstLabel = null;
			this.itemPanel4.Location = new System.Drawing.Point(551, 339);
			this.itemPanel4.Name = "itemPanel4";
			this.itemPanel4.SecondLabel = null;
			this.itemPanel4.Size = new System.Drawing.Size(442, 158);
			this.itemPanel4.TabIndex = 10;
			this.itemPanel4.ThirdLabel = null;
			// 
			// pictureBoxDelete4
			// 
			this.pictureBoxDelete4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDelete4.Image")));
			this.pictureBoxDelete4.Location = new System.Drawing.Point(374, 91);
			this.pictureBoxDelete4.Name = "pictureBoxDelete4";
			this.pictureBoxDelete4.Size = new System.Drawing.Size(47, 47);
			this.pictureBoxDelete4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxDelete4.TabIndex = 7;
			this.pictureBoxDelete4.TabStop = false;
			// 
			// pictureBoxAction4
			// 
			this.pictureBoxAction4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAction4.Image")));
			this.pictureBoxAction4.Location = new System.Drawing.Point(374, 25);
			this.pictureBoxAction4.Name = "pictureBoxAction4";
			this.pictureBoxAction4.Size = new System.Drawing.Size(47, 47);
			this.pictureBoxAction4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxAction4.TabIndex = 6;
			this.pictureBoxAction4.TabStop = false;
			// 
			// labelPrice4
			// 
			this.labelPrice4.AutoSize = true;
			this.labelPrice4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPrice4.ForeColor = System.Drawing.Color.Black;
			this.labelPrice4.Location = new System.Drawing.Point(24, 109);
			this.labelPrice4.Name = "labelPrice4";
			this.labelPrice4.Size = new System.Drawing.Size(68, 23);
			this.labelPrice4.TabIndex = 5;
			this.labelPrice4.Text = "100 р.";
			// 
			// labelAmount4
			// 
			this.labelAmount4.AutoSize = true;
			this.labelAmount4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelAmount4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.labelAmount4.Location = new System.Drawing.Point(24, 62);
			this.labelAmount4.Name = "labelAmount4";
			this.labelAmount4.Size = new System.Drawing.Size(66, 23);
			this.labelAmount4.TabIndex = 4;
			this.labelAmount4.Text = "N шт.";
			// 
			// labelName4
			// 
			this.labelName4.AutoSize = true;
			this.labelName4.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelName4.Location = new System.Drawing.Point(23, 25);
			this.labelName4.Name = "labelName4";
			this.labelName4.Size = new System.Drawing.Size(127, 28);
			this.labelName4.TabIndex = 3;
			this.labelName4.Text = "Название";
			// 
			// vScrollBar
			// 
			this.vScrollBar.LargeChange = 1;
			this.vScrollBar.Location = new System.Drawing.Point(1022, 146);
			this.vScrollBar.Maximum = 10;
			this.vScrollBar.Name = "vScrollBar";
			this.vScrollBar.Size = new System.Drawing.Size(21, 351);
			this.vScrollBar.TabIndex = 15;
			this.vScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar_Scroll);
			// 
			// FormMedicationPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Pharmacy.Properties.Resources.background2;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(1071, 554);
			this.Controls.Add(this.vScrollBar);
			this.Controls.Add(this.itemPanel4);
			this.Controls.Add(this.itemPanel3);
			this.Controls.Add(this.itemPanel2);
			this.Controls.Add(this.actionPanelButton);
			this.Controls.Add(this.actionPanel1);
			this.Controls.Add(this.itemPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormMedicationPanel";
			this.Text = "FormMedicationPanel";
			this.actionPanelButton.ResumeLayout(false);
			this.actionPanel1.ResumeLayout(false);
			this.actionPanel1.PerformLayout();
			this.itemPanel1.ResumeLayout(false);
			this.itemPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAction1)).EndInit();
			this.itemPanel2.ResumeLayout(false);
			this.itemPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAction2)).EndInit();
			this.itemPanel3.ResumeLayout(false);
			this.itemPanel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAction3)).EndInit();
			this.itemPanel4.ResumeLayout(false);
			this.itemPanel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAction4)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Elements.ItemPanel itemPanel1;
		private Elements.ActionPanel actionPanel1;
		private Elements.ActionPanel actionPanelButton;
		private System.Windows.Forms.TextBox textBoxSearch;
		private System.Windows.Forms.Label labelButtonAdd;
		private System.Windows.Forms.PictureBox pictureBoxDelete1;
		private System.Windows.Forms.PictureBox pictureBoxAction1;
		private System.Windows.Forms.Label labelPrice1;
		private System.Windows.Forms.Label labelAmount1;
		private System.Windows.Forms.Label labelName1;
		private Elements.ItemPanel itemPanel2;
		private System.Windows.Forms.PictureBox pictureBoxDelete2;
		private System.Windows.Forms.PictureBox pictureBoxAction2;
		private System.Windows.Forms.Label labelPrice2;
		private System.Windows.Forms.Label labelAmount2;
		private System.Windows.Forms.Label labelName2;
		private Elements.ItemPanel itemPanel3;
		private System.Windows.Forms.PictureBox pictureBoxDelete3;
		private System.Windows.Forms.PictureBox pictureBoxAction3;
		private System.Windows.Forms.Label labelPrice3;
		private System.Windows.Forms.Label labelAmount3;
		private System.Windows.Forms.Label labelName3;
		private Elements.ItemPanel itemPanel4;
		private System.Windows.Forms.PictureBox pictureBoxDelete4;
		private System.Windows.Forms.PictureBox pictureBoxAction4;
		private System.Windows.Forms.Label labelPrice4;
		private System.Windows.Forms.Label labelAmount4;
		private System.Windows.Forms.Label labelName4;
		private System.Windows.Forms.VScrollBar vScrollBar;
	}
}