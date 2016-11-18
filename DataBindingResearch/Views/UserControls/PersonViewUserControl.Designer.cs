namespace DataBindingResearch.Views
{
	partial class PersonViewUserControl
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
			DataBindingResearch.Models.Detail detail5 = new DataBindingResearch.Models.Detail();
			DataBindingResearch.Models.Detail detail6 = new DataBindingResearch.Models.Detail();
			DataBindingResearch.Models.Person person2 = new DataBindingResearch.Models.Person();
			DataBindingResearch.Models.Detail detail7 = new DataBindingResearch.Models.Detail();
			DataBindingResearch.Models.Detail detail8 = new DataBindingResearch.Models.Detail();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.isMarriedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.displayNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mainDetailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.partnerDetailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.personViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.personUserControl1 = new DataBindingResearch.Views.PersonUserControl();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.personViewModelBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.isMarriedDataGridViewCheckBoxColumn,
            this.displayNameDataGridViewTextBoxColumn,
            this.mainDetailDataGridViewTextBoxColumn,
            this.partnerDetailDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.personViewModelBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(4, 280);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(605, 198);
			this.dataGridView1.TabIndex = 1;
			// 
			// iDDataGridViewTextBoxColumn
			// 
			this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
			this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
			this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
			// 
			// isMarriedDataGridViewCheckBoxColumn
			// 
			this.isMarriedDataGridViewCheckBoxColumn.DataPropertyName = "IsMarried";
			this.isMarriedDataGridViewCheckBoxColumn.HeaderText = "IsMarried";
			this.isMarriedDataGridViewCheckBoxColumn.Name = "isMarriedDataGridViewCheckBoxColumn";
			// 
			// displayNameDataGridViewTextBoxColumn
			// 
			this.displayNameDataGridViewTextBoxColumn.DataPropertyName = "DisplayName";
			this.displayNameDataGridViewTextBoxColumn.HeaderText = "DisplayName";
			this.displayNameDataGridViewTextBoxColumn.Name = "displayNameDataGridViewTextBoxColumn";
			// 
			// mainDetailDataGridViewTextBoxColumn
			// 
			this.mainDetailDataGridViewTextBoxColumn.DataPropertyName = "MainDetail";
			this.mainDetailDataGridViewTextBoxColumn.HeaderText = "MainDetail";
			this.mainDetailDataGridViewTextBoxColumn.Name = "mainDetailDataGridViewTextBoxColumn";
			// 
			// partnerDetailDataGridViewTextBoxColumn
			// 
			this.partnerDetailDataGridViewTextBoxColumn.DataPropertyName = "PartnerDetail";
			this.partnerDetailDataGridViewTextBoxColumn.HeaderText = "PartnerDetail";
			this.partnerDetailDataGridViewTextBoxColumn.Name = "partnerDetailDataGridViewTextBoxColumn";
			// 
			// personViewModelBindingSource
			// 
			this.personViewModelBindingSource.DataSource = typeof(DataBindingResearch.ViewModels.PersonViewModel);
			// 
			// personUserControl1
			// 
			this.personUserControl1.DisplayName = "";
			this.personUserControl1.Location = new System.Drawing.Point(4, 4);
			detail5.Address = "";
			detail5.DateOfBirth = new System.DateTime(2016, 11, 18, 3, 3, 13, 795);
			detail5.FirstName = "";
			detail5.LastName = "";
			this.personUserControl1.MainDetail = detail5;
			this.personUserControl1.Name = "personUserControl1";
			detail6.Address = "";
			detail6.DateOfBirth = new System.DateTime(2016, 11, 18, 3, 3, 13, 795);
			detail6.FirstName = "";
			detail6.LastName = "";
			this.personUserControl1.PartnerDetail = detail6;
			person2.DisplayName = "";
			person2.ID = 0;
			person2.IsMarried = false;
			detail7.Address = "";
			detail7.DateOfBirth = new System.DateTime(2016, 11, 18, 3, 3, 13, 795);
			detail7.FirstName = "";
			detail7.LastName = "";
			person2.MainDetail = detail7;
			detail8.Address = "";
			detail8.DateOfBirth = new System.DateTime(2016, 11, 18, 3, 3, 13, 795);
			detail8.FirstName = "";
			detail8.LastName = "";
			person2.PartnerDetail = detail8;
			this.personUserControl1.Person = person2;
			this.personUserControl1.Size = new System.Drawing.Size(348, 270);
			this.personUserControl1.TabIndex = 0;
			// 
			// PersonViewUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.personUserControl1);
			this.Name = "PersonViewUserControl";
			this.Size = new System.Drawing.Size(621, 481);
			this.Load += new System.EventHandler(this.PersonViewUserControl_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.personViewModelBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private PersonUserControl personUserControl1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn isMarriedDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn displayNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn mainDetailDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn partnerDetailDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource personViewModelBindingSource;
	}
}
