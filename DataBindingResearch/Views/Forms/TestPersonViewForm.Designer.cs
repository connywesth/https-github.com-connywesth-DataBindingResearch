﻿namespace DataBindingResearch.Views
{
	partial class TestPersonViewForm
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
			if(disposing && (components != null))
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
			this.personViewUserControl1 = new DataBindingResearch.Views.PersonViewUserControl();
			this.SuspendLayout();
			// 
			// personViewUserControl1
			// 
			this.personViewUserControl1.Location = new System.Drawing.Point(12, 12);
			this.personViewUserControl1.Name = "personViewUserControl1";
			this.personViewUserControl1.Size = new System.Drawing.Size(621, 481);
			this.personViewUserControl1.TabIndex = 0;
			// 
			// TestPersonViewForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(643, 504);
			this.Controls.Add(this.personViewUserControl1);
			this.Name = "TestPersonViewForm";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private PersonViewUserControl personViewUserControl1;
	}
}

