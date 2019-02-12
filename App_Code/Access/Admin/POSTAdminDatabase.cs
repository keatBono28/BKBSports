using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// POSTAdminDatabase.cs
/// 
/// Author:         K. Bonomo
/// Team:			OG Starters
/// Created:        12-29-2018
/// Updated:        01-21-2019
/// Purpose:        This class will service requests to insert 
///                 new data into the database within the entire 
///                 database. Inserts in this class are only 
///                 allowed by an admin account type. 
/// Package:		BKBSports.App_Code.Access.Admin
/// Classes:		-DatabaseConnectionSecurity.cs
///                 -LogErrors.cs
///                 -ConstantErrors.cs
///	Lines:			211
/// Docs:  			https://bkbsportsanalytics.atlassian.net/wiki/spaces/BW/pages/1966167/POSTAdminDatabase.cs
/// </summary>

public class POSTAdminDatabase
{
    //--Objects & Classes--//
    DatabaseConnectionSecurity databaseConnectionSecurity = new DatabaseConnectionSecurity();
    LogErrors log = new LogErrors();
    ConstantErrors errorCode = new ConstantErrors();
    //--Public Methods--//
    public Boolean POSTNewEditor_AcctLogin(string username, string password, string email)
    {
        /// <summary>
        /// Author:			K. Bonomo
        /// Team:			OG Starters
        /// Purpose:        This method will take three 
        ///                 parameters and create a new 
        ///                 editor in the system.
        /// Parameters:     string username, string password, string email
        /// Method Type:    Public
        /// Return Type:    Boolean
        /// Returns:        True, if insert is valid
        /// Exception:      Insert is not valid, throw exception, 
        ///                 log the error, return false
        /// Error Code:		ERROR_DBError_ADMINACCESS_0001
        /// SQL Type:		INSERT
        /// </summary> 
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        Boolean insertValid = false;
        Boolean sqlQueryCheck = false;
        string sqlQueryOne = "INSERT into [AcctLogin] (username,password,email) " +
            "VALUES (@username,@password,@email);";
        string sqlQueryTwo = "INSERT into [AcctLogin] (username,password) " +
            "VALUES (@username,@password);";
        string sqlQuery = "";
        //--Processing Logic--//
        if (email == "" || email == null || email == " ")
        {
            sqlQuery = sqlQueryTwo;
        }
        else
        {
            sqlQuery = sqlQueryOne;
            sqlQueryCheck = true;
        }
        //--Insert Data with Database--//
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.
            ConnectionStrings[CONNECTION_STRING].ToString());
        SqlCommand queryCommand = new SqlCommand(sqlQuery, sqlConnection);
        queryCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
        queryCommand.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
        if (sqlQueryCheck == true)
        {
            queryCommand.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
        }
        try
        {
            sqlConnection.Open();
            if (queryCommand.ExecuteNonQuery() > 0)
            {
                insertValid = true;
            }
        }
        catch (Exception exception)
        {
            log.SendErrors(ConstantErrors.ERROR_DBError_ADMINACCESS_0001, exception);
        }
        finally
        {
            queryCommand.Dispose();
            sqlConnection.Close();
        }
        //--Return Statement--//
        return insertValid;
    }
    public Boolean POSTNewEditor_UserInfo(int userId, string firstName, string lastName, string phoneNumber, DateTime DOB, string gender)
    {
        /// <summary>
        /// Author:			K. Bonomo
        /// Team:			OG Starters
        /// Purpose:        This method will take six parameters 
        ///                 and create a new editor in the system 
        ///                 by adding in personal data.
        /// Parameters:     int userId, string firstName, string lastName, 
        ///                 string phoneNumber, DateTime DOB, string gender
        /// Method Type:    Public
        /// Return Type:    Boolean
        /// Returns:        True, if insert is valid
        /// Exception:      Insert is not valid, throw exception, 
        ///                 log the error, return false
        /// Error Code:		ERROR_DBError_ADMINACCESS_0002
        /// SQL Type:		INSERT
        /// </summary> 
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        Boolean insertValid = false;
        string sqlQuery = "INSERT into [UserInfo] (userId,firstName,lastName,phoneNumber,dateOfBirth,gender) " +
            "VALUES (@userId,@firstName,@lastName,@phoneNumber,@dateOfBirth,@gender);";
        //--Processing Logic--//
        //--Insert Data with Database--//
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.
            ConnectionStrings[CONNECTION_STRING].ToString());
        SqlCommand queryCommand = new SqlCommand(sqlQuery, sqlConnection);
        queryCommand.Parameters.Add("@userId", SqlDbType.Int).Value = userId;
        queryCommand.Parameters.Add("@firstName", SqlDbType.VarChar).Value = firstName;
        queryCommand.Parameters.Add("@lastName", SqlDbType.VarChar).Value = lastName;
        queryCommand.Parameters.Add("@phoneNumber", SqlDbType.BigInt).Value = phoneNumber;
        queryCommand.Parameters.Add("@dateOfBirth", SqlDbType.Date).Value = DOB;
        queryCommand.Parameters.Add("@gender", SqlDbType.VarChar).Value = gender;
        try
        {
            sqlConnection.Open();
            if (queryCommand.ExecuteNonQuery() > 0)
            {
                insertValid = true;
            }
        }
        catch (Exception exception)
        {
            log.SendErrors(ConstantErrors.ERROR_DBError_ADMINACCESS_0002, exception);
        }
        finally
        {
            queryCommand.Dispose();
            sqlConnection.Close();
        }
        //--Return Statement--//
        return insertValid;
    }
    public Boolean POSTNewEditor_UserAcct(int userId, string acctType, string acctFlag)
    {
        /// <summary>
        /// Author:			K. Bonomo
        /// Team:			OG Starters
        /// Purpose:        This method will take three parameters and 
        ///                 create a new editor in the system by adding 
        ///                 in database information.
        /// Parameters:     int userId, string acctType, string acctFlag
        /// Method Type:    Public
        /// Return Type:    Boolean
        /// Returns:        True, if insert is valid
        /// Exception:      Insert is not valid, throw exception, 
        ///                 log the error, return false
        /// Error Code:		ERROR_DBError_ADMINACCESS_0003
        /// SQL Type:		INSERT
        /// </summary> 
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        Boolean insertValid = false;;
        string sqlQuery = "INSERT into [UserAcct] (userId,acctType,acctCreateDate" +
            ",acctLastAccess,acctMaintenance,acctFlag) " +
            "VALUES (@userId,@acctType,@acctCreateDate" +
            ",@acctLastAccess,@acctMaintenance,@acctFlag);";
        //--Processing Logic--//
        //--Insert Data with Database--//
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.
            ConnectionStrings[CONNECTION_STRING].ToString());
        SqlCommand queryCommand = new SqlCommand(sqlQuery, sqlConnection);
        queryCommand.Parameters.Add("@userId", SqlDbType.Int).Value = userId;
        queryCommand.Parameters.Add("@acctType", SqlDbType.VarChar).Value = "Editor";
        queryCommand.Parameters.Add("@acctCreateDate", SqlDbType.DateTime).Value = DateTime.Now;
        queryCommand.Parameters.Add("@acctLastAccess", SqlDbType.DateTime).Value = DateTime.Now;
        queryCommand.Parameters.Add("@acctMaintenance", SqlDbType.DateTime).Value = DateTime.Now;
        queryCommand.Parameters.Add("@acctFlag", SqlDbType.VarChar).Value = acctFlag;
        try
        {
            sqlConnection.Open();
            if (queryCommand.ExecuteNonQuery() > 0)
            {
                insertValid = true;
            }
        }
        catch (Exception exception)
        {
            log.SendErrors(ConstantErrors.ERROR_DBError_ADMINACCESS_0003, exception);
        }
        finally
        {
            queryCommand.Dispose();
            sqlConnection.Close();
        }
        //--Return Statement--//
        return insertValid;
    }
    //--Private Methods--//
}