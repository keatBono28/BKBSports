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
/// Created:        01-08-2018
/// Updated:        01-22-2019
/// Purpose:        This class will service requests to update
///                 data within the entire database. Updates in 
///                 this class are only allowed by an admin account type. 
/// Package:		BKBSports.App_Code.Access.Admin
/// Classes:		-DatabaseConnectionSecurity.cs
///                 -LogErrors.cs
///                 -ConstantErrors.cs
///	Lines:			241
/// Docs:  			https://bkbsportsanalytics.atlassian.net/wiki/spaces/BW/pages/1835081/UPDATEAdminDatabase.cs
/// </summary>
public class UPDATEAdminDatabase
{
    //--Objects & Classes--//
    DatabaseConnectionSecurity databaseConnectionSecurity = new DatabaseConnectionSecurity();
    LogErrors log = new LogErrors();
    ConstantErrors errorCode = new ConstantErrors();
    //--Public Methods--//
    public Boolean UPDATEAdmin_AcctLogin(int userId, string username, string password, string email)
    { 
        /// <summary>
        /// Author:			K. Bonomo
        /// Team:			OG Starters
        /// Purpose:        This method will take four parameters 
        ///                 and update the username, password or email
        ///                 for the given userId
        /// Parameters:     int userId, string username, string password, string email
        /// Method Type:    Public
        /// Return Type:    Boolean
        /// Returns:        True, if insert is valid
        /// Exception:      Insert is not valid, throw exception, 
        ///                 log the error, return false
        /// Error Code:		ERROR_DBError_ADMINACCESS_0004
        /// SQL Type:		UPDATE
        /// </summary>
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "UPDATE [AcctLogin] set username=@username," +
            " password=@password, email=@email WHERE userId=@userId";
        Boolean updateValid = false;
        //--Processing Logic--//
        //--Update Data with Database--//
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.
            ConnectionStrings[CONNECTION_STRING].ToString());
        SqlCommand queryCommand = new SqlCommand(sqlQuery, sqlConnection);
        queryCommand.Parameters.Add("@userId", SqlDbType.Int).Value = userId;
        queryCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
        queryCommand.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
        queryCommand.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
        try
        {
            sqlConnection.Open();
            if (queryCommand.ExecuteNonQuery() > 0)
            {
                updateValid = true;
                Boolean updateMaintenance = UPDATEAdmin_UserAcct_Maintenance(userId);
            }
        }
        catch (Exception exception)
        {
            log.SendErrors(ConstantErrors.ERROR_DBError_ADMINACCESS_0004, exception);
        }
        finally
        {
            queryCommand.Dispose();
            sqlConnection.Close();
        }
        //--Return Statement--//
        return updateValid;
    }
    public Boolean UPDATEAdmin_UserInfo(int userId, string firstName, string lastName, string phoneNumber, DateTime dateOfBirth, string gender)
    { 
        /// <summary>
        /// Author:			K. Bonomo
        /// Team:			OG Starters
        /// Purpose:        This method will take six parameters
        ///                 and update the user in the system
        /// Parameters:     int userId, string firstName, string lastName, 
        ///                 string phoneNumber, DateTime dateOfBirth, string gender
        /// Method Type:    Public
        /// Return Type:    Boolean
        /// Returns:        True, if insert is valid
        /// Exception:      Insert is not valid, throw exception, 
        ///                 log the error, return false
        /// Error Code:		ERROR_DBError_ADMINACCESS_0005
        /// SQL Type:		UPDATE
        /// </summary>
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "UPDATE [UserInfo] set firstName=@firstName," +
            " lastName=@lastName, phoneNumber=@phoneNumber, dateOfBirth=@dateOfBirth," +
            " gender=@gender WHERE userId=@userId";
        Boolean updateValid = false;
        //--Processing Logic--//
        //--Update Data with Database--//
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.
            ConnectionStrings[CONNECTION_STRING].ToString());
        SqlCommand queryCommand = new SqlCommand(sqlQuery, sqlConnection);
        queryCommand.Parameters.Add("@userId", SqlDbType.Int).Value = userId;
        queryCommand.Parameters.Add("@firstName", SqlDbType.VarChar).Value = firstName;
        queryCommand.Parameters.Add("@lastName", SqlDbType.VarChar).Value = lastName;
        queryCommand.Parameters.Add("@phoneNumber", SqlDbType.BigInt).Value = phoneNumber;
        queryCommand.Parameters.Add("@dateOfBirth", SqlDbType.Date).Value = dateOfBirth;
        queryCommand.Parameters.Add("@gender", SqlDbType.VarChar).Value = gender;
        try
        {
            sqlConnection.Open();
            if (queryCommand.ExecuteNonQuery() > 0)
            {
                updateValid = true;
                Boolean updateMaintenance = UPDATEAdmin_UserAcct_Maintenance(userId);
            }
        }
        catch (Exception exception)
        {
            log.SendErrors(ConstantErrors.ERROR_DBError_ADMINACCESS_0005, exception);
        }
        finally
        {
            queryCommand.Dispose();
            sqlConnection.Close();
        }
        //--Return Statement--//
        return updateValid;
    }
    public Boolean UPDATEAdmin_UserAcct_AcctFlag(int userId, string acctFlag)
    {
        /// <summary>
        /// Author:			K. Bonomo
        /// Team:			OG Starters
        /// Purpose:        This method will take two parameters 
        ///                 and update the account flag in the 
        ///                 UserAcct table.
        /// Parameters:     int userId, string acctFlag
        /// Method Type:    Public
        /// Return Type:    Boolean
        /// Returns:        True, if insert is valid
        /// Exception:      Insert is not valid, throw exception, 
        ///                 log the error, return false
        /// Error Code:		ERROR_DBError_ADMINACCESS_0007
        /// SQL Type:		UPDATE
        /// </summary>
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "UPDATE [UserAcct] set acctFlag=@acctFlag" +
            " WHERE userId=@userId";
        Boolean updateValid = false;
        //--Processing Logic--//
        //--Update Data with Database--//
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.
            ConnectionStrings[CONNECTION_STRING].ToString());
        SqlCommand queryCommand = new SqlCommand(sqlQuery, sqlConnection);
        queryCommand.Parameters.Add("@userId", SqlDbType.Int).Value = userId;
        queryCommand.Parameters.Add("@acctFlag", SqlDbType.DateTime).Value = acctFlag;
        try
        {
            sqlConnection.Open();
            if (queryCommand.ExecuteNonQuery() > 0)
            {
                updateValid = true;
                Boolean updateMaintenance = UPDATEAdmin_UserAcct_Maintenance(userId);
            }
        }
        catch (Exception exception)
        {
            log.SendErrors(ConstantErrors.ERROR_DBError_ADMINACCESS_0007, exception);
        }
        finally
        {
            queryCommand.Dispose();
            sqlConnection.Close();
        }
        //--Return Statement--//
        return updateValid;
    }
    //--Private Methods--//
    private Boolean UPDATEAdmin_UserAcct_Maintenance(int userId)
    {
        /// <summary>
        /// Author:			K. Bonomo
        /// Team:			OG Starters
        /// Purpose:        This method will take one parameter and 
        ///                 update the maintenance timestamp in the 
        ///                 UserAcct table.
        /// Parameters:     int userId
        /// Method Type:    Private
        /// Return Type:    Boolean
        /// Returns:        True, if insert is valid
        /// Exception:      Insert is not valid, throw exception, 
        ///                 log the error, return false
        /// Error Code:		ERROR_DBError_ADMINACCESS_0006
        /// SQL Type:		UPDATE
        /// </summary>
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "UPDATE [UserAcct] set acctMaintenance=@acctMaintenance" +
            " WHERE userId=@userId";
        Boolean updateValid = false;
        //--Processing Logic--//
        //--Update Data with Database--//
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.
            ConnectionStrings[CONNECTION_STRING].ToString());
        SqlCommand queryCommand = new SqlCommand(sqlQuery, sqlConnection);
        queryCommand.Parameters.Add("@userId", SqlDbType.Int).Value = userId;
        queryCommand.Parameters.Add("@acctMaintenance", SqlDbType.DateTime).Value = DateTime.Now;
        try
        {
            sqlConnection.Open();
            if (queryCommand.ExecuteNonQuery() > 0)
            {
                updateValid = true;
            }
        }
        catch (Exception exception)
        {
            log.SendErrors(ConstantErrors.ERROR_DBError_ADMINACCESS_0006, exception);
        }
        finally
        {
            queryCommand.Dispose();
            sqlConnection.Close();
        }
        //--Return Statement--//
        return updateValid;
    }
}