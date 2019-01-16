using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// DatabaseService
/// Author:         K. Bonomos
/// Created:        12-27-2018
/// Updated:        01-09-2019
/// Purpose:        This class services requests to the 
///                 database that will return data based 
///                 on an userId passed in.
/// Documentation:  Can be found in BKBSports Runbook.
/// 
///              
/// </summary>
public class GETDatabaseService
{
    //--Objects & Classes--//
    DatabaseConnectionSecurity databaseConnectionSecurity = new DatabaseConnectionSecurity();
    LogErrors log = new LogErrors();
    ConstantErrors errorCode = new ConstantErrors();

    //--GET Methods--//
    public string GETUserFullName(int userId)
    {
        /// <summary>
        /// Purpose:        This method will take one 
        ///                 parameter and return the users full name.
        /// Parameters:     int userId               
        /// Returns:        full name
        /// Exception:      user info is null, return "no name"
        /// Method Type:    Public
        /// Return Type:    string
        /// </summary>
        /// 
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "SELECT firstName, lastName " +
                            "FROM [UserInfo] " +
                            "WHERE userId=@userId";
        string usersName = "no name";
        //--Processing logic--//
        if (userId < 1)
        {
            return usersName;
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
                if (dbReader["firstName"] != null && dbReader["lastName"] != null)
                {
                    usersName = dbReader["firstName"].ToString() + " " + dbReader["lastName"].ToString();
                }
                else if (dbReader["firstName"] == null && dbReader["lastName"] != null)
                {
                    usersName = dbReader["lastName"].ToString();
                }
                else if (dbReader["firstName"] != null && dbReader["lastName"] == null)
                {
                    usersName = dbReader["firstName"].ToString();
                }
                else
                    return usersName;
            }
            dbReader.Close();
        }
        catch (Exception exeception)
        {
            log.SendErrors(ConstantErrors.ERROR_DBError_SERVICE_0001, exeception);
        }
        finally
        {
            queryCommand.Dispose();
            sqlConnection.Close();
        }
        return usersName;
    }
    public string GETUserFirstName(int userId)
    {
        /// <summary>
        /// Purpose:        This method will take one 
        ///                 parameter and return the users first name.
        /// Parameters:     int userId               
        /// Returns:        first name
        /// Exception:      user info is null, return "no name"
        /// Method Type:    Public
        /// Return Type:    string
        /// </summary>
        /// 
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "SELECT firstName " +
                            "FROM [UserInfo] " +
                            "WHERE userId=@userId";
        string usersName = "no name";
        //--Processing logic--//
        if (userId < 1)
        {
            return usersName;
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
                if (dbReader["firstName"] != null)
                {
                    usersName = dbReader["firstName"].ToString();
                }
            }
            dbReader.Close();
        }
        catch (Exception exeception)
        {
            log.SendErrors(ConstantErrors.ERROR_DBError_SERVICE_0002, exeception);
        }
        finally
        {
            queryCommand.Dispose();
            sqlConnection.Close();
        }
        return usersName;
    }
    public string GETUserLastName(int userId)
    {
        /// <summary>
        /// Purpose:        This method will take one 
        ///                 parameter and return the users last name.
        /// Parameters:     int userId               
        /// Returns:        last name
        /// Exception:      user info is null, return "no name"
        /// Method Type:    Public
        /// Return Type:    string
        /// </summary>
        /// 
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "SELECT lastName " +
                            "FROM [UserInfo] " +
                            "WHERE userId=@userId";
        string usersName = "no name";
        //--Processing logic--//
        if (userId < 1)
        {
            return usersName;
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
                if (dbReader["lastName"] != null)
                {
                    usersName = dbReader["lastName"].ToString();
                }
            }
            dbReader.Close();
        }
        catch (Exception exeception)
        {
            log.SendErrors(ConstantErrors.ERROR_DBError_SERVICE_0003, exeception);
        }
        finally
        {
            queryCommand.Dispose();
            sqlConnection.Close();
        }
        return usersName;
    }
    public string GETUserAcctType(int userId)
    {
        /// <summary>
        /// Purpose:        This method will take one 
        ///                 parameter and return the users acctType.
        /// Parameters:     int userId               
        /// Returns:        account type
        /// Exception:      user info is null, return Guest
        /// Method Type:    Public
        /// Return Type:    string
        /// </summary>
        /// 
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "SELECT acctType " +
                            "FROM [UserAcct] " +
                            "WHERE userId=@userId";
        string acctType = "Guest";
        //--Processing logic--//
        if (userId < 1)
        {
            return acctType;
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
                if (dbReader["acctType"] != null)
                {
                    acctType = dbReader["acctType"].ToString();
                }
            }
            dbReader.Close();
        }
        catch (Exception exeception)
        {
            log.SendErrors(ConstantErrors.ERROR_DBError_SERVICE_0013, exeception);
        }
        finally
        {
            queryCommand.Dispose();
            sqlConnection.Close();
        }
        return acctType;
    }
    public string GETUserAcctFlag(int userId)
    {
        /// <summary>
        /// Purpose:        This method will take one 
        ///                 parameter and return the users acctFlag.
        /// Parameters:     int userId               
        /// Returns:        account flag
        /// Exception:      user info is null, return null
        /// Method Type:    Public
        /// Return Type:    string
        /// </summary>
        /// 
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "SELECT acctFlag " +
                            "FROM [UserAcct] " +
                            "WHERE userId=@userId";
        string acctType = "null";
        //--Processing logic--//
        if (userId < 1)
        {
            return acctType;
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
                if (dbReader["acctType"] != null)
                {
                    acctType = dbReader["acctType"].ToString();
                }
            }
            dbReader.Close();
        }
        catch (Exception exeception)
        {
            log.SendErrors(ConstantErrors.ERROR_DBError_SERVICE_0014, exeception);
        }
        finally
        {
            queryCommand.Dispose();
            sqlConnection.Close();
        }
        return acctType;
    }
    
}