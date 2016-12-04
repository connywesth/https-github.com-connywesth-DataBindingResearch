using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingResearch.Models
{


	public class Person
	{
		public Int32 ID { get; set; }
		public Boolean IsMarried { get; set; }
		public String DisplayName { get; set; }
		public Detail MainDetail { get; set; }
		public Detail PartnerDetail { get; set; }

		public Person()
		{
			MainDetail = new Detail();
			PartnerDetail = new Detail();
		}

		public override string ToString()
		{
			string str = $"{DisplayName}";
			if(PartnerDetail.FirstName.Length > 0)
			{
				str += $"(Partner: {PartnerDetail.FirstName} {PartnerDetail.LastName})";
			}
			return $"{str}";
		}

	}
}
