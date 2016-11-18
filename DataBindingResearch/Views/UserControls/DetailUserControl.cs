using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBindingResearch.Models;

namespace DataBindingResearch.Views
{
	public partial class DetailUserControl : UserControl
	{
		private BindingSource bindingSource = new BindingSource();
		public BindingSource DataSource
		{
			get
			{
				return bindingSource;
			}
			set
			{
				bindingSource=value;
			}
		}

		public Detail detail
		{
			get
			{
				Detail workDetail= new Detail();
				workDetail.FirstName = this.firstNameTextBox.Text;
				workDetail.LastName = this.lastNameTextBox.Text;
				workDetail.DateOfBirth = this.dateOfBirthDateTimePicker.Value;
				workDetail.Address = this.addressTextBox.Text;
				return workDetail;
			}
			set
			{
				this.firstNameTextBox.Text= value.FirstName;
				this.lastNameTextBox.Text = value.LastName;
				if(value.DateOfBirth!=null)
				{
					value.DateOfBirth = DateTime.Now; // Debugging
					this.dateOfBirthDateTimePicker.Value = value.DateOfBirth;
				}
				else
				{
					value.DateOfBirth = DateTime.Now;// Debugging
					this.dateOfBirthDateTimePicker.Value = value.DateOfBirth;
				}
				this.addressTextBox.Text= value.Address;
			}
		}

		public string FirstName
		{
			get
			{
				return this.firstNameTextBox.Text;
			}
			set
			{
				this.firstNameTextBox.Text=value;
			}
		}

		public string LastName
		{
			get
			{
				return this.lastNameTextBox.Text;
			}
			set
			{
				this.lastNameTextBox.Text = value;
			}
		}

		public string DateOfBirth
		{
			get
			{
				return this.dateOfBirthDateTimePicker.Text;
			}
			set
			{
				this.dateOfBirthDateTimePicker.Text = value;
			}
		}

		public string Address
		{
			get
			{
				return this.addressTextBox.Text;
			}
			set
			{
				this.addressTextBox.Text = value;
			}
		}

		//public List<Binding> DetailBindings
		//{
		//	get
		//	{
		//		Detail workDetail= new Detail();
		//		workDetail.FirstName = this.firstNameTextBox.Text;
		//		workDetail.LastName = this.lastNameTextBox.Text;
		//		workDetail.DateOfBirth = this.dateOfBirthDateTimePicker.Value;
		//		workDetail.Address = this.addressTextBox.Text;
		//		return workDetail;
		//	}
		//	set
		//	{
		//		this.firstNameTextBox.Text = value.FirstName;
		//		this.lastNameTextBox.Text = value.LastName;
		//		if(value.DateOfBirth != null)
		//		{
		//			value.DateOfBirth = DateTime.Now; // Debugging
		//			this.dateOfBirthDateTimePicker.Value = value.DateOfBirth;
		//		}
		//		else
		//		{
		//			value.DateOfBirth = DateTime.Now;// Debugging
		//			this.dateOfBirthDateTimePicker.Value = value.DateOfBirth;
		//		}
		//		this.addressTextBox.Text = value.Address;
		//	}
		//}

		public DetailUserControl()
		{
			InitializeComponent();
		}
	}
}

