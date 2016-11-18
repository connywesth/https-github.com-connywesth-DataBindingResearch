﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataBindingResearch.Models
{
	public class Detail
	{
		public String FirstName { get; set; }
		public String LastName { get; set; }
		public DateTime DateOfBirth { get; set; }
		public String Address { get; set; }
		public Detail()
		{
		}

		public override string ToString()
		{
			return $"{FirstName} {LastName}";
		}
	}

}
