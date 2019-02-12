using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// LogErrors.cs
/// 
/// Author:         K. Bonomo
/// Team:			OG Starters
/// Created:        12-27-2018
/// Updated:        01-26-2019
/// Purpose:        This class will handle any logging
/// Package:		BKBSports.App_Code.Errors
/// Classes:		-DatabaseConnectionSecurity.cs
///	Lines:			87
/// Docs:  			https://bkbsportsanalytics.atlassian.net/wiki/spaces/BW/pages/1867792/LogErrors.cs
/// </summary>
public class LogErrors
{
    //--Objects & Classes--//
    DatabaseConnectionSecurity databaseConnectionSecurity = new DatabaseConnectionSecurity();
    //--Methods--//
    public void SendErrors(string errorType, Exception exception)
    {
		/// <summary>
		/// Author:			K. Bonomo
		/// Team:			OG Starters
		/// Purpose:        This method will log any errors
		///					that may occur when connecting 
		///					the databases.
		/// Parameters:     string errorType, Exception exception
		/// Method Type:    Public
		/// Return Type:    Void
		/// Returns:        
		/// Exception:      
		/// Error Code:		
		/// SQL Type:		INSERT
		/// </summary> 
		//--Variables--//
		string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "INSERT into [ErrorLogs] (errorLocation,errorDateTime,errorException) " +
            "VALUES (@errorLocation,@errorDateTime,@errorException);";
        string newException = "";
        int fixedExceptionLength = 500;
        int startPosition = 0;
        int exceptionLength = 0;
        //--Processing Logic--//
        exceptionLength = newException.Length;
        if (exceptionLength > fixedExceptionLength)
        {
            newException = Convert.ToString(exception).Substring(startPosition, fixedExceptionLength);
        }
        else
        {
            newException = Convert.ToString(exception);
        }
        //--Insert Data with Database--//
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
