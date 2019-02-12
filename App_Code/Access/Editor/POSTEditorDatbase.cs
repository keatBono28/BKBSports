using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// POSTEditorDatabase.cs
/// 
/// Author:         K. Bonomo
/// Team:			OG Starters
/// Created:        01-06-2019
/// Updated:        01-21-2019
/// Purpose:        This class will service requests to insert 
///                 new data into the database within the Article 
///                 tables. 
/// Package:		BKBSports.App_Code.Access.Editor
/// Classes:		-DatabaseConnectionSecurity.cs
///                 -LogErrors.cs
///                 -ConstantErrors.cs
///	Lines:			397
/// Docs:  			https://bkbsportsanalytics.atlassian.net/wiki/spaces/BW/pages/1835064/POSTEditorDatabase.cs
/// </summary>


public class POSTEditorDatbase
{
    //--Objects & Classes--//
    DatabaseConnectionSecurity databaseConnectionSecurity = new DatabaseConnectionSecurity();
    LogErrors log = new LogErrors();
    ConstantErrors errorCode = new ConstantErrors();
    //--Public Methods--//
    public Boolean POSTArtilce_Article(string articleTitle, int userId, string articleParaOne, string articleParaTwo, string articleParaThree, string articleParaFour, string articleParaFive,
        string articleParaSix, string articleParaSeven, string articleParaEight, string articleParaNine)
    {
        /// <summary>
        /// Author:			K. Bonomo
        /// Team:			OG Starters
        /// Purpose:        This method will take eleven parameters 
        ///                 and insert a new article into the article 
        ///                 table.
        /// Parameters:     string articleTitle, int userId, string articleParaOne, 
        ///                 string articleParaTwo, string articleParaThree, string articleParaFour, 
        ///                 string articleParaFive, string articleParaSix, string articleParaSeven, 
        ///                 string articleParaEight, string articleParaNine
        /// Method Type:    Public
        /// Return Type:    Boolean
        /// Returns:        True, if insert is valid
        /// Exception:      Insert is not valid, throw exception, log the error, return false
        /// Error Code:		ERROR_DBError_EDITORACCESS_0001
        /// SQL Type:		INSERT
        /// </summary>
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        Boolean insertValid = false;
        string sqlQuery = "INSERT INTO [Article] (articleTitle,articleCreateDate,articleMaintenance," +
        "userId,articleParaOne,articleParaTwo,articleParaThree,articleParaFour,articleParaFive," +
        "articleParaSix,articleParaSeven,articleParaEight,articleParaNine) VALUES " +
        "(@articleTitle,@articleCreateDate,@articleMaintenance,@userId,@articleParaOne," +
        "@articleParaTwo,@articleParaThree,@articleParaFour,@articleParaFive,@articleParaSix," +
        "@articleParaSeven,@articleParaEight,@articleParaNine);";
        //--Processing Logic--//
        //--Insert data into the database--//
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.
            ConnectionStrings[CONNECTION_STRING].ToString());
        SqlCommand queryCommand = new SqlCommand(sqlQuery, sqlConnection);
        queryCommand.Parameters.Add("@articleTitle", SqlDbType.VarChar).Value = articleTitle;
        queryCommand.Parameters.Add("@articleCreateDate", SqlDbType.DateTime).Value = DateTime.Now;
        queryCommand.Parameters.Add("@articleMaintenance", SqlDbType.VarChar).Value = DateTime.Now;
        queryCommand.Parameters.Add("@userId", SqlDbType.VarChar).Value = userId;
        queryCommand.Parameters.Add("@articleParaOne", SqlDbType.VarChar).Value = articleParaOne;
        queryCommand.Parameters.Add("@articleParaTwo", SqlDbType.VarChar).Value = articleParaTwo;
        queryCommand.Parameters.Add("@articleParaThree", SqlDbType.VarChar).Value = articleParaThree;
        queryCommand.Parameters.Add("@articleParaFour", SqlDbType.VarChar).Value = articleParaFour;
        queryCommand.Parameters.Add("@articleParaFive", SqlDbType.VarChar).Value = articleParaFive;
        queryCommand.Parameters.Add("@articleParaSix", SqlDbType.VarChar).Value = articleParaSix;
        queryCommand.Parameters.Add("@articleParaSeven", SqlDbType.VarChar).Value = articleParaSeven;
        queryCommand.Parameters.Add("@articleParaEight", SqlDbType.VarChar).Value = articleParaEight;
        queryCommand.Parameters.Add("@articleParaNine", SqlDbType.VarChar).Value = articleParaNine;
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
            log.SendErrors(ConstantErrors.ERROR_DBError_EDITORACCESS_0001, exception);
        }
        finally
        {
            queryCommand.Dispose();
            sqlConnection.Close();
        }
        //--Return Statement--//
        return insertValid;
    }
    public Boolean POSTArticle_Picture(string filePath, int sourceId)
    {
        /// <summary>
        /// Author:			K. Bonomo
        /// Team:			OG Starters
        /// Purpose:        This method will take two parameters and 
        ///                 add in a new picture in the database.
        /// Parameters:     string filePath, int sourceId
        /// Method Type:    Public
        /// Return Type:    Boolean
        /// Returns:        True, if insert is valid
        /// Exception:      Insert is not valid, throw exception, 
        ///                 log the error, return false
        /// Error Code:		ERROR_DBError_EDITORACCESS_0002
        /// SQL Type:		INSERT
        /// </summary> 
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        Boolean insertValid = false;
        string sqlQuery = "INSERT INTO [Pictures] (filePath,pictureAddedDate,sourceId) VALUES" +
            " (@filePath,@pictureAddedDate,@sourceId);";
        //--Processing Logic--//
        //--Insert Data with Database--//
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.
            ConnectionStrings[CONNECTION_STRING].ToString());
        SqlCommand queryCommand = new SqlCommand(sqlQuery, sqlConnection);
        queryCommand.Parameters.Add("@filePath", SqlDbType.VarChar).Value = filePath;
        queryCommand.Parameters.Add("@pictureAddedDate", SqlDbType.DateTime).Value = DateTime.Now;
        queryCommand.Parameters.Add("@sourceId", SqlDbType.Int).Value = sourceId;
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
            log.SendErrors(ConstantErrors.ERROR_DBError_EDITORACCESS_0002, exception);
        }
        finally
        {
            queryCommand.Dispose();
            sqlConnection.Close();
        }
        //--Return Statement--//
        return insertValid;
    }
    public Boolean POSTArticle_Video(string filePath, int sourceId)
    {
        /// <summary>
        /// Author:			K. Bonomo
        /// Team:			OG Starters
        /// Purpose:        This method will take two parameters and 
        ///                 add in a new video in the database.
        /// Parameters:     string filePath, int sourceId
        /// Method Type:    Public
        /// Return Type:    Boolean
        /// Returns:        True, if insert is valid
        /// Exception:      Insert is not valid, throw exception, 
        ///                 log the error, return false
        /// Error Code:		ERROR_DBError_EDITORACCESS_0003
        /// SQL Type:		INSERT
        /// </summary> 
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        Boolean insertValid = false;
        string sqlQuery = "INSERT INTO [Videos] (filePath,pictureAddedDate,sourceId) VALUES" +
            " (@filePath,@pictureAddedDate,@sourceId);";
        //--Processing Logic--//
        //--Insert data into the database--//
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.
            ConnectionStrings[CONNECTION_STRING].ToString());
        SqlCommand queryCommand = new SqlCommand(sqlQuery, sqlConnection);
        queryCommand.Parameters.Add("@filePath", SqlDbType.VarChar).Value = filePath;
        queryCommand.Parameters.Add("@videoAddedDate", SqlDbType.DateTime).Value = DateTime.Now;
        queryCommand.Parameters.Add("@sourceId", SqlDbType.Int).Value = sourceId;
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
            log.SendErrors(ConstantErrors.ERROR_DBError_EDITORACCESS_0003, exception);
        }
        finally
        {
            queryCommand.Dispose();
            sqlConnection.Close();
        }
        //--Return Statement--//
        return insertValid;
    }
    public Boolean POSTArticle_Source(string sourceName, string sourceURL)
    {
        /// <summary>
        /// Author:			K. Bonomo
        /// Team:			OG Starters
        /// Purpose:        This method will take two parameters and add 
        ///                 in a new content or media source to ensure 
        ///                 proper citing is being done.
        /// Parameters:     string sourceName, string sourceURL
        /// Method Type:    Public
        /// Return Type:    Boolean
        /// Returns:        True, if insert is valid
        /// Exception:      Insert is not valid, throw exception, 
        ///                 log the error, return false
        /// Error Code:		ERROR_DBError_EDITORACCESS_0004
        /// SQL Type:		INSERT
        /// </summary> 
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        Boolean insertValid = false;
        string sqlQuery = "INSERT INTO [Source] (sourceName,sourceURL) VALUES" +
            " (@sourceName,@sourceURL);";
        //--Processing Logic--//
        //--Insert data into the database--//
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.
            ConnectionStrings[CONNECTION_STRING].ToString());
        SqlCommand queryCommand = new SqlCommand(sqlQuery, sqlConnection);
        queryCommand.Parameters.Add("@sourceName", SqlDbType.VarChar).Value = sourceName;
        queryCommand.Parameters.Add("@sourceURL", SqlDbType.VarChar).Value = sourceURL;
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
            log.SendErrors(ConstantErrors.ERROR_DBError_EDITORACCESS_0004, exception);
        }
        finally
        {
            queryCommand.Dispose();
            sqlConnection.Close();
        }
        //--Return Statement--//
        return insertValid;
    }
    public Boolean POSTArticle_ArticlePicture(int pictureId, int articleId)
    {
        /// <summary>
        /// Author:			K. Bonomo
        /// Team:			OG Starters
        /// Purpose:        This method will take in two parameters 
        ///                 and establish a connection between a picture 
        ///                 and an article.
        /// Parameters:     int pictureId, int articleId
        /// Method Type:    Public
        /// Return Type:    Boolean
        /// Returns:        True, if insert is valid
        /// Exception:      Insert is not valid, throw exception, 
        ///                 log the error, return false
        /// Error Code:		ERROR_DBError_EDITORACCESS_0005
        /// SQL Type:		INSERT
        /// </summary> 
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        Boolean insertValid = false;
        string sqlQuery = "INSERT INTO [ArticlePictures] (articleId,pictureId) VALUES" +
            " (@articleId,@pictureId);";
        //--Processing Logic--//
        //--Insert data into the database--//
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.
            ConnectionStrings[CONNECTION_STRING].ToString());
        SqlCommand queryCommand = new SqlCommand(sqlQuery, sqlConnection);
        queryCommand.Parameters.Add("@articleId", SqlDbType.Int).Value = articleId;
        queryCommand.Parameters.Add("@pictureId", SqlDbType.Int).Value = pictureId;
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
            log.SendErrors(ConstantErrors.ERROR_DBError_EDITORACCESS_0005, exception);
        }
        finally
        {
            queryCommand.Dispose();
            sqlConnection.Close();
        }
        //--Return Statement--//
        return insertValid;
    }
    public Boolean POSTArticle_ArticleVideo(int videoId, int articleId)
    {
        /// <summary>
        /// Author:			K. Bonomo
        /// Team:			OG Starters
        /// Purpose:        This method will take in two parameters 
        ///                 and establish a connection between a video 
        ///                 and an article.
        /// Parameters:     int videoId, int articleId
        /// Method Type:    Public
        /// Return Type:    Boolean
        /// Returns:        True, if insert is valid
        /// Exception:      Insert is not valid, throw exception, 
        ///                 log the error, return false
        /// Error Code:		ERROR_DBError_EDITORACCESS_0006
        /// SQL Type:		INSERT
        /// </summary> 
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        Boolean insertValid = false;
        string sqlQuery = "INSERT INTO [ArticleVideos] (articleId,videoId) VALUES" +
            " (@articleId,@videoId);";
        //--Processing Logic--//
        //--Insert data into the database--//
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.
            ConnectionStrings[CONNECTION_STRING].ToString());
        SqlCommand queryCommand = new SqlCommand(sqlQuery, sqlConnection);
        queryCommand.Parameters.Add("@articleId", SqlDbType.Int).Value = articleId;
        queryCommand.Parameters.Add("@videoId", SqlDbType.Int).Value = videoId;
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
            log.SendErrors(ConstantErrors.ERROR_DBError_EDITORACCESS_0006, exception);
        }
        finally
        {
            queryCommand.Dispose();
            sqlConnection.Close();
        }
        //--Return Statement--//
        return insertValid;
    }
    public Boolean POSTArticle_ArticleSummary(int articleId, string articleSummary)
    {
        /// <summary>
        /// Author:			K. Bonomo
        /// Team:			OG Starters
        /// Purpose:        This method will connect the article 
        ///                 summary to the article to display on
        ///                 the article summary card.
        /// Parameters:     int articleId, string articleSummary
        /// Method Type:    Public
        /// Return Type:    Boolean
        /// Returns:        True, if insert is valid
        /// Exception:      Insert is not valid, throw exception, 
        ///                 log the error, return false
        /// Error Code:		ERROR_DBError_EDITORACCESS_0020
        /// SQL Type:		INSERT
        /// </summary> 
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        Boolean insertValid = false;
        string sqlQuery = "INSERT INTO [ArticleSummary] (articleId,articleSummary) VALUES" +
            " (@articleId,@articleSummary);";
        //--Processing Logic--//
        //--Insert data into the database--//
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.
            ConnectionStrings[CONNECTION_STRING].ToString());
        SqlCommand queryCommand = new SqlCommand(sqlQuery, sqlConnection);
        queryCommand.Parameters.Add("@articleId", SqlDbType.Int).Value = articleId;
        queryCommand.Parameters.Add("@articleSummary", SqlDbType.VarChar).Value = articleSummary;
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
            log.SendErrors(ConstantErrors.ERROR_DBError_EDITORACCESS_0020, exception);
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