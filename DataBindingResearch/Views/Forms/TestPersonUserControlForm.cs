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
	public partial class TestPersonUserControlForm : Form
	{
		public TestPersonUserControlForm()
		{
			InitializeComponent();

			// Binding
			BindAlt2();
		}

		/// <summary>
		/// Binding Alt 1
		/// </summary>
		public void BindAlt1()
		{
			// Binding to DisplayName
			this.personUserControl1.DataBindings.Add("DisplayName", this.personViewModelBindingSource, "DisplayName");

			// Binding to MainDetail
			this.personUserControl1.DataBindings.Add("MainDetail.FirstName", this.personViewModelBindingSource, "MainDetail.FirstName");
			this.personUserControl1.DataBindings.Add("MainDetail.LastName", this.personViewModelBindingSource, "MainDetail.LastName");
			this.personUserControl1.DataBindings.Add("MainDetail.Address", this.personViewModelBindingSource, "MainDetail.Address");

			// Binding to PartnerDetail
			this.personUserControl1.DataBindings.Add("PartnerDetail.FirstName", this.personViewModelBindingSource, "PartnerDetail.FirstName");
			this.personUserControl1.DataBindings.Add("PartnerDetail.LastName", this.personViewModelBindingSource, "PartnerDetail.LastName");
			this.personUserControl1.DataBindings.Add("PartnerDetail.Address", this.personViewModelBindingSource, "PartnerDetail.Address");
		}

		/// <summary>
		/// Binding Alt 2, verkar fungera p åObject-nivå....
		/// </summary>
		public void BindAlt2()
		{
			// Binding to DisplayName
			this.personUserControl1.DataBindings.Add("DisplayName", this.personViewModelBindingSource, "DisplayName");

			// Binding to MainDetail
			this.personUserControl1.DataBindings.Add("MainDetail", this.personViewModelBindingSource, "MainDetail");

			// Binding to PartnerDetail
			this.personUserControl1.DataBindings.Add("PartnerDetail", this.personViewModelBindingSource, "PartnerDetail");
		}
	}
}
