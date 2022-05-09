namespace Evaluation_Manager
{
	partial class FrmEvaluation
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
			this.cboActivities = new System.Windows.Forms.ComboBox();
			this.lbAktivnost = new System.Windows.Forms.Label();
			this.lbUvjet = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtMinForSignature = new System.Windows.Forms.TextBox();
			this.txtMinForGrade = new System.Windows.Forms.TextBox();
			this.txtTeacher = new System.Windows.Forms.TextBox();
			this.txtEvaluationDate = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.numPoints = new System.Windows.Forms.NumericUpDown();
			this.txtActivityDescription = new System.Windows.Forms.TextBox();
			this.Bpdp = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numPoints)).BeginInit();
			this.SuspendLayout();
			// 
			// cboActivities
			// 
			this.cboActivities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboActivities.FormattingEnabled = true;
			this.cboActivities.Location = new System.Drawing.Point(13, 38);
			this.cboActivities.Name = "cboActivities";
			this.cboActivities.Size = new System.Drawing.Size(121, 21);
			this.cboActivities.TabIndex = 0;
			this.cboActivities.SelectedIndexChanged += new System.EventHandler(this.cboActivities_SelectedIndexChanged);
			// 
			// lbAktivnost
			// 
			this.lbAktivnost.AutoSize = true;
			this.lbAktivnost.Location = new System.Drawing.Point(13, 19);
			this.lbAktivnost.Name = "lbAktivnost";
			this.lbAktivnost.Size = new System.Drawing.Size(54, 13);
			this.lbAktivnost.TabIndex = 1;
			this.lbAktivnost.Text = "Aktivnost:";
			// 
			// lbUvjet
			// 
			this.lbUvjet.AutoSize = true;
			this.lbUvjet.Location = new System.Drawing.Point(319, 18);
			this.lbUvjet.Name = "lbUvjet";
			this.lbUvjet.Size = new System.Drawing.Size(82, 13);
			this.lbUvjet.TabIndex = 2;
			this.lbUvjet.Text = "Uvijet za potpis:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(449, 18);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(84, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Uvjet za ocjenu:";
			// 
			// txtMinForSignature
			// 
			this.txtMinForSignature.Location = new System.Drawing.Point(322, 38);
			this.txtMinForSignature.Name = "txtMinForSignature";
			this.txtMinForSignature.ReadOnly = true;
			this.txtMinForSignature.Size = new System.Drawing.Size(100, 20);
			this.txtMinForSignature.TabIndex = 4;
			// 
			// txtMinForGrade
			// 
			this.txtMinForGrade.Location = new System.Drawing.Point(452, 38);
			this.txtMinForGrade.Name = "txtMinForGrade";
			this.txtMinForGrade.ReadOnly = true;
			this.txtMinForGrade.Size = new System.Drawing.Size(100, 20);
			this.txtMinForGrade.TabIndex = 5;
			// 
			// txtTeacher
			// 
			this.txtTeacher.Location = new System.Drawing.Point(265, 313);
			this.txtTeacher.Name = "txtTeacher";
			this.txtTeacher.ReadOnly = true;
			this.txtTeacher.Size = new System.Drawing.Size(100, 20);
			this.txtTeacher.TabIndex = 6;
			// 
			// txtEvaluationDate
			// 
			this.txtEvaluationDate.Location = new System.Drawing.Point(371, 313);
			this.txtEvaluationDate.Name = "txtEvaluationDate";
			this.txtEvaluationDate.ReadOnly = true;
			this.txtEvaluationDate.Size = new System.Drawing.Size(100, 20);
			this.txtEvaluationDate.TabIndex = 7;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(396, 348);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 8;
			this.btnSave.Text = "Spremi";
			this.btnSave.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(477, 348);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 9;
			this.btnCancel.Text = "Odustani";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(265, 294);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "Ocjenjivač:";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(368, 294);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(92, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "Datum evaluacije:";
			// 
			// numPoints
			// 
			this.numPoints.Location = new System.Drawing.Point(477, 313);
			this.numPoints.Name = "numPoints";
			this.numPoints.Size = new System.Drawing.Size(75, 20);
			this.numPoints.TabIndex = 12;
			this.numPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtActivityDescription
			// 
			this.txtActivityDescription.Location = new System.Drawing.Point(13, 90);
			this.txtActivityDescription.Multiline = true;
			this.txtActivityDescription.Name = "txtActivityDescription";
			this.txtActivityDescription.Size = new System.Drawing.Size(539, 190);
			this.txtActivityDescription.TabIndex = 13;
			// 
			// Bpdp
			// 
			this.Bpdp.AutoSize = true;
			this.Bpdp.Location = new System.Drawing.Point(477, 294);
			this.Bpdp.Name = "Bpdp";
			this.Bpdp.Size = new System.Drawing.Size(43, 13);
			this.Bpdp.TabIndex = 14;
			this.Bpdp.Text = "Bodovi:";
			// 
			// FrmEvaluation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(569, 398);
			this.Controls.Add(this.Bpdp);
			this.Controls.Add(this.txtActivityDescription);
			this.Controls.Add(this.numPoints);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtEvaluationDate);
			this.Controls.Add(this.txtTeacher);
			this.Controls.Add(this.txtMinForGrade);
			this.Controls.Add(this.txtMinForSignature);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lbUvjet);
			this.Controls.Add(this.lbAktivnost);
			this.Controls.Add(this.cboActivities);
			this.Name = "FrmEvaluation";
			this.Text = "FrmEvaluation";
			this.Load += new System.EventHandler(this.FrmEvaluation_Load);
			((System.ComponentModel.ISupportInitialize)(this.numPoints)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cboActivities;
		private System.Windows.Forms.Label lbAktivnost;
		private System.Windows.Forms.Label lbUvjet;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtMinForSignature;
		private System.Windows.Forms.TextBox txtMinForGrade;
		private System.Windows.Forms.TextBox txtTeacher;
		private System.Windows.Forms.TextBox txtEvaluationDate;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown numPoints;
		private System.Windows.Forms.TextBox txtActivityDescription;
		private System.Windows.Forms.Label Bpdp;
	}
}