namespace DataBindingResearch.Views
{
	partial class PersonUserControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			DataBindingResearch.Models.Detail detail3 = new DataBindingResearch.Models.Detail();
			DataBindingResearch.Models.Detail detail1 = new DataBindingResearch.Models.Detail();
			this.titleTextBox = new System.Windows.Forms.TextBox();
			this.lblTitle = new System.Windows.Forms.Label();
			this.personDetailUserControl = new DataBindingResearch.Views.DetailUserControl();
			this.PartnerDetailUserControl = new DataBindingResearch.Views.DetailUserControl();
			this.lblPartner = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// titleTextBox
			// 
			this.titleTextBox.Location = new System.Drawing.Point(76, 3);
			this.titleTextBox.Name = "titleTextBox";
			this.titleTextBox.Size = new System.Drawing.Size(262, 20);
			this.titleTextBox.TabIndex = 2;
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Location = new System.Drawing.Point(-3, 6);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(27, 13);
			this.lblTitle.TabIndex = 4;
			this.lblTitle.Text = "Title";
			// 
			// personDetailUserControl
			// 
			this.personDetailUserControl.Address = "";
			this.personDetailUserControl.DateOfBirth = "den 18 november 2016";
			detail3.Address = "";
			detail3.DateOfBirth = new System.DateTime(2016, 11, 18, 3, 2, 32, 611);
			detail3.FirstName = "";
			detail3.LastName = "";
			this.personDetailUserControl.detail = detail3;
			this.personDetailUserControl.FirstName = "";
			this.personDetailUserControl.LastName = "";
			this.personDetailUserControl.Location = new System.Drawing.Point(0, 29);
			this.personDetailUserControl.Name = "personDetailUserControl";
			this.personDetailUserControl.Size = new System.Drawing.Size(343, 102);
			this.personDetailUserControl.TabIndex = 5;
			// 
			// PartnerDetailUserControl
			// 
			this.PartnerDetailUserControl.Address = "";
			this.PartnerDetailUserControl.DateOfBirth = "den 18 november 2016";
			detail1.Address = "";
			detail1.DateOfBirth = new System.DateTime(2016, 11, 18, 3, 2, 32, 617);
			detail1.FirstName = "";
			detail1.LastName = "";
			this.PartnerDetailUserControl.detail = detail1;
			this.PartnerDetailUserControl.FirstName = "";
			this.PartnerDetailUserControl.LastName = "";
			this.PartnerDetailUserControl.Location = new System.Drawing.Point(3, 163);
			this.PartnerDetailUserControl.Name = "PartnerDetailUserControl";
			this.PartnerDetailUserControl.Size = new System.Drawing.Size(343, 102);
			this.PartnerDetailUserControl.TabIndex = 8;
			// 
			// lblPartner
			// 
			this.lblPartner.AutoSize = true;
			this.lblPartner.Location = new System.Drawing.Point(0, 140);
			this.lblPartner.Name = "lblPartner";
			this.lblPartner.Size = new System.Drawing.Size(41, 13);
			this.lblPartner.TabIndex = 7;
			this.lblPartner.Text = "Partner";
			// 
			// PersonUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.PartnerDetailUserControl);
			this.Controls.Add(this.lblPartner);
			this.Controls.Add(this.personDetailUserControl);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.titleTextBox);
			this.Name = "PersonUserControl";
			this.Size = new System.Drawing.Size(350, 270);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox titleTextBox;
		private System.Windows.Forms.Label lblTitle;
		private DetailUserControl personDetailUserControl;
		private DetailUserControl PartnerDetailUserControl;
		private System.Windows.Forms.Label lblPartner;
	}
}
