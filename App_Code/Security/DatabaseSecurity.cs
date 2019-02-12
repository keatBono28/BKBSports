using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// DatabaseSecurity.cs
/// 
/// Author:         K. Bonomo
/// Team:			OG Starters
/// Created:        12-27-2018
/// Updated:        01-26-2019
/// Purpose:        This class will do security validation
///					to give access to certain users. 
/// Package:		BKBSports.App_Code.Security
/// Classes:		-DatabaseConnectionSecurity.cs
///                 -LogErrors.cs
///                 -ConstantErrors.cs
///	Lines:			138
/// Docs:  			https://bkbsportsanalytics.atlassian.net/wiki/spaces/BW/pages/1900602/DatabaseSecurity.cs
/// </summary>
public class DatabaseSecurity
{
    //--Objects & Classes--//
    DatabaseConnectionSecurity databaseConnectionSecurity = new DatabaseConnectionSecurity();
    LogErrors log = new LogErrors();
    ConstantErrors errorCode = new ConstantErrors();
    //--Public Methods--//
    public int ValidateUserExists(string username, string password)
    {
		/// <summary>
		/// Author:			K. Bonomo
		/// Team:			OG Starters
		/// Purpose:		This method will take two parameters and 
		///					return the userId.
		/// Parameters:		string username, string password
		/// Method Type:    Public
		/// Return Type:    Int
		/// Returns:        UserId 
		/// Exception:      User does not exist, return userId as "0"
		/// Error Code:		ERROR_DBError_SECURITY_0001
		/// SQL Type:		SELECT
		/// </summary> 
		//--Variables--//
		string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "SELECT userId FROM [AcctLogin] WHERE username=@username AND password=@password";
        int userId = 0;
        //--Processing Logic--//
        if ((username == "" || username == " ") || (password == "" || password == " "))
        {
            return userId;
        }
        //--Select Data From Database--//
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.
            ConnectionStrings[CONNECTION_STRING].ToString());
        SqlCommand queryCommand = new SqlCommand(sqlQuery, sqlConnection);
        queryCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
        queryCommand.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
        try
        {
            sqlConnection.Open();
            SqlDataReader dbReader = queryCommand.ExecuteReader();
            while (dbReader.Read())
            {
                userId = Convert.ToInt32(dbReader["userId"]);
            }
            dbReader.Close();
        }
        catch (Exception exeception)
        {
            log.SendErrors(ConstantErrors.ERROR_DBError_SECURITY_0001, exeception);
        }
        finally
        {
            queryCommand.Dispose();
            sqlConnection.Close();
        }
		//--Return Statement--//
        return userId;
    }
    public string ValidateUserAcctType(int userId)
    {
		/// <summary>
		/// Author:			K. Bonomo
		/// Team:			OG Starters
		/// Purpose:		This method will take one parameter
		///					and the users account type
		/// Parameters:		int userId
		/// Method Type:    Public
		/// Return Type:    String
		/// Returns:        Account Type 
		/// Exception:      If the userId does not exist,
		///					return "Guest" as the account type
		/// Error Code:		ERROR_DBError_SECURITY_0002
		/// SQL Type:		SELECT
		/// </summary> 

		//--Variables--//
		string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "SELECT acctType FROM [UserAcct] WHERE userId=@userId";
        string userAcctType = "Guest";
        //--Processing Logic--//
        if (userId == 0)
        {
            return userAcctType;
        }
        //--Select Data From Database--//
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.
            ConnectionStrings[CONNECTION_STRING].ToString());
        SqlCommand queryCommand = new SqlCommand(sqlQuery, sqlConnection);
        queryCommand.Parameters.Add("@userId", SqlDbType.Int).Value = userId;
        try
        {
            sqlConnection.Open();
            SqlDataReader dbReader = queryCommand.ExecuteReader();
            while (dbReader.Read())
            {
                userAcctType = dbReader["acctType"].ToString();
            }
            dbReader.Close();
        }
        catch (Exception exeception)
        {
            log.SendErrors(ConstantErrors.ERROR_DBError_SECURITY_0002, exeception);
        }
        finally
        {
            queryCommand.Dispose();
            sqlConnection.Close();
        }
		//--Return Statement--//
        return userAcctType;
    }
	//--Private Methods--//
}