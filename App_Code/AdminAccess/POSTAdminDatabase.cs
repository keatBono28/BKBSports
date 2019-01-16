using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// POSTAdminDatabase
/// Author:         K. Bonomo
/// Created:        12-29-2018
/// Updated:        12-30-2018
/// Purpose:        This class services requests to the 
///                 database that will insert data based 
///                 on information passed in.
/// Documentation:  Can be found in BKBSports Runbook.
///            
/// </summary>
/// 
public class POSTAdminDatabase
{
    //--Objects & Classes--//
    DatabaseConnectionSecurity databaseConnectionSecurity = new DatabaseConnectionSecurity();
    LogErrors log = new LogErrors();
    ConstantErrors errorCode = new ConstantErrors();

    //--Methods--//
    public Boolean POSTNewEditor_AcctLogin(string username, string password, string email)
    {
        /// <summary>
        /// Purpose:        This method will take three 
        ///                 parameters and return true if insert 
        ///                 was valid.
        /// Parameters:     string username, string password               
        /// Returns:        true
        /// Exception:      If insert failed, return false
        /// Method Type:    Public
        /// Return Type:    Boolean
        /// </summary>
        /// 
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        Boolean insertValid = false;
        Boolean sqlQueryCheck = false;
        string sqlQueryOne = "INSERT into [AcctLogin] (username,password,email) " +
            "VALUES (@username,@password,@email);";
        string sqlQueryTwo = "INSERT into [AcctLogin] (username,password) " +
            "VALUES (@username,@password);";
        string sqlQuery = "";
        //--Processing logic--//
        if (email == "" || email == null || email == " ")
        {
            sqlQuery = sqlQueryTwo;
        }
        else
        {
            sqlQuery = sqlQueryOne;
            sqlQueryCheck = true;
        }
        //--Insert data into database--//
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
        return insertValid;
    }
    public Boolean POSTNewEditor_UserInfo(int userId, string firstName, string lastName, string phoneNumber, DateTime DOB, string gender)
    {
        /// <summary>
        /// Purpose:        This method will take six 
        ///                 parameters and return true if insert 
        ///                 was valid.
        /// Parameters:     int userId, string firstName, string lastName, string phoneNumber, 
        ///                 DateTime DOB, string gender               
        /// Returns:        true
        /// Exception:      If insert failed, return false
        /// Method Type:    Public
        /// Return Type:    Boolean
        /// </summary>
        /// 
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        Boolean insertValid = false;
        string sqlQuery = "INSERT into [UserInfo] (userId,firstName,lastName,phoneNumber,dateOfBirth,gender) " +
            "VALUES (@userId,@firstName,@lastName,@phoneNumber,@dateOfBirth,@gender);";
        
        //--Processing logic--//
        
        //--Insert data into database--//
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
        return insertValid;
    }
    public Boolean POSTNewEditor_UserAcct(int userId, string acctType, string acctFlag)
    {
        /// <summary>
        /// Purpose:        This method will take three 
        ///                 parameters and return true if insert 
        ///                 was valid.
        /// Parameters:     int userId, string acctType, string acctFlag             
        /// Returns:        true
        /// Exception:      If insert failed, return false
        /// Method Type:    Public
        /// Return Type:    Boolean
        /// </summary>
        /// 
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        Boolean insertValid = false;;
        string sqlQuery = "INSERT into [UserAcct] (userId,acctType,acctCreateDate" +
            ",acctLastAccess,acctMaintenance,acctFlag) " +
            "VALUES (@userId,@acctType,@acctCreateDate" +
            ",@acctLastAccess,@acctMaintenance,@acctFlag);";
        //--Processing logic--//
        //--Insert data into database--//
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
        return insertValid;
    }











}