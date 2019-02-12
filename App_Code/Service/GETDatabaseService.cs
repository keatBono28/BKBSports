using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// DatabaseService.cs
/// 
/// Author:         K. Bonomo
/// Team:			OG Starters
/// Created:        12-27-2018
/// Updated:        01-26-2019
/// Purpose:        This class will service general
///					database requests to get information
/// Package:		BKBSports.App_Code.Service
/// Classes:		-DatabaseConnectionSecurity.cs
///                 -LogErrors.cs
///                 -ConstantErrors.cs
///	Lines:			327
/// Docs:  			https://bkbsportsanalytics.atlassian.net/wiki/spaces/BW/pages/1900606/GETDatabaseService.cs
/// </summary>
public class GETDatabaseService
{
    //--Objects & Classes--//
    DatabaseConnectionSecurity databaseConnectionSecurity = new DatabaseConnectionSecurity();
    LogErrors log = new LogErrors();
    ConstantErrors errorCode = new ConstantErrors();
    //--Pubilc Methods--//
    public string GETUserFullName(int userId)
    {
		/// <summary>
		/// Author:			K. Bonomo
		/// Team:			OG Starters
		/// Purpose:        This method will take one parameter 
		///					and return the users full name
		/// Parameters:     int userId
		/// Method Type:    Public
		/// Return Type:    String
		/// Returns:        Users Full Name
		/// Exception:      If the users name is 
		///					not in the system return "no name"
		/// Error Code:		ERROR_DBError_SERVICE_0001
		/// SQL Type:		SELECT
		/// </summary> 
		//--Variables--//
		string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "SELECT firstName, lastName " +
                            "FROM [UserInfo] " +
                            "WHERE userId=@userId";
        string usersName = "no name";
        //--Processing Logic--//
        if (userId < 1)
        {
            return usersName;
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
		//--Return Statement--//
        return usersName;
    }
    public string GETUserFirstName(int userId)
    {
		/// <summary>
		/// Author:			K. Bonomo
		/// Team:			OG Starters
		/// Purpose:        This method will take one parameter 
		///					and return the users first name
		/// Parameters:     int userId
		/// Method Type:    Public
		/// Return Type:    String
		/// Returns:        Users first Name
		/// Exception:      If the users name is 
		///					not in the system return "no name"
		/// Error Code:		ERROR_DBError_SERVICE_0002
		/// SQL Type:		SELECT
		/// </summary>
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
		//--Return Statement--//
        return usersName;
    }
    public string GETUserLastName(int userId)
    {
		/// <summary>
		/// Author:			K. Bonomo
		/// Team:			OG Starters
		/// Purpose:        This method will take one parameter 
		///					and return the users last name
		/// Parameters:     int userId
		/// Method Type:    Public
		/// Return Type:    String
		/// Returns:        Users last Name
		/// Exception:      If the users name is 
		///					not in the system return "no name"
		/// Error Code:		ERROR_DBError_SERVICE_0003
		/// SQL Type:		SELECT
		/// </summary>
		//--Variables--//
		string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "SELECT lastName " +
                            "FROM [UserInfo] " +
                            "WHERE userId=@userId";
        string usersName = "no name";
        //--Processing Logic--//
        if (userId < 1)
        {
            return usersName;
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
		//--Return Statement--//
        return usersName;
    }
    public string GETUserAcctType(int userId)
    {
		/// <summary>
		/// Author:			K. Bonomo
		/// Team:			OG Starters
		/// Purpose:        This method will take one parameter 
		///					and return the users account type
		/// Parameters:     int userId
		/// Method Type:    Public
		/// Return Type:    String
		/// Returns:        Users account type
		/// Exception:      If the users account type is 
		///					not in the system return "Guest"
		/// Error Code:		ERROR_DBError_SERVICE_0013
		/// SQL Type:		SELECT
		/// </summary>
		//--Variables--//
		string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "SELECT acctType " +
                            "FROM [UserAcct] " +
                            "WHERE userId=@userId";
        string acctType = "Guest";
        //--Processing Logic--//
        if (userId < 1)
        {
            return acctType;
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
		//--Return Statement--//
        return acctType;
    }
    public string GETUserAcctFlag(int userId)
    {
		/// <summary>
		/// Author:			K. Bonomo
		/// Team:			OG Starters
		/// Purpose:        This method will take one parameter 
		///					and return the users account flag
		/// Parameters:     int userId
		/// Method Type:    Public
		/// Return Type:    String
		/// Returns:        Users account flag
		/// Exception:      Database connection failed
		/// Error Code:		ERROR_DBError_SERVICE_0014
		/// SQL Type:		SELECT
		/// </summary>
		//--Variables--//
		string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "SELECT acctFlag " +
                            "FROM [UserAcct] " +
                            "WHERE userId=@userId";
        string acctType = "null";
        //--Processing Logic--//
        if (userId < 1)
        {
            return acctType;
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
		//--Return Statement--//
        return acctType;
    }
    //--Private Methods--//
}