using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// LogErrors
/// Author:         K. Bonomo
/// Created:        12-27-2018
/// Updated:        ----------
/// Purpose:        This class takes the error that was 
///                 generated and sends it to the database 
///                 so admins can track and troubleshoot issues.
///                 
/// Documentation:  Can be found in BKBSports Runbook.
/// 
public class LogErrors
{
    //--Objects & Classes--//
    DatabaseConnectionSecurity databaseConnectionSecurity = new DatabaseConnectionSecurity();
    ConstantErrors constantErrors = new ConstantErrors();

    //--Methods--//
    public void SendErrors(string errorType, Exception exception)
    {
        /// <summary>
        /// Purpose:        This method will take two 
        ///                 parameters, and insert them 
        ///                 into the database.
        /// Parameters:     string errorType, Exception exception                
        /// Returns:        -----------------
        /// Exception:      -----------------
        /// Method Type:    Public
        /// Return Type:    Void
        /// </summary>

        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "INSERT into [ErrorLogs] (errorLocation,errorDateTime,errorException) " +
            "VALUES (@errorLocation,@errorDateTime,@errorException);";
        string newException = "";
        int fixedExceptionLength = 500;
        int startPosition = 0;
        int exceptionLength = 0;
        //--Processing logic--//
        exceptionLength = newException.Length;
        if (exceptionLength > fixedExceptionLength)
        {
            newException = Convert.ToString(exception).Substring(startPosition, fixedExceptionLength);
        }
        else
        {
            newException = Convert.ToString(exception);
        }
        //--Insert data into the database--//
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.
            ConnectionStrings[CONNECTION_STRING].ToString());
        SqlCommand queryCommand = new SqlCommand(sqlQuery, sqlConnection);
        queryCommand.Parameters.Add("@errorType", SqlDbType.VarChar).Value = errorType;
        queryCommand.Parameters.Add("@errorException", SqlDbType.Text).Value = newException;
        queryCommand.Parameters.Add("@errorDateTime", SqlDbType.DateTime).Value = DateTime.Now;
        try
        {
            sqlConnection.Open();
            if (queryCommand.ExecuteNonQuery() > 0)
            {
                // Error Logged
            }
        }
        catch (Exception ex)
        {
            // No Error to log
        }
        finally
        {
            queryCommand.Dispose();
            sqlConnection.Close();
        }
    }











}
