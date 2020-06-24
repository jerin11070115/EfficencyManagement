using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Login.AppCode.Model;

//namespace Login.AppCode.Gateway.AdminGateway
//{
public class UsersGateway : ConnectionGateway
{

	public UsersGateway()
	{
		//
		// TODO: Add constructor logic here
		//
	}

	public DataTable InsertUserInformation(Users user)
	{
		DataTable dt = new DataTable();
		try
		{
			OpenConnection();
			ArrayList arlSqlParameter = new ArrayList();
			arlSqlParameter.Add(new SqlParameter("@UserName", user.UserName));
			arlSqlParameter.Add(new SqlParameter("@FullName", user.FullName));
			arlSqlParameter.Add(new SqlParameter("@Password", user.Password));
			arlSqlParameter.Add(new SqlParameter("@IsActive", user.IsActive));
			arlSqlParameter.Add(new SqlParameter("@UserType", user.UserType));
			dt = this.ExecuteQuery("[Effi].[USP_InsertNewUserInformation]", arlSqlParameter);
		}
		catch (Exception ex)
		{


		}
		finally
		{
			CloseConnection();
		}
		return dt;


	}




}
//}
