using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// UPDATEPublicDatabase
/// Author:         K. Bonomo
/// Created:        01-08-2019
/// Updated:        01-08-2019
/// Purpose:        This class services requests to the 
///                 database that will return data based 
///                 on an userId passed in.
/// Documentation:  Can be found in BKBSports Runbook.
/// </summary>
public class UPDATEPublicDatabase
{
    //--Objects & Classes--//
    DatabaseConnectionSecurity databaseConnectionSecurity = new DatabaseConnectionSecurity();
    LogErrors log = new LogErrors();
    ConstantErrors errorCode = new ConstantErrors();

    //--Methods--//
    public Boolean UPDATEPublic_AcctLogin(int userId, string username, string password, string email)
    {
        /// <summary>
        /// Purpose:        This method will take four parameters
        ///                 and update the AcctLogin table for a user
        /// Parameters:     int userId, string username, string password, string email              
        /// Returns:        true, if update is valid
        /// Exception:      udpate failed
        /// Method Type:    Public
        /// Return Type:    Boolean
        /// </summary>
        /// 
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "UPDATE [AcctLogin] set username=@username," +
            " password=@password, email=@email WHERE userId=@userId";
        Boolean updateValid = false;
        //--Insert data into database--//
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
            }
            Boolean updateMaintenance = UPDATEPublic_UserAcct(userId);
        }
        catch (Exception exception)
        {
            log.SendErrors(ConstantErrors.ERROR_DBError_PUBLICACCESS_0007, exception);
        }
        finally
        {
            queryCommand.Dispose();
            sqlConnection.Close();
        }
        return updateValid;
    }
    public Boolean UPDATEPublic_UserInfo(int userId, string firstName, string lastName, string phoneNumber, DateTime dateOfBirth, string gender)
    {
        /// <summary>
        /// Purpose:        This method will take six parameters
        ///                 and update the UserInfo table for a user
        /// Parameters:     int userId, string firstName, string lastName, string phoneNumber
        ///                 DateTime dateOfBirth, string gender
        /// Returns:        true, if update is valid
        /// Exception:      udpate failed
        /// Method Type:    Public
        /// Return Type:    Boolean
        /// </summary>
        /// 
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "UPDATE [UserInfo] set firstName=@firstName," +
            " lastName=@lastName, phoneNumber=@phoneNumber, dateOfBirth=@dateOfBirth," +
            " gender=@gender WHERE userId=@userId";
        Boolean updateValid = false;
        //--Insert data into database--//
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
            }
            Boolean updateMaintenance = UPDATEPublic_UserAcct(userId);
        }
        catch (Exception exception)
        {
            log.SendErrors(ConstantErrors.ERROR_DBError_PUBLICACCESS_0008, exception);
        }
        finally
        {
            queryCommand.Dispose();
            sqlConnection.Close();
        }
        return updateValid;
    }
    public Boolean UPDATEPublic_UserAcct(int userId)
    {
        /// <summary>
        /// Purpose:        This method will take one parameter
        ///                 and update the UserAcct table for a user
        /// Parameters:     int userId
        /// Returns:        true, if update is valid
        /// Exception:      udpate failed
        /// Method Type:    Public
        /// Return Type:    Boolean
        /// </summary>
        /// 
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "UPDATE [UserAcct] set acctMaintenance=@acctMaintenance" +
            " WHERE userId=@userId";
        Boolean updateValid = false;
        //--Insert data into database--//
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
            log.SendErrors(ConstantErrors.ERROR_DBError_PUBLICACCESS_0009, exception);
        }
        finally
        {
            queryCommand.Dispose();
            sqlConnection.Close();
        }
        return updateValid;
    }

}