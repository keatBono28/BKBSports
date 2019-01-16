using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// POSTEditorDatbase
/// Author:         K. Bonomo
/// Created:        01-06-2019
/// Updated:        01-06-2019
/// Purpose:        This class services requests to the 
///                 database that will insert data based 
///                 on information passed in.
/// Documentation:  Can be found in BKBSports Runbook.
///            
/// </summary>
public class POSTEditorDatbase
{
    //--Objects & Classes--//
    DatabaseConnectionSecurity databaseConnectionSecurity = new DatabaseConnectionSecurity();
    LogErrors log = new LogErrors();
    ConstantErrors errorCode = new ConstantErrors();
    //--Methods--//
    public Boolean POSTArtilce_Article(string articleTitle, int userId,string articleParaOne, string articleParaTwo, string articleParaThree, string articleParaFour, string articleParaFive,
        string articleParaSix, string articleParaSeven, string articleParaEight, string articleParaNine)
    {
        /// <summary>
        /// Purpose:        This method will take eleven parameters and 
        ///                 inserts a new article into the database.
        /// Parameters:     userId, title, createDate, maintenance
        ///                 paragraphs 1-9
        /// Returns:        true
        /// Exception:      If insert failed, return false
        /// Method Type:    Public
        /// Return Type:    Boolean
        /// </summary>
        /// 
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        Boolean insertValid = false;
        string sqlQuery = "INSERT INTO [Article] (articleTitle,articleCreateDate,articleMaintenance," +
        "userId,articleParaOne,articleParaTwo,articleParaThree,articleParaFour,articleParaFive," +
        "articleParaSix,articleParaSeven,articleParaEight,articleParaNine) VALUES " +
        "(@articleTitle,@articleCreateDate,@articleMaintenance,@userId,@articleParaOne," +
        "@articleParaTwo,@articleParaThree,@articleParaFour,@articleParaFive,@articleParaSix," +
        "@articleParaSeven,@articleParaEight,@articleParaNine);";
        //--Processing logic--//

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
        return insertValid;
    }
    public Boolean POSTArticle_Picture(string filePath, int sourceId)
    {
        /// <summary>
        /// Purpose:        This method will take two parameters and 
        ///                 inserts a new picture into the database.
        /// Parameters:     filePath, sourceId
        /// Returns:        true
        /// Exception:      If insert failed, return false
        /// Method Type:    Public
        /// Return Type:    Boolean
        /// </summary>
        /// 
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        Boolean insertValid = false;
        string sqlQuery = "INSERT INTO [Pictures] (filePath,pictureAddedDate,sourceId) VALUES" +
            " (@filePath,@pictureAddedDate,@sourceId);";
        //--Processing logic--//

        //--Insert data into the database--//
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
        return insertValid;

    }
    public Boolean POSTArticle_Video(string filePath, int sourceId)
    {
        /// <summary>
        /// Purpose:        This method will take two parameters and 
        ///                 inserts a new picture into the database.
        /// Parameters:     filePath, sourceId
        /// Returns:        true
        /// Exception:      If insert failed, return false
        /// Method Type:    Public
        /// Return Type:    Boolean
        /// </summary>
        /// 
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        Boolean insertValid = false;
        string sqlQuery = "INSERT INTO [Videos] (filePath,pictureAddedDate,sourceId) VALUES" +
            " (@filePath,@pictureAddedDate,@sourceId);";
        //--Processing logic--//
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
        return insertValid;

    }
    public Boolean POSTArticle_Source(string sourceName, string sourceURL)
    {
        /// <summary>
        /// Purpose:        This method will take two parameters and 
        ///                 inserts a new media source into the database.
        /// Parameters:     sourceName, sourceURL
        /// Returns:        true
        /// Exception:      If insert failed, return false
        /// Method Type:    Public
        /// Return Type:    Boolean
        /// </summary>
        /// 
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        Boolean insertValid = false;
        string sqlQuery = "INSERT INTO [Source] (sourceName,sourceURL) VALUES" +
            " (@sourceName,@sourceURL);";
        //--Processing logic--//
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
        return insertValid;
    }
    public Boolean POSTArticle_ArticlePicture(int pictureId, int articleId)
    {
        /// <summary>
        /// Purpose:        This method will take two parameters and 
        ///                 inserts a new connection between a picture
        ///                 and a article into the database.
        /// Parameters:     pictureId, articleId
        /// Returns:        true
        /// Exception:      If insert failed, return false
        /// Method Type:    Public
        /// Return Type:    Boolean
        /// </summary>
        /// 
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        Boolean insertValid = false;
        string sqlQuery = "INSERT INTO [ArticlePictures] (articleId,pictureId) VALUES" +
            " (@articleId,@pictureId);";
        //--Processing logic--//
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
        return insertValid;
    }
    public Boolean POSTArticle_ArticleVideo(int videoId, int articleId)
    {
        /// <summary>
        /// Purpose:        This method will take two parameters and 
        ///                 inserts a new connection between a video
        ///                 and a article into the database.
        /// Parameters:     videoId, articleId
        /// Returns:        true
        /// Exception:      If insert failed, return false
        /// Method Type:    Public
        /// Return Type:    Boolean
        /// </summary>
        /// 
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        Boolean insertValid = false;
        string sqlQuery = "INSERT INTO [ArticleVideos] (articleId,videoId) VALUES" +
            " (@articleId,@videoId);";
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
        return insertValid;
    }

}