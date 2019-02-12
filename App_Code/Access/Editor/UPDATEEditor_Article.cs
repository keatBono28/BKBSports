using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// UPDATEEditor_Article.cs
/// 
/// Author:         K. Bonomo
/// Team:			OG Starters
/// Created:        01-08-2019
/// Updated:        01-22-2019
/// Purpose:        This class will service requests to 
///                 update data that is in the article 
///                 information tables within the entire 
///                 database.  
/// Package:		BKBSports.App_Code.Access.Editor
/// Classes:		-DatabaseConnectionSecurity.cs
///                 -LogErrors.cs
///                 -ConstantErrors.cs
///	Lines:			589
/// Docs:  			https://bkbsportsanalytics.atlassian.net/wiki/spaces/BW/pages/1933391/UPDATEEditor+Article.cs
/// </summary>
public class UPDATEEditor_Article
{
    //--Objects & Classes--//
    DatabaseConnectionSecurity databaseConnectionSecurity = new DatabaseConnectionSecurity();
    LogErrors log = new LogErrors();
    ConstantErrors errorCode = new ConstantErrors();
    //--Update Methods--//
    public Boolean UPDATE_Article_ParaOne(int articleId, int userId, string articleParaOne)
    {
        /// <summary>
        /// Author:			K. Bonomo
        /// Team:			OG Starters
        /// Purpose:        This method will take three parameters 
        ///                 and update the article paragraph one
        ///                 based on the given articleId and userId
        /// Parameters:     int articleId, int userId, string articleParaOne
        /// Method Type:    Public
        /// Return Type:    Boolean
        /// Returns:        True, if insert is valid
        /// Exception:      Insert is not valid, throw exception, 
        ///                 log the error, return false
        /// Error Code:		ERROR_DBError_EDITORACCESS_0010
        /// SQL Type:		UPDATE
        /// </summary>
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "UPDATE [Articles] set articleParaOne=@articleParaOne" +
            " WHERE articleId=@articleId AND userId=@userId";
        Boolean updateValid = false;
        //--Processing Logic--//
        //--Update Data with Database--//
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.
            ConnectionStrings[CONNECTION_STRING].ToString());
        SqlCommand queryCommand = new SqlCommand(sqlQuery, sqlConnection);
        queryCommand.Parameters.Add("@userId", SqlDbType.Int).Value = userId;
        queryCommand.Parameters.Add("@articleId", SqlDbType.Int).Value = articleId;
        queryCommand.Parameters.Add("@articleParaOne", SqlDbType.Text).Value = articleParaOne;
        try
        {
            sqlConnection.Open();
            if (queryCommand.ExecuteNonQuery() > 0)
            {
                updateValid = true;
                Boolean UpdateMaintenance = UPDATE_Article_Maintenance(articleId);
            }
        }
        catch (Exception exception)
        {
            log.SendErrors(ConstantErrors.ERROR_DBError_EDITORACCESS_0010, exception);
        }
        finally
        {
            queryCommand.Dispose();
            sqlConnection.Close();
        }
        //--Return Statement--//
        return updateValid;
    }
    public Boolean UPDATE_Article_ParaTwo(int articleId, int userId, string articleParaTwo)
    {
        /// <summary>
        /// Author:			K. Bonomo
        /// Team:			OG Starters
        /// Purpose:        This method will take three parameters 
        ///                 and update the article paragraph two
        ///                 based on the given articleId and userId
        /// Parameters:     int articleId, int userId, string articleParaTwo
        /// Method Type:    Public
        /// Return Type:    Boolean
        /// Returns:        True, if insert is valid
        /// Exception:      Insert is not valid, throw exception, 
        ///                 log the error, return false
        /// Error Code:		ERROR_DBError_EDITORACCESS_0011
        /// SQL Type:		UPDATE
        /// </summary>
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "UPDATE [Articles] set articleParaTwo=@articleParaTwo" +
            " WHERE articleId=@articleId AND userId=@userId";
        Boolean updateValid = false;
        //--Processing Logic--//
        //--Update Data with Database--//
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.
            ConnectionStrings[CONNECTION_STRING].ToString());
        SqlCommand queryCommand = new SqlCommand(sqlQuery, sqlConnection);
        queryCommand.Parameters.Add("@userId", SqlDbType.Int).Value = userId;
        queryCommand.Parameters.Add("@articleId", SqlDbType.Int).Value = articleId;
        queryCommand.Parameters.Add("@articleParaTwo", SqlDbType.Text).Value = articleParaTwo;
        try
        {
            sqlConnection.Open();
            if (queryCommand.ExecuteNonQuery() > 0)
            {
                updateValid = true;
                Boolean UpdateMaintenance = UPDATE_Article_Maintenance(articleId);
            }
        }
        catch (Exception exception)
        {
            log.SendErrors(ConstantErrors.ERROR_DBError_EDITORACCESS_0011, exception);
        }
        finally
        {
            queryCommand.Dispose();
            sqlConnection.Close();
        }
        //--Return Statement--//
        return updateValid;
    }
    public Boolean UPDATE_Article_ParaThree(int articleId, int userId, string articleParaThree)
    {
        /// <summary>
        /// Author:			K. Bonomo
        /// Team:			OG Starters
        /// Purpose:        This method will take three parameters 
        ///                 and update the article paragraph three
        ///                 based on the given articleId and userId
        /// Parameters:     int articleId, int userId, string articleParaThree
        /// Method Type:    Public
        /// Return Type:    Boolean
        /// Returns:        True, if insert is valid
        /// Exception:      Insert is not valid, throw exception, 
        ///                 log the error, return false
        /// Error Code:		ERROR_DBError_EDITORACCESS_0012
        /// SQL Type:		UPDATE
        /// </summary>
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "UPDATE [Articles] set articleParaThree=@articleParaThree" +
            " WHERE articleId=@articleId AND userId=@userId";
        Boolean updateValid = false;
        //--Processing Logic--//
        //--Update Data with Database--//
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.
            ConnectionStrings[CONNECTION_STRING].ToString());
        SqlCommand queryCommand = new SqlCommand(sqlQuery, sqlConnection);
        queryCommand.Parameters.Add("@userId", SqlDbType.Int).Value = userId;
        queryCommand.Parameters.Add("@articleId", SqlDbType.Int).Value = articleId;
        queryCommand.Parameters.Add("@articleParaThree", SqlDbType.Text).Value = articleParaThree;
        try
        {
            sqlConnection.Open();
            if (queryCommand.ExecuteNonQuery() > 0)
            {
                updateValid = true;
                Boolean UpdateMaintenance = UPDATE_Article_Maintenance(articleId);
            }
        }
        catch (Exception exception)
        {
            log.SendErrors(ConstantErrors.ERROR_DBError_EDITORACCESS_0012, exception);
        }
        finally
        {
            queryCommand.Dispose();
            sqlConnection.Close();
        }
        //--Return Statement--//
        return updateValid;
    }
    public Boolean UPDATE_Article_ParaFour(int articleId, int userId, string articleParaFour)
    {
        /// <summary>
        /// Author:			K. Bonomo
        /// Team:			OG Starters
        /// Purpose:        This method will take three parameters 
        ///                 and update the article paragraph four
        ///                 based on the given articleId and userId
        /// Parameters:     int articleId, int userId, string articleParaFour
        /// Method Type:    Public
        /// Return Type:    Boolean
        /// Returns:        True, if insert is valid
        /// Exception:      Insert is not valid, throw exception, 
        ///                 log the error, return false
        /// Error Code:		ERROR_DBError_EDITORACCESS_0013
        /// SQL Type:		UPDATE
        /// </summary>
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "UPDATE [Articles] set articleParaFour=@articleParaFour" +
            " WHERE articleId=@articleId AND userId=@userId";
        Boolean updateValid = false;
        //--Processing Logic--//
        //--Update Data with Database--//
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.
            ConnectionStrings[CONNECTION_STRING].ToString());
        SqlCommand queryCommand = new SqlCommand(sqlQuery, sqlConnection);
        queryCommand.Parameters.Add("@userId", SqlDbType.Int).Value = userId;
        queryCommand.Parameters.Add("@articleId", SqlDbType.Int).Value = articleId;
        queryCommand.Parameters.Add("@articleParaFour", SqlDbType.Text).Value = articleParaFour;
        try
        {
            sqlConnection.Open();
            if (queryCommand.ExecuteNonQuery() > 0)
            {
                updateValid = true;
                Boolean UpdateMaintenance = UPDATE_Article_Maintenance(articleId);
            }
        }
        catch (Exception exception)
        {
            log.SendErrors(ConstantErrors.ERROR_DBError_EDITORACCESS_0013, exception);
        }
        finally
        {
            queryCommand.Dispose();
            sqlConnection.Close();
        }
        //--Return Statement--//
        return updateValid;
    }
    public Boolean UPDATE_Article_ParaFive(int articleId, int userId, string articleParaFive)
    {
        /// <summary>
        /// Author:			K. Bonomo
        /// Team:			OG Starters
        /// Purpose:        This method will take three parameters 
        ///                 and update the article paragraph five
        ///                 based on the given articleId and userId
        /// Parameters:     int articleId, int userId, string articleParaFive
        /// Method Type:    Public
        /// Return Type:    Boolean
        /// Returns:        True, if insert is valid
        /// Exception:      Insert is not valid, throw exception, 
        ///                 log the error, return false
        /// Error Code:		ERROR_DBError_EDITORACCESS_0014
        /// SQL Type:		UPDATE
        /// </summary>
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "UPDATE [Articles] set articleParaFive=@articleParaFive" +
            " WHERE articleId=@articleId AND userId=@userId";
        Boolean updateValid = false;
        //--Processing Logic--//
        //--Update Data with Database--//
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.
            ConnectionStrings[CONNECTION_STRING].ToString());
        SqlCommand queryCommand = new SqlCommand(sqlQuery, sqlConnection);
        queryCommand.Parameters.Add("@userId", SqlDbType.Int).Value = userId;
        queryCommand.Parameters.Add("@articleId", SqlDbType.Int).Value = articleId;
        queryCommand.Parameters.Add("@articleParaFive", SqlDbType.Text).Value = articleParaFive;
        try
        {
            sqlConnection.Open();
            if (queryCommand.ExecuteNonQuery() > 0)
            {
                updateValid = true;
                Boolean UpdateMaintenance = UPDATE_Article_Maintenance(articleId);
            }
        }
        catch (Exception exception)
        {
            log.SendErrors(ConstantErrors.ERROR_DBError_EDITORACCESS_0014, exception);
        }
        finally
        {
            queryCommand.Dispose();
            sqlConnection.Close();
        }
        //--Return Statement--//
        return updateValid;
    }
    public Boolean UPDATE_Article_ParaSix(int articleId, int userId, string articleParaSix)
    {
        /// <summary>
        /// Author:			K. Bonomo
        /// Team:			OG Starters
        /// Purpose:        This method will take three parameters 
        ///                 and update the article paragraph six 
        ///                 based on the given articleId and userId
        /// Parameters:     int articleId, int userId, string articleParaSix
        /// Method Type:    Public
        /// Return Type:    Boolean
        /// Returns:        True, if insert is valid
        /// Exception:      Insert is not valid, throw exception, 
        ///                 log the error, return false
        /// Error Code:		ERROR_DBError_EDITORACCESS_0015
        /// SQL Type:		UPDATE
        /// </summary> 
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "UPDATE [Articles] set articleParaSix=@articleParaSix" +
            " WHERE articleId=@articleId AND userId=@userId";
        Boolean updateValid = false;
        //--Processing Logic--//
        //--Update Data with Database--//
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.
            ConnectionStrings[CONNECTION_STRING].ToString());
        SqlCommand queryCommand = new SqlCommand(sqlQuery, sqlConnection);
        queryCommand.Parameters.Add("@userId", SqlDbType.Int).Value = userId;
        queryCommand.Parameters.Add("@articleId", SqlDbType.Int).Value = articleId;
        queryCommand.Parameters.Add("@articleParaSix", SqlDbType.Text).Value = articleParaSix;
        try
        {
            sqlConnection.Open();
            if (queryCommand.ExecuteNonQuery() > 0)
            {
                updateValid = true;
                Boolean UpdateMaintenance = UPDATE_Article_Maintenance(articleId);
            }
        }
        catch (Exception exception)
        {
            log.SendErrors(ConstantErrors.ERROR_DBError_EDITORACCESS_0015, exception);
        }
        finally
        {
            queryCommand.Dispose();
            sqlConnection.Close();
        }
        //--Return Statement--//
        return updateValid;
    }
    public Boolean UPDATE_Article_ParaSeven(int articleId, int userId, string articleParaSeven)
    { 
        /// <summary>
        /// Author:			K. Bonomo
        /// Team:			OG Starters
        /// Purpose:        This method will take three parameters 
        ///                 and update the article paragraph seven 
        ///                 based on the given articleId and userId
        /// Parameters:     int articleId, int userId, string articleParaSeven
        /// Method Type:    Public
        /// Return Type:    Boolean
        /// Returns:        True, if insert is valid
        /// Exception:      Insert is not valid, throw exception, 
        ///                 log the error, return false
        /// Error Code:		ERROR_DBError_EDITORACCESS_0016
        /// SQL Type:		UPDATE
        /// </summary> 
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "UPDATE [Articles] set articleParaSeven=@articleParaSeven" +
            " WHERE articleId=@articleId AND userId=@userId";
        Boolean updateValid = false;
        //--Processing Logic--//
        //--Update Data with Database--//
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.
            ConnectionStrings[CONNECTION_STRING].ToString());
        SqlCommand queryCommand = new SqlCommand(sqlQuery, sqlConnection);
        queryCommand.Parameters.Add("@userId", SqlDbType.Int).Value = userId;
        queryCommand.Parameters.Add("@articleId", SqlDbType.Int).Value = articleId;
        queryCommand.Parameters.Add("@articleParaSeven", SqlDbType.Text).Value = articleParaSeven;
        try
        {
            sqlConnection.Open();
            if (queryCommand.ExecuteNonQuery() > 0)
            {
                updateValid = true;
                Boolean UpdateMaintenance = UPDATE_Article_Maintenance(articleId);
            }
        }
        catch (Exception exception)
        {
            log.SendErrors(ConstantErrors.ERROR_DBError_EDITORACCESS_0016, exception);
        }
        finally
        {
            queryCommand.Dispose();
            sqlConnection.Close();
        }
        //--Return Statement--//
        return updateValid;
    }
    public Boolean UPDATE_Article_ParaEight(int articleId, int userId, string articleParaEight)
    {
        /// <summary>
        /// Author:			K. Bonomo
        /// Team:			OG Starters
        /// Purpose:        This method will take three parameters 
        ///                 and update the article paragraph eight 
        ///                 based on the given articleId and userId
        /// Parameters:     int articleId, int userId, string articleParaEight
        /// Method Type:    Public
        /// Return Type:    Boolean
        /// Returns:        True, if insert is valid
        /// Exception:      Insert is not valid, throw exception, 
        ///                 log the error, return false
        /// Error Code:		ERROR_DBError_EDITORACCESS_0017
        /// SQL Type:		UPDATE
        /// </summary> 
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "UPDATE [Articles] set articleParaEight=@articleParaEight" +
            " WHERE articleId=@articleId AND userId=@userId";
        Boolean updateValid = false;
        //--Processing Logic--//
        //--Update Data with Database--//
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.
            ConnectionStrings[CONNECTION_STRING].ToString());
        SqlCommand queryCommand = new SqlCommand(sqlQuery, sqlConnection);
        queryCommand.Parameters.Add("@userId", SqlDbType.Int).Value = userId;
        queryCommand.Parameters.Add("@articleId", SqlDbType.Int).Value = articleId;
        queryCommand.Parameters.Add("@articleParaEight", SqlDbType.Text).Value = articleParaEight;
        try
        {
            sqlConnection.Open();
            if (queryCommand.ExecuteNonQuery() > 0)
            {
                updateValid = true;
                Boolean UpdateMaintenance = UPDATE_Article_Maintenance(articleId);
            }
        }
        catch (Exception exception)
        {
            log.SendErrors(ConstantErrors.ERROR_DBError_EDITORACCESS_0017, exception);
        }
        finally
        {
            queryCommand.Dispose();
            sqlConnection.Close();
        }
        //--Return Statement--//
        return updateValid;
    }
    public Boolean UPDATE_Article_ParaNine(int articleId, int userId, string articleParaNine)
    {
        /// <summary>
        /// Author:			K. Bonomo
        /// Team:			OG Starters
        /// Purpose:        This method will take three parameters 
        ///                 and update the article paragraph nine 
        ///                 based on the given articleId and userId
        /// Parameters:     int articleId, int userId, string articleParaNine
        /// Method Type:    Public
        /// Return Type:    Boolean
        /// Returns:        True, if insert is valid
        /// Exception:      Insert is not valid, throw exception, 
        ///                 log the error, return false
        /// Error Code:		ERROR_DBError_EDITORACCESS_0018
        /// SQL Type:		UPDATE
        /// </summary> 
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "UPDATE [Articles] set articleParaNine=@articleParaNine" +
            " WHERE articleId=@articleId AND userId=@userId";
        Boolean updateValid = false;
        //--Processing Logic--//
        //--Update Data with Database--//
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.
            ConnectionStrings[CONNECTION_STRING].ToString());
        SqlCommand queryCommand = new SqlCommand(sqlQuery, sqlConnection);
        queryCommand.Parameters.Add("@userId", SqlDbType.Int).Value = userId;
        queryCommand.Parameters.Add("@articleId", SqlDbType.Int).Value = articleId;
        queryCommand.Parameters.Add("@articleParaNine", SqlDbType.Text).Value = articleParaNine;
        try
        {
            sqlConnection.Open();
            if (queryCommand.ExecuteNonQuery() > 0)
            {
                updateValid = true;
                Boolean UpdateMaintenance = UPDATE_Article_Maintenance(articleId);
            }
        }
        catch (Exception exception)
        {
            log.SendErrors(ConstantErrors.ERROR_DBError_EDITORACCESS_0018, exception);
        }
        finally
        {
            queryCommand.Dispose();
            sqlConnection.Close();
        }
        //--Return Statement--//
        return updateValid;
    }
    public Boolean UPDATE_Article_ArticleSummary(int articleId, string articleSummary)
    {
        /// <summary>
        /// Author:			K. Bonomo
        /// Team:			OG Starters
        /// Purpose:        This method will update the article 
        ///                 summary.
        /// Parameters:     int articleId, string articleSummary
        /// Method Type:    Public
        /// Return Type:    Boolean
        /// Returns:        True, if insert is valid
        /// Exception:      Insert is not valid, throw exception, 
        ///                 log the error, return false
        /// Error Code:		ERROR_DBError_EDITORACCESS_0021
        /// SQL Type:		UPDATE
        /// </summary> 
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        Boolean insertValid = false;
        string sqlQuery = "UPDATE [ArticleSummary] set articleSummary=@articleSummary WHERE articleId=@articleId";
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
            log.SendErrors(ConstantErrors.ERROR_DBError_EDITORACCESS_0021, exception);
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
    private Boolean UPDATE_Article_Maintenance(int articleId)
    {
        /// <summary>
        /// Author:			K. Bonomo
        /// Team:			OG Starters
        /// Purpose:        This method will take one parameter 
        ///                 and update the maintenance timestamp 
        ///                 when the article is updated
        /// Parameters:     int articleId
        /// Method Type:    Private
        /// Return Type:    Boolean
        /// Returns:        True, if insert is valid
        /// Exception:      Insert is not valid, throw exception, 
        ///                 log the error, return false
        /// Error Code:		ERROR_DBError_EDITORACCESS_0019
        /// SQL Type:		UPDATE
        /// </summary> 
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "UPDATE [Articles] set articleMaintenance=@articleMaintenance" +
            " WHERE articleId=@articleId";
        Boolean updateValid = false;
        //--Processing Logic--//
        //--Update Data with Database--//
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.
            ConnectionStrings[CONNECTION_STRING].ToString());
        SqlCommand queryCommand = new SqlCommand(sqlQuery, sqlConnection);
        queryCommand.Parameters.Add("@articleId", SqlDbType.Int).Value = articleId;
        queryCommand.Parameters.Add("@articleMaintenance", SqlDbType.DateTime).Value = DateTime.Now;
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
            log.SendErrors(ConstantErrors.ERROR_DBError_EDITORACCESS_0019, exception);
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