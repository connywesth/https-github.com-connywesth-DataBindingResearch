namespace DataBindingResearch.Views
{
	partial class TestPersonUserControlForm
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
			this.components = new System.ComponentModel.Container();
			DataBindingResearch.Models.Detail detail1 = new DataBindingResearch.Models.Detail();
			DataBindingResearch.Models.Detail detail2 = new DataBindingResearch.Models.Detail();
			DataBindingResearch.Models.Person person1 = new DataBindingResearch.Models.Person();
			DataBindingResearch.Models.Detail detail3 = new DataBindingResearch.Models.Detail();
			DataBindingResearch.Models.Detail detail4 = new DataBindingResearch.Models.Detail();
			this.personUserControl1 = new DataBindingResearch.Views.PersonUserControl();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.isMarriedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.displayNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mainDetailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.partnerDetailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.personViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.personViewModelBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// personUserControl1
			// 
			this.personUserControl1.DisplayName = "";
			this.personUserControl1.Location = new System.Drawing.Point(13, 13);
			detail1.Address = "";
			detail1.DateOfBirth = new System.DateTime(2016, 11, 18, 3, 1, 27, 956);
			detail1.FirstName = "";
			detail1.LastName = "";
			this.personUserControl1.MainDetail = detail1;
			this.personUserControl1.Name = "personUserControl1";
			detail2.Address = "";
			detail2.DateOfBirth = new System.DateTime(2016, 11, 18, 3, 1, 27, 956);
			detail2.FirstName = "";
			detail2.LastName = "";
			this.personUserControl1.PartnerDetail = detail2;
			person1.DisplayName = "";
			person1.ID = 0;
			person1.IsMarried = false;
			detail3.Address = "";
			detail3.DateOfBirth = new System.DateTime(2016, 11, 18, 3, 1, 27, 956);
			detail3.FirstName = "";
			detail3.LastName = "";
			person1.MainDetail = detail3;
			detail4.Address = "";
			detail4.DateOfBirth = new System.DateTime(2016, 11, 18, 3, 1, 27, 956);
			detail4.FirstName = "";
			detail4.LastName = "";
			person1.PartnerDetail = detail4;
			this.personUserControl1.Person = person1;
			this.personUserControl1.Size = new System.Drawing.Size(348, 270);
			this.personUserControl1.TabIndex = 0;
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
			this.dataGridView1.Location = new System.Drawing.Point(367, 13);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(548, 270);
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
			// TestPersonUserControlForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(943, 294);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.personUserControl1);
			this.Name = "TestPersonUserControlForm";
			this.Text = "TestPersonUserControlForm";
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