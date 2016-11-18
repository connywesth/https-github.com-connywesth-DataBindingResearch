namespace DataBindingResearch.Views
{
	partial class TestDetailUserControlForm
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.detailViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.detailUserControl1 = new DataBindingResearch.Views.DetailUserControl();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.detailViewModelBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.detailViewModelBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(13, 122);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(463, 237);
			this.dataGridView1.TabIndex = 1;
			// 
			// firstNameDataGridViewTextBoxColumn
			// 
			this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
			this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
			this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
			// 
			// lastNameDataGridViewTextBoxColumn
			// 
			this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
			this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
			this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
			// 
			// dateOfBirthDataGridViewTextBoxColumn
			// 
			this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
			this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
			this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
			// 
			// addressDataGridViewTextBoxColumn
			// 
			this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
			this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
			this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
			// 
			// detailViewModelBindingSource
			// 
			this.detailViewModelBindingSource.DataSource = typeof(DataBindingResearch.ViewModels.DetailViewModel);
			// 
			// detailUserControl1
			// 
			this.detailUserControl1.Address = "";
			this.detailUserControl1.DateOfBirth = "den 18 november 2016";
			detail1.Address = "";
			detail1.DateOfBirth = new System.DateTime(2016, 11, 18, 3, 1, 1, 160);
			detail1.FirstName = "";
			detail1.LastName = "";
			this.detailUserControl1.detail = detail1;
			this.detailUserControl1.FirstName = "";
			this.detailUserControl1.LastName = "";
			this.detailUserControl1.Location = new System.Drawing.Point(13, 13);
			this.detailUserControl1.Name = "detailUserControl1";
			this.detailUserControl1.Size = new System.Drawing.Size(343, 102);
			this.detailUserControl1.TabIndex = 0;
			// 
			// TestDetailUserControlForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(488, 371);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.detailUserControl1);
			this.Name = "TestDetailUserControlForm";
			this.Text = "DetailForm";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.detailViewModelBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DetailUserControl detailUserControl1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource detailViewModelBindingSource;
	}
}