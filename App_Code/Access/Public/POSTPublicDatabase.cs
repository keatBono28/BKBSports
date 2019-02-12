using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// POSTPublicDatabase.cs
/// 
/// Author:         K. Bonomo
/// Team:			OG Starters
/// Created:        12-30-2018
/// Updated:        01-22-2019
/// Purpose:        This class will service requests 
///                 to insert new data for a user into 
///                 the database. 
/// Package:		BKBSports.App_Code.Access.Public
/// Classes:		-DatabaseConnectionSecurity.cs
///                 -LogErrors.cs
///                 -ConstantErrors.cs
///	Lines:			352
/// Docs:  			https://bkbsportsanalytics.atlassian.net/wiki/spaces/BW/pages/1900592/POSTPublicDatabase.cs
/// </summary>
public class POSTPublicDatabase
{
    //--Objects & Classes--//
    DatabaseConnectionSecurity databaseConnectionSecurity = new DatabaseConnectionSecurity();
    LogErrors log = new LogErrors();
    ConstantErrors errorCode = new ConstantErrors();
    //--Public Methods--//
    public Boolean POSTNewPublic_AcctLogin(string username, string password, string email)
    {
        /// <summary>
        /// Author:			K. Bonomo
        /// Team:			OG Starters
        /// Purpose:        This method will take three parameters 
        ///                 and create a new public user in the database
        /// Parameters:     string username, string password, string email
        /// Method Type:    Public
        /// Return Type:    Boolean
        /// Returns:        True, if insert is valid
        /// Exception:      Insert is not valid, throw exception, 
        ///                 log the error, return false
        /// Error Code:		ERROR_DBError_PUBLICACCESS_0001
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
            log.SendErrors(ConstantErrors.ERROR_DBError_PUBLICACCESS_0001, exception);
        }
        finally
        {
            queryCommand.Dispose();
            sqlConnection.Close();
        }
        //--Return Statment--//
        return insertValid;
    }
    public Boolean POSTNewPublic_UserInfo(int userId, string firstName, string lastName, string phoneNumber, DateTime DOB, string gender)
    {
        /// <summary>
        /// Author:			K. Bonomo
        /// Team:			OG Starters
        /// Purpose:        This method will take six parameters and 
        ///                 create a new public user in the system by 
        ///                 adding in personal data.
        /// Parameters:     int userId, string firstName, string lastName, 
        ///                 string phoneNumber, DateTime DOB, string gender 
        /// Method Type:    Public
        /// Return Type:    Boolean
        /// Returns:        True, if insert is valid
        /// Exception:      Insert is not valid, throw exception, 
        ///                 log the error, return false
        /// Error Code:		ERROR_DBError_PUBLICACCESS_0002
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
            log.SendErrors(ConstantErrors.ERROR_DBError_PUBLICACCESS_0002, exception);
        }
        finally
        {
            queryCommand.Dispose();
            sqlConnection.Close();
        }
        //--Return Statement--//
        return insertValid;
    }
    public Boolean POSTNewPublic_UserAcct(int userId, string acctType, string acctFlag)
    {
        /// <summary>
        /// Author:			K. Bonomo
        /// Team:			OG Starters
        /// Purpose:        This method will take three parameters and create 
        ///                 a new public user in the system by adding in 
        ///                 database information.
        /// Parameters:     int userId, string acctType, string acctFlag
        /// Method Type:    Public
        /// Return Type:    Boolean
        /// Returns:        True, if insert is valid
        /// Exception:      Insert is not valid, throw exception, 
        ///                 log the error, return false
        /// Error Code:		ERROR_DBError_PUBLICACCESS_0003
        /// SQL Type:		INSERT
        /// </summary>
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        Boolean insertValid = false; ;
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
        queryCommand.Parameters.Add("@acctType", SqlDbType.VarChar).Value = "Public";
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
            log.SendErrors(ConstantErrors.ERROR_DBError_PUBLICACCESS_0003, exception);
        }
        finally
        {
            queryCommand.Dispose();
            sqlConnection.Close();
        }
        //--Return Statement--//
        return insertValid;
    }
    public Boolean POSTNewPublic_ArticleComment(int userId, int articleId, string commentBody)
    {
        /// <summary>
        /// Author:			K. Bonomo
        /// Team:			OG Starters
        /// Purpose:        This method will take three parameters
        ///                 and create a new article comment
        /// Parameters:     int articleId, int userId, string commentBody
        /// Method Type:    Public
        /// Return Type:    Boolean
        /// Returns:        True, if insert is valid
        /// Exception:      Insert is not valid, throw exception, 
        ///                 log the error, return false
        /// Error Code:		ERROR_DBError_PUBLICACCESS_0004
        /// SQL Type:		INSERT
        /// </summary>
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        Boolean insertValid = false;
        string sqlQuery = "INSERT INTO [ArticleComment] (commentBody,commentCreateDate,commentMaintenance,userId,articleId) VALUES" +
            " (@commentBody,@commentCreateDate,@commentMaintenance,@userId,@articleId);";
        //--Processing Logic--//
        //--Insert Data with Database--//
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.
            ConnectionStrings[CONNECTION_STRING].ToString());
        SqlCommand queryCommand = new SqlCommand(sqlQuery, sqlConnection);
        queryCommand.Parameters.Add("@commentBody", SqlDbType.VarChar).Value = commentBody;
        queryCommand.Parameters.Add("@articleId", SqlDbType.Int).Value = articleId;
        queryCommand.Parameters.Add("@userId", SqlDbType.Int).Value = userId;
        queryCommand.Parameters.Add("@commentCreateDate", SqlDbType.DateTime).Value = DateTime.Now;
        queryCommand.Parameters.Add("@commentMaintenance", SqlDbType.DateTime).Value = DateTime.Now;

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
            log.SendErrors(ConstantErrors.ERROR_DBError_PUBLICACCESS_0004, exception);
        }
        finally
        {
            queryCommand.Dispose();
            sqlConnection.Close();
        }
        return insertValid;
    }
    public Boolean POSTNewPublic_CommentLikes(int userId, int commentId)
    {
        /// <summary>
        /// Author:			K. Bonomo
        /// Team:			OG Starters
        /// Purpose:        This method will take two parameters
        ///                 and create a comment like
        /// Parameters:     int userId, int commentId
        /// Method Type:    Public
        /// Return Type:    Boolean
        /// Returns:        True, if insert is valid
        /// Exception:      Insert is not valid, throw exception, 
        ///                 log the error, return false
        /// Error Code:		ERROR_DBError_PUBLICACCESS_0005
        /// SQL Type:		INSERT
        /// </summary>
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        Boolean insertValid = false;
        string sqlQuery = "INSERT INTO [CommentLikes] (userId,commentId) VALUES (@userId,@commentId);";
        //--Processing Logic--//
        //--Insert Data with Database--//
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.
            ConnectionStrings[CONNECTION_STRING].ToString());
        SqlCommand queryCommand = new SqlCommand(sqlQuery, sqlConnection);
        queryCommand.Parameters.Add("@commentId", SqlDbType.Int).Value = commentId;
        queryCommand.Parameters.Add("@userId", SqlDbType.Int).Value = userId;
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
            log.SendErrors(ConstantErrors.ERROR_DBError_PUBLICACCESS_0005, exception);
        }
        finally
        {
            queryCommand.Dispose();
            sqlConnection.Close();
        }
        return insertValid;
    }
    public Boolean POSTNewPublic_ArticleLikes(int userId, int articleId)
    {
        /// <summary>
        /// Author:			K. Bonomo
        /// Team:			OG Starters
        /// Purpose:        This method will take two parameters
        ///                 and create an article like
        /// Parameters:     int userId, int commentId
        /// Method Type:    Public
        /// Return Type:    Boolean
        /// Returns:        True, if insert is valid
        /// Exception:      Insert is not valid, throw exception, 
        ///                 log the error, return false
        /// Error Code:		ERROR_DBError_PUBLICACCESS_0006
        /// SQL Type:		INSERT
        /// </summary>
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        Boolean insertValid = false;
        string sqlQuery = "INSERT INTO [ArticleLikes] (userId,articleId) VALUES (@userId,@articleId);";
        //--Processing Logic--//
        //--Insert Data with Database--//
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.
            ConnectionStrings[CONNECTION_STRING].ToString());
        SqlCommand queryCommand = new SqlCommand(sqlQuery, sqlConnection);
        queryCommand.Parameters.Add("@articleId", SqlDbType.Int).Value = articleId;
        queryCommand.Parameters.Add("@userId", SqlDbType.Int).Value = userId;
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
            log.SendErrors(ConstantErrors.ERROR_DBError_PUBLICACCESS_0006, exception);
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