using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// DatabaseSecurity
/// Author:         K. Bonomo
/// Created:        12-27-2018
/// Updated:        ----------
/// Purpose:        This class validates the security
///                 of the user and session to give 
///                 permissions to user to access 
///                 database.
///                 
/// Documentation:  Can be found in BKBSports Runbook.
/// 
public class DatabaseSecurity
{
    //--Objects & Classes--//
    DatabaseConnectionSecurity databaseConnectionSecurity = new DatabaseConnectionSecurity();
    LogErrors log = new LogErrors();
    ConstantErrors errorCode = new ConstantErrors();

    //--Methods--//
    public int ValidateUserExists(string username, string password)
    {
        /// <summary>
        /// Purpose:        This method will take two 
        ///                 parameters and return the userId.
        /// Parameters:     string username, string password               
        /// Returns:        userId
        /// Exception:      If user does not exist, return 0
        /// Method Type:    Public
        /// Return Type:    int
        /// </summary>
        /// 
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "SELECT userId FROM [AcctLogin] WHERE username=@username AND password=@password";
        int userId = 0;
        //--Processing logic--//
        if ((username == "" || username == " ") || (password == "" || password == " "))
        {
            return userId;
        }
        //--Get data from database--//
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
        return userId;
    }
    public string ValidateUserAcctType(int userId)
    {
        /// <summary>
        /// Purpose:        This method will take one 
        ///                 parameter and return the 
        ///                 users account type.
        /// Parameters:     int userId                
        /// Returns:        Public, Editor, Admin
        /// Exception:      If user does not exist, return "Guest"
        /// Method Type:    Public
        /// Return Type:    String
        /// </summary>
        /// 

        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "SELECT acctType FROM [UserAcct] WHERE userId=@userId";
        string userAcctType = "Guest";
        //--Processing logic--//
        if (userId == 0)
        {
            return userAcctType;
        }
        //--Get data from database--//
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
        return userAcctType;
    }

}