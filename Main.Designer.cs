namespace part_10._5
{
	partial class Main
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
			this.lstNames = new System.Windows.Forms.ListBox();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.btnOpenSV = new System.Windows.Forms.Button();
			this.borderForLst = new System.Windows.Forms.Panel();
			this.lblStaticCurrentSelection = new System.Windows.Forms.Label();
			this.lblCurrentSelection = new System.Windows.Forms.Label();
			this.borderForLst.SuspendLayout();
			this.SuspendLayout();
			// 
			// lstNames
			// 
			this.lstNames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.lstNames.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lstNames.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.lstNames.FormattingEnabled = true;
			this.lstNames.Location = new System.Drawing.Point(2, 2);
			this.lstNames.Name = "lstNames";
			this.lstNames.Size = new System.Drawing.Size(163, 143);
			this.lstNames.TabIndex = 0;
			this.lstNames.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstNames_DrawItem);
			this.lstNames.SelectedIndexChanged += new System.EventHandler(this.lstNames_SelectedIndexChanged);
			// 
			// txtSearch
			// 
			this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSearch.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.txtSearch.Location = new System.Drawing.Point(13, 10);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(167, 21);
			this.txtSearch.TabIndex = 2;
			this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// btnOpenSV
			// 
			this.btnOpenSV.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnOpenSV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.btnOpenSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOpenSV.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOpenSV.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnOpenSV.Image = global::part_10._5.Properties.Resources.chrome_eQbkOh3eCb;
			this.btnOpenSV.Location = new System.Drawing.Point(13, 184);
			this.btnOpenSV.Name = "btnOpenSV";
			this.btnOpenSV.Size = new System.Drawing.Size(167, 26);
			this.btnOpenSV.TabIndex = 9;
			this.btnOpenSV.Text = "Open student viewer";
			this.btnOpenSV.UseVisualStyleBackColor = true;
			this.btnOpenSV.Click += new System.EventHandler(this.btnOpenSV_Click);
			this.btnOpenSV.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_Quit_Paint);
			this.btnOpenSV.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnOpenSV_MouseDown);
			this.btnOpenSV.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnOpenSV_MouseUp);
			// 
			// borderForLst
			// 
			this.borderForLst.Controls.Add(this.lstNames);
			this.borderForLst.Location = new System.Drawing.Point(13, 34);
			this.borderForLst.Name = "borderForLst";
			this.borderForLst.Size = new System.Drawing.Size(167, 147);
			this.borderForLst.TabIndex = 10;
			this.borderForLst.Paint += new System.Windows.Forms.PaintEventHandler(this.borderForLst_Paint);
			// 
			// lblStaticCurrentSelection
			// 
			this.lblStaticCurrentSelection.AutoSize = true;
			this.lblStaticCurrentSelection.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStaticCurrentSelection.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblStaticCurrentSelection.Location = new System.Drawing.Point(183, 11);
			this.lblStaticCurrentSelection.Name = "lblStaticCurrentSelection";
			this.lblStaticCurrentSelection.Size = new System.Drawing.Size(128, 13);
			this.lblStaticCurrentSelection.TabIndex = 11;
			this.lblStaticCurrentSelection.Text = "Current Selection: ";
			// 
			// lblCurrentSelection
			// 
			this.lblCurrentSelection.AutoSize = true;
			this.lblCurrentSelection.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCurrentSelection.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblCurrentSelection.Location = new System.Drawing.Point(183, 26);
			this.lblCurrentSelection.Name = "lblCurrentSelection";
			this.lblCurrentSelection.Size = new System.Drawing.Size(0, 13);
			this.lblCurrentSelection.TabIndex = 12;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.ClientSize = new System.Drawing.Size(422, 219);
			this.Controls.Add(this.lblCurrentSelection);
			this.Controls.Add(this.lblStaticCurrentSelection);
			this.Controls.Add(this.borderForLst);
			this.Controls.Add(this.btnOpenSV);
			this.Controls.Add(this.txtSearch);
			this.Name = "Main";
			this.Text = "Part 10.5: Class List";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.borderForLst.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lstNames;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Button btnOpenSV;
		private System.Windows.Forms.Panel borderForLst;
		private System.Windows.Forms.Label lblStaticCurrentSelection;
		private System.Windows.Forms.Label lblCurrentSelection;
	}
}

