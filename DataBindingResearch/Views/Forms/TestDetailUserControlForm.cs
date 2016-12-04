using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBindingResearch.Views
{
	public partial class TestDetailUserControlForm : Form
	{

		public TestDetailUserControlForm()
		{
			InitializeComponent();
			//person = new Person();
			this.detailUserControl1.DataBindings.Add("FirstName", this.detailViewModelBindingSource, "FirstName");
			this.detailUserControl1.DataBindings.Add("LastName", this.detailViewModelBindingSource, "LastName");
			this.detailUserControl1.DataBindings.Add("Address", this.detailViewModelBindingSource, "Address");
			//this.firstNameTextBox.DataBindings.Add("Text", person.MainDetail, "FirstName");

		}
	}
}
