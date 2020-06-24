using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Login.AppCode.Model;

//namespace Login.AppCode.BLL
//{
public class UserBLL
	{

	public UserBLL()
	{
		//
		// TODO: Add constructor logic here
		//
	}

	public DataTable InsertUserInformation(Users user)
	{
		DataTable dt = null;
		try
		{
			UsersGateway usersGateway = new UsersGateway();

			dt = usersGateway.InsertUserInformation(user);
			return dt;
		}
		catch (Exception ex)
		{

			throw ex;
		}

	}

}
//}
