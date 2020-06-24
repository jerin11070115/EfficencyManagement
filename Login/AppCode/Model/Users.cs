using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.AppCode.Model
{
	public class Users
	{
		public int UserId { get; set; }
		public string UserName { get; set; }
		public string FullName { get; set; }
		public string Password { get; set; }
		public string ConfirmPassword {get;set;}
		public string IsActive { get; set; }
		public string UserType { get; set; }


	}
}
