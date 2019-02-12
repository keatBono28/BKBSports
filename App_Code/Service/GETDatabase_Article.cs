using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// GETDatabase_Article.cs
/// 
/// Author:         K. Bonomo
/// Team:			OG Starters
/// Created:        01-09-2019
/// Updated:        02-03-2019
/// Purpose:        This class will service requests to
///					the database that will get information
///					in regards the article table set
/// Package:		BKBSports.App_Code.Service
/// Classes:		-DatabaseConnectionSecurity.cs
///                 -LogErrors.cs
///                 -ConstantErrors.cs
///                 -GETDatabaseService.cs
///	Lines:			922
/// Docs:  			https://bkbsportsanalytics.atlassian.net/wiki/spaces/BW/pages/1933397/GETDatabase+Article.cs
/// </summary>
public class GETDatabase_Article
{
    //--Objects & Classes--//
    DatabaseConnectionSecurity databaseConnectionSecurity = new DatabaseConnectionSecurity();
    LogErrors log = new LogErrors();
    ConstantErrors errorCode = new ConstantErrors();
    GETDatabaseService GETDatabase = new GETDatabaseService();
    //--Public Methods--//
    public string GETArticle_ParaOne(int articleId)
    {
		/// <summary>
		/// Author:			K. Bonomo
		/// Team:			OG Starters
		/// Purpose:        This method will take one parameter 
		///					and return the article paragraph one. 
		/// Parameters:     int articleId
		/// Method Type:    Public
		/// Return Type:    string
		/// Returns:        article paragraph one
		/// Exception:		If the paragraph is empty or null, return ""
		/// Error Code:		ERROR_DBError_SERVICE_0004
		/// SQL Type:		SELECT
		/// </summary> 
		//--Variables--//
		string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "SELECT articleParaOne FROM [Articles] WHERE " +
            "articleId=@articleId";
        string paragraph = "";
		//--Processing Logic--//
        //--Select Data from Database--//
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.
            ConnectionStrings[CONNECTION_STRING].ToString());
        SqlCommand queryCommand = new SqlCommand(sqlQuery, sqlConnection);
        queryCommand.Parameters.Add("@articleId", SqlDbType.Int).Value = articleId;
        try
        {
            sqlConnection.Open();
            SqlDataReader dbReader = queryCommand.ExecuteReader();
            while (dbReader.Read())
            {
                if (dbReader["articleParaOne"] == null || dbReader["articleParaOne"].ToString() == "")
                {
                    paragraph = "";
                }
                else
                {
                    paragraph = (dbReader["articleParaOne"].ToString());
                }
            }
            dbReader.Close();
        }
        catch (Exception exeception)
        {
            log.SendErrors(ConstantErrors.ERROR_DBError_SERVICE_0004, exeception);
        }
        finally
        {
            queryCommand.Dispose();
            sqlConnection.Close();
        }
		//--Return Statement--//
        return paragraph;
    }
    public string GETArticle_ParaTwo(int articleId)
    { 
		/// <summary>
		/// Author:			K. Bonomo
		/// Team:			OG Starters
		/// Purpose:        This method will take one parameter 
		///					and return the article paragraph two. 
		/// Parameters:     int articleId
		/// Method Type:    Public
		/// Return Type:    string
		/// Returns:        article paragraph two
		/// Exception:		If the paragraph is empty or null, return ""
		/// Error Code:		ERROR_DBError_SERVICE_0005
		/// SQL Type:		SELECT
		/// </summary> 
		//--Variables--//
		string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "SELECT articleParaTwo FROM [Articles] WHERE " +
            "articleId=@articleId";
        string paragraph = "";
		//--Processing Logic--//
        //--Select Data From Database--//
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.
            ConnectionStrings[CONNECTION_STRING].ToString());
        SqlCommand queryCommand = new SqlCommand(sqlQuery, sqlConnection);
        queryCommand.Parameters.Add("@articleId", SqlDbType.Int).Value = articleId;
        try
        {
            sqlConnection.Open();
            SqlDataReader dbReader = queryCommand.ExecuteReader();
            while (dbReader.Read())
            {
                if (dbReader["articleParaTwo"] == null || dbReader["articleParaTwo"].ToString() == "")
                {
                    paragraph = "";
                }
                else
                {
                    paragraph = (dbReader["articleParaTwo"].ToString());
                }
            }
            dbReader.Close();
        }
        catch (Exception exeception)
        {
            log.SendErrors(ConstantErrors.ERROR_DBError_SERVICE_0005, exeception);
        }
        finally
        {
            queryCommand.Dispose();
            sqlConnection.Close();
        }
		//--Return Statement--//
        return paragraph;
    }
    public string GETArticle_ParaThree(int articleId)
    {
		/// <summary>
		/// Author:			K. Bonomo
		/// Team:			OG Starters
		/// Purpose:        This method will take one parameter 
		///					and return the article paragraph three. 
		/// Parameters:     int articleId
		/// Method Type:    Public
		/// Return Type:    string
		/// Returns:        article paragraph three
		/// Exception:		If the paragraph is empty or null, return ""
		/// Error Code:		ERROR_DBError_SERVICE_0006
		/// SQL Type:		SELECT
		/// </summary> 
		//--Variables--//
		string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "SELECT articleParaThree FROM [Articles] WHERE " +
            "articleId=@articleId";
        string paragraph = "";
		//--Processing Logic--//
        //--Select Data From Database--//
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.
            ConnectionStrings[CONNECTION_STRING].ToString());
        SqlCommand queryCommand = new SqlCommand(sqlQuery, sqlConnection);
        queryCommand.Parameters.Add("@articleId", SqlDbType.Int).Value = articleId;
        try
        {
            sqlConnection.Open();
            SqlDataReader dbReader = queryCommand.ExecuteReader();
            while (dbReader.Read())
            {
                if (dbReader["articleParaThree"] == null || dbReader["articleParaThree"].ToString() == "")
                {
                    paragraph = "";
                }
                else
                {
                    paragraph = (dbReader["articleParaThree"].ToString());
                }
            }
            dbReader.Close();
        }
        catch (Exception exeception)
        {
            log.SendErrors(ConstantErrors.ERROR_DBError_SERVICE_0006, exeception);
        }
        finally
        {
            queryCommand.Dispose();
            sqlConnection.Close();
        }
		//--Return Statement--//
        return paragraph;
    }
    public string GETArticle_ParaFour(int articleId)
    {
		/// <summary>
		/// Author:			K. Bonomo
		/// Team:			OG Starters
		/// Purpose:        This method will take one parameter 
		///					and return the article paragraph four. 
		/// Parameters:     int articleId
		/// Method Type:    Public
		/// Return Type:    string
		/// Returns:        article paragraph four
		/// Exception:		If the paragraph is empty or null, return ""
		/// Error Code:		ERROR_DBError_SERVICE_0007
		/// SQL Type:		SELECT
		/// </summary>
		//--Variables--//
		string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "SELECT articleParaFour FROM [Articles] WHERE " +
            "articleId=@articleId";
        string paragraph = "";
		//--Processing Logic--//
        //--Select Data From Database--//
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.
            ConnectionStrings[CONNECTION_STRING].ToString());
        SqlCommand queryCommand = new SqlCommand(sqlQuery, sqlConnection);
        queryCommand.Parameters.Add("@articleId", SqlDbType.Int).Value = articleId;
        try
        {
            sqlConnection.Open();
            SqlDataReader dbReader = queryCommand.ExecuteReader();
            while (dbReader.Read())
            {
                if (dbReader["articleParaFour"] == null || dbReader["articleParaFour"].ToString() == "")
                {
                    paragraph = "";
                }
                else
                {
                    paragraph = (dbReader["articleParaFour"].ToString());
                }
            }
            dbReader.Close();
        }
        catch (Exception exeception)
        {
            log.SendErrors(ConstantErrors.ERROR_DBError_SERVICE_0007, exeception);
        }
        finally
        {
            queryCommand.Dispose();
            sqlConnection.Close();
        }
		//--Return Statement--//
        return paragraph;
    }
    public string GETArticle_ParaFive(int articleId)
    {
		/// <summary>
		/// Author:			K. Bonomo
		/// Team:			OG Starters
		/// Purpose:        This method will take one parameter 
		///					and return the article paragraph five. 
		/// Parameters:     int articleId
		/// Method Type:    Public
		/// Return Type:    string
		/// Returns:        article paragraph five
		/// Exception:		If the paragraph is empty or null, return ""
		/// Error Code:		ERROR_DBError_SERVICE_0008
		/// SQL Type:		SELECT
		/// </summary>
		//--Variables--//
		string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "SELECT articleParaFive FROM [Articles] WHERE " +
            "articleId=@articleId";
        string paragraph = "";
		//--Proccessing Logic--//
        //--Select Data From Database--//
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.
            ConnectionStrings[CONNECTION_STRING].ToString());
        SqlCommand queryCommand = new SqlCommand(sqlQuery, sqlConnection);
        queryCommand.Parameters.Add("@articleId", SqlDbType.Int).Value = articleId;
        try
        {
            sqlConnection.Open();
            SqlDataReader dbReader = queryCommand.ExecuteReader();
            while (dbReader.Read())
            {
                if (dbReader["articleParaFive"] == null || dbReader["articleParaFive"].ToString() == "")
                {
                    paragraph = "";
                }
                else
                {
                    paragraph = (dbReader["articleParaFive"].ToString());
                }
            }
            dbReader.Close();
        }
        catch (Exception exeception)
        {
            log.SendErrors(ConstantErrors.ERROR_DBError_SERVICE_0008, exeception);
        }
        finally
        {
            queryCommand.Dispose();
            sqlConnection.Close();
        }
		//--Return Statement--//
        return paragraph;
    }
    public string GETArticle_ParaSix(int articleId)
    { 
		/// <summary>
		/// Author:			K. Bonomo
		/// Team:			OG Starters
		/// Purpose:        This method will take one parameter 
		///					and return the article paragraph six. 
		/// Parameters:     int articleId
		/// Method Type:    Public
		/// Return Type:    string
		/// Returns:        article paragraph six
		/// Exception:		If the paragraph is empty or null, return ""
		/// Error Code:		ERROR_DBError_SERVICE_0009
		/// SQL Type:		SELECT
		/// </summary>
		//--Variables--//
		string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "SELECT articleParaSix FROM [Articles] WHERE " +
            "articleId=@articleId";
        string paragraph = "";
		//--Proccessing Logic--//
        //--Select Data From Database--//
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.
            ConnectionStrings[CONNECTION_STRING].ToString());
        SqlCommand queryCommand = new SqlCommand(sqlQuery, sqlConnection);
        queryCommand.Parameters.Add("@articleId", SqlDbType.Int).Value = articleId;
        try
        {
            sqlConnection.Open();
            SqlDataReader dbReader = queryCommand.ExecuteReader();
            while (dbReader.Read())
            {
                if (dbReader["articleParaSix"] == null || dbReader["articleParaSix"].ToString() == "")
                {
                    paragraph = "";
                }
                else
                {
                    paragraph = (dbReader["articleParaSix"].ToString());
                }
            }
            dbReader.Close();
        }
        catch (Exception exeception)
        {
            log.SendErrors(ConstantErrors.ERROR_DBError_SERVICE_0009, exeception);
        }
        finally
        {
            queryCommand.Dispose();
            sqlConnection.Close();
        }
		//--Return Statement--//
        return paragraph;
    }
    public string GETArticle_ParaSeven(int articleId)
    {
		/// <summary>
		/// Author:			K. Bonomo
		/// Team:			OG Starters
		/// Purpose:        This method will take one parameter 
		///					and return the article paragraph seven. 
		/// Parameters:     int articleId
		/// Method Type:    Public
		/// Return Type:    string
		/// Returns:        article paragraph seven
		/// Exception:		If the paragraph is empty or null, return ""
		/// Error Code:		ERROR_DBError_SERVICE_0010
		/// SQL Type:		SELECT
		/// </summary>
		//--Variables--//
		string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "SELECT articleParaSeven FROM [Articles] WHERE " +
            "articleId=@articleId";
        string paragraph = "";
		//--Processing Logic--//
        //--Select Data From Database--//
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.
            ConnectionStrings[CONNECTION_STRING].ToString());
        SqlCommand queryCommand = new SqlCommand(sqlQuery, sqlConnection);
        queryCommand.Parameters.Add("@articleId", SqlDbType.Int).Value = articleId;
        try
        {
            sqlConnection.Open();
            SqlDataReader dbReader = queryCommand.ExecuteReader();
            while (dbReader.Read())
            {
                if (dbReader["articleParaSeven"] == null || dbReader["articleParaSeven"].ToString() == "")
                {
                    paragraph = "";
                }
                else
                {
                    paragraph = (dbReader["articleParaSeven"].ToString());
                }
            }
            dbReader.Close();
        }
        catch (Exception exeception)
        {
            log.SendErrors(ConstantErrors.ERROR_DBError_SERVICE_0010, exeception);
        }
        finally
        {
            queryCommand.Dispose();
            sqlConnection.Close();
        }
		//--Return Statement--//
        return paragraph;
    }
    public string GETArticle_ParaEight(int articleId)
    {
		/// <summary>
		/// Author:			K. Bonomo
		/// Team:			OG Starters
		/// Purpose:        This method will take one parameter 
		///					and return the article paragraph eight. 
		/// Parameters:     int articleId
		/// Method Type:    Public
		/// Return Type:    string
		/// Returns:        article paragraph eight
		/// Exception:		If the paragraph is empty or null, return ""
		/// Error Code:		ERROR_DBError_SERVICE_0011
		/// SQL Type:		SELECT
		/// </summary>
		//--Variables--//
		string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "SELECT articleParaEight FROM [Articles] WHERE " +
            "articleId=@articleId";
        string paragraph = "";
		//--Processing Logic--//
        //--Select Data From Database--//
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.
            ConnectionStrings[CONNECTION_STRING].ToString());
        SqlCommand queryCommand = new SqlCommand(sqlQuery, sqlConnection);
        queryCommand.Parameters.Add("@articleId", SqlDbType.Int).Value = articleId;
        try
        {
            sqlConnection.Open();
            SqlDataReader dbReader = queryCommand.ExecuteReader();
            while (dbReader.Read())
            {
                if (dbReader["articleParaEight"] == null || dbReader["articleParaEight"].ToString() == "")
                {
                    paragraph = "";
                }
                else
                {
                    paragraph = (dbReader["articleParaEight"].ToString());
                }
            }
            dbReader.Close();
        }
        catch (Exception exeception)
        {
            log.SendErrors(ConstantErrors.ERROR_DBError_SERVICE_0011, exeception);
        }
        finally
        {
            queryCommand.Dispose();
            sqlConnection.Close();
        }
		//--Return Statement--//
        return paragraph;
    }
    public string GETArticle_ParaNine(int articleId)
    {
		/// <summary>
		/// Author:			K. Bonomo
		/// Team:			OG Starters
		/// Purpose:        This method will take one parameter 
		///					and return the article paragraph nine. 
		/// Parameters:     int articleId
		/// Method Type:    Public
		/// Return Type:    string
		/// Returns:        article paragraph nine
		/// Exception:		If the paragraph is empty or null, return ""
		/// Error Code:		ERROR_DBError_SERVICE_0012
		/// SQL Type:		SELECT
		/// </summary>
		//--Variables--//
		string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "SELECT articleParaNine FROM [Articles] WHERE " +
            "articleId=@articleId";
        string paragraph = "";
		//--Processing Logic--//
        //--Select Data From Database--//
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.
            ConnectionStrings[CONNECTION_STRING].ToString());
        SqlCommand queryCommand = new SqlCommand(sqlQuery, sqlConnection);
        queryCommand.Parameters.Add("@articleId", SqlDbType.Int).Value = articleId;
        try
        {
            sqlConnection.Open();
            SqlDataReader dbReader = queryCommand.ExecuteReader();
            while (dbReader.Read())
            {
                if (dbReader["articleParaNine"] == null || dbReader["articleParaNine"].ToString() == "")
                {
                    paragraph = "";
                }
                else
                {
                    paragraph = (dbReader["articleParaNine"].ToString());
                }
            }
            dbReader.Close();
        }
        catch (Exception exeception)
        {
            log.SendErrors(ConstantErrors.ERROR_DBError_SERVICE_0012, exeception);
        }
        finally
        {
            queryCommand.Dispose();
            sqlConnection.Close();
        }
		//--Return Statement--//
        return paragraph;
    }
    public string GETArticle_Title(int articleId)
    {
		/// <summary>
		/// Author:			K. Bonomo
		/// Team:			OG Starters
		/// Purpose:        This method will take one parameter 
		///					and return the article title. 
		/// Parameters:     int articleId
		/// Method Type:    Public
		/// Return Type:    string
		/// Returns:        article title
		/// Exception:		If the title is empty or null, return ""
		/// Error Code:		ERROR_DBError_SERVICE_0015
		/// SQL Type:		SELECT
		/// </summary>
		//--Variables--//
		string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "SELECT articleTitle FROM [Articles] WHERE " +
            "articleId=@articleId";
        string title = "";
		//--Processing Logic--//
        //--Select Data From Database--//
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.
            ConnectionStrings[CONNECTION_STRING].ToString());
        SqlCommand queryCommand = new SqlCommand(sqlQuery, sqlConnection);
        queryCommand.Parameters.Add("@articleId", SqlDbType.Int).Value = articleId;
        try
        {
            sqlConnection.Open();
            SqlDataReader dbReader = queryCommand.ExecuteReader();
            while (dbReader.Read())
            {
                if (dbReader["articleTitle"] == null || dbReader["articleTitle"].ToString() == "")
                {
                    title = "";
                }
                else
                {
                    title = (dbReader["articleTitle"].ToString());
                }
            }
            dbReader.Close();
        }
        catch (Exception exeception)
        {
            log.SendErrors(ConstantErrors.ERROR_DBError_SERVICE_0015, exeception);
        }
        finally
        {
            queryCommand.Dispose();
            sqlConnection.Close();
        }
		//--Return Statement--//
        return title;
    }
    public int GETArticleId()
    {
		/// <summary>
		/// Author:			K. Bonomo
		/// Team:			OG Starters
		/// Purpose:        This method will return the most
		///					recent articleId based on creation
		///					date.
		/// Parameters:     int articleId
		/// Method Type:    Public
		/// Return Type:    Int
		/// Returns:        articleId
		/// Exception:		Connection issue with database
		/// Error Code:		ERROR_DBError_SERVICE_0016
		/// SQL Type:		SELECT
		/// </summary>
		//--Variables--//
		string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQueryOne = "SELECT articleId " +
            "FROM [Articles] " +
            "WHERE (articleCreateDate=";
        string sqlQueryTwo = "(SELECT MAX(articleCreateDate) AS recentDate " +
            "FROM [Articles] AS Articles_1))";
        string sqlQuery = sqlQueryOne + sqlQueryTwo;
        int articleId = 0;
		//--Processing Logic--//
        //--Select Data From Database--//
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.
            ConnectionStrings[CONNECTION_STRING].ToString());
        SqlCommand queryCommand = new SqlCommand(sqlQuery, sqlConnection);
        try
        {
            sqlConnection.Open();
            SqlDataReader dbReader = queryCommand.ExecuteReader();
            while (dbReader.Read())
            {
                articleId = Convert.ToInt32(dbReader["articleId"]);
            }
            dbReader.Close();
        }
        catch (Exception exeception)
        {
            log.SendErrors(ConstantErrors.ERROR_DBError_SERVICE_0016, exeception);
        }
        finally
        {
            queryCommand.Dispose();
            sqlConnection.Close();
        }
		//--Return Statement--//
        return articleId;
    }
    public string GETArticle_Author(int articleId)
    {
		/// <summary>
		/// Author:			K. Bonomo
		/// Team:			OG Starters
		/// Purpose:        This method will take one
		///					parameter and return the authors
		///					full name
		/// Parameters:     int articleId
		/// Method Type:    Public
		/// Return Type:    string
		/// Returns:        articleId
		/// Exception:		The authors name is not in the system, 
		///					return "Joe Smith"
		/// Error Code:		ERROR_DBError_SERVICE_0017
		/// SQL Type:		SELECT
		/// </summary>
		//--Variables--//
		string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "SELECT userId FROM [Articles] WHERE " +
            "articleId=@articleId";
        int userId = 0;
        string authorsName = "";
		//--Processing Logic--//
        //--Select Data From Database--//
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.
            ConnectionStrings[CONNECTION_STRING].ToString());
        SqlCommand queryCommand = new SqlCommand(sqlQuery, sqlConnection);
        queryCommand.Parameters.Add("@articleId", SqlDbType.Int).Value = articleId;
        try
        {
            sqlConnection.Open();
            SqlDataReader dbReader = queryCommand.ExecuteReader();
            while (dbReader.Read())
            {
                userId = Convert.ToInt32(dbReader["userId"]);
            }
            dbReader.Close();
        }
        catch (Exception exeception)
        {
            log.SendErrors(ConstantErrors.ERROR_DBError_SERVICE_0017, exeception);
        }
        finally
        {
            queryCommand.Dispose();
            sqlConnection.Close();
        }
        //--Processing Logic--//
        try
        {
            authorsName = GETDatabase.GETUserFullName(userId);
        }
        catch (Exception exeception)
        {
            log.SendErrors(ConstantErrors.ERROR_DBError_SERVICE_0017, exeception);
            authorsName = "Joe Smith";
        }
        //--Return Statement--//
        return authorsName;
    }
    public string GETArticle_CreateDate(int articleId)
    {
		/// <summary>
		/// Author:			K. Bonomo
		/// Team:			OG Starters
		/// Purpose:        This method will take one parameter
		///					and return the articles create date
		/// Parameters:     int articleId
		/// Method Type:    Public
		/// Return Type:    String
		/// Returns:        articleId
		/// Exception:		Databse failed to connect
		/// Error Code:		ERROR_DBError_SERVICE_0018
		/// SQL Type:		SELECT
		/// </summary>
		//--Variables--//
		string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "SELECT articleCreateDate FROM [Articles] WHERE " +
            "articleId=@articleId";
        string date = "";
		//--Processing Logic--//
        //--Select Data From Database--//
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.
            ConnectionStrings[CONNECTION_STRING].ToString());
        SqlCommand queryCommand = new SqlCommand(sqlQuery, sqlConnection);
        queryCommand.Parameters.Add("@articleId", SqlDbType.Int).Value = articleId;
        try
        {
            sqlConnection.Open();
            SqlDataReader dbReader = queryCommand.ExecuteReader();
            while (dbReader.Read())
            {
                date = dbReader["articleCreateDate"].ToString();
            }
            dbReader.Close();
        }
        catch (Exception exeception)
        {
            log.SendErrors(ConstantErrors.ERROR_DBError_SERVICE_0018, exeception);
        }
        finally
        {
            queryCommand.Dispose();
            sqlConnection.Close();
        }
        date = string.Format("{0:d}", date);
		//--Return Statement--//
        return date;
    }
	public string GETArticle_LikesAndCommentDetials(int articleId)
	{
		/// <summary>
		/// Author:			K. Bonomo
		/// Team:			OG Starters
		/// Purpose:		This method will take one parameter 
		///					and format the string to display the 
		///					number of comments and likes for a 
		///					given article.
		/// Parameters:     int articleId
		/// Method Type:    Public
		/// Return Type:    String
		/// Returns:        articleId
		/// Exception:		
		/// Error Code:		
		/// SQL Type:		
		/// </summary>
		/// //--Return Statement--//
		return GETArticle_LikeCount(articleId) + " | " + GETArticle_CommentCount(articleId);
	}
	public string GETArticle_ArticleSummary(int articleId)
	{
		/// <summary>
		/// Author:			K. Bonomo
		/// Team:			OG Starters
		/// Purpose:        This method will take one parameter
		///					and return the article summary
		/// Parameters:     int articleId
		/// Method Type:    Public
		/// Return Type:    String
		/// Returns:        articleId
		/// Exception:		Databse failed to connect
		/// Error Code:		ERROR_DBError_SERVICE_0021
		/// SQL Type:		SELECT
		/// </summary>
		//--Variables--//
		string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
		string sqlQuery = "SELECT articleSummary FROM [ArticleSummary] WHERE " +
			"articleId=@articleId";
		string summary = "";
		//--Processing Logic--//
		//--Select Data From Database--//
		SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.
			ConnectionStrings[CONNECTION_STRING].ToString());
		SqlCommand queryCommand = new SqlCommand(sqlQuery, sqlConnection);
		queryCommand.Parameters.Add("@articleId", SqlDbType.Int).Value = articleId;
		try
		{
			sqlConnection.Open();
			SqlDataReader dbReader = queryCommand.ExecuteReader();
			while (dbReader.Read())
			{
				summary = dbReader["articleSummary"].ToString();
			}
			dbReader.Close();
		}
		catch (Exception exeception)
		{
			log.SendErrors(ConstantErrors.ERROR_DBError_SERVICE_0021, exeception);
		}
		finally
		{
			queryCommand.Dispose();
			sqlConnection.Close();
		}
		//--Return Statement--//
		return summary;
	}
	public string GETArticle_ArticleFlag(int articleId)
	{
		/// <summary>
		/// Author:			K. Bonomo
		/// Team:			OG Starters
		/// Purpose:        This method will take one parameter
		///					and return the article flag type
		/// Parameters:     int articleId
		/// Method Type:    Public
		/// Return Type:    String
		/// Returns:        articleId
		/// Exception:		Databse failed to connect
		/// Error Code:		ERROR_DBError_SERVICE_0022
		/// SQL Type:		SELECT
		/// </summary>
		//--Variables--//
		string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
		string sqlQuery = "SELECT articleFlag FROM [Articles] WHERE " +
			"articleId=@articleId";
		string flag = "";
		//--Processing Logic--//
		//--Select Data From Database--//
		SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.
			ConnectionStrings[CONNECTION_STRING].ToString());
		SqlCommand queryCommand = new SqlCommand(sqlQuery, sqlConnection);
		queryCommand.Parameters.Add("@articleId", SqlDbType.Int).Value = articleId;
		try
		{
			sqlConnection.Open();
			SqlDataReader dbReader = queryCommand.ExecuteReader();
			while (dbReader.Read())
			{
				flag = dbReader["articleFlag"].ToString();
			}
			dbReader.Close();
		}
		catch (Exception exeception)
		{
			log.SendErrors(ConstantErrors.ERROR_DBError_SERVICE_0021, exeception); // needs changed
		}
		finally
		{
			queryCommand.Dispose();
			sqlConnection.Close();
		}
		//--Return Statement--//
		return flag;
	}
	//--Private Methods--//
	private string GETArticle_LikeCount(int articleId)
	{
		/// <summary>
		/// Author:			K. Bonomo
		/// Team:			OG Starters
		/// Purpose:		This method will take one parameter 
		///					and format the string to display the 
		///					number of likes for a given article
		/// Parameters:     int articleId
		/// Method Type:    Public
		/// Return Type:    String
		/// Returns:        Detailed string for the likes
		/// Exception:		Database connection failed
		/// Error Code:		ERROR_DBError_SERVICE_0019
		/// SQL Type:		SELECT
		/// </summary>
		//--Variables--//
		string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
		string sqlQuery = "SELECT DISTINCT userId FROM [ArticleLikes] WHERE articleId=@articleId";
		int numOfLIkes = 0;
		int tempNum = 0;
		string strToReturn = "";
		//--Processing Logic--//
		//--Select Data From Database--//
		SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.
			ConnectionStrings[CONNECTION_STRING].ToString());
		SqlCommand queryCommand = new SqlCommand(sqlQuery, sqlConnection);
		queryCommand.Parameters.Add("@articleId", SqlDbType.Int).Value = articleId;
		try
		{
			sqlConnection.Open();
			SqlDataReader dbReader = queryCommand.ExecuteReader();
			while (dbReader.Read())
			{
				tempNum = Convert.ToInt32(dbReader["userId"]);
				numOfLIkes++;
			}
			dbReader.Close();
		}
		catch (Exception exeception)
		{
			log.SendErrors(ConstantErrors.ERROR_DBError_SERVICE_0019, exeception);
		}
		finally
		{
			queryCommand.Dispose();
			sqlConnection.Close();
		}
		// Form the string for likes
		strToReturn = numOfLIkes.ToString() + " like" + (numOfLIkes == 1 ? "" : "s");
		//--Return Statement--//
		return strToReturn;
	}
	private string GETArticle_CommentCount(int articleId)
	{
		/// <summary>
		/// Author:			K. Bonomo
		/// Team:			OG Starters
		/// Purpose:		This method will take one parameter 
		///					and format the string to display the 
		///					number of comments for a given article
		/// Parameters:     int articleId
		/// Method Type:    Public
		/// Return Type:    String
		/// Returns:        Detailed string for the comments
		/// Exception:		Database connection failed
		/// Error Code:		ERROR_DBError_SERVICE_0020
		/// SQL Type:		SELECT
		/// </summary>
		//--Variables--//
		string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
		string sqlQuery = "SELECT DISTINCT commentId FROM [ArticleComments] WHERE articleId=@articleId";
		int numOfComments = 0;
		int tempNum = 0;
		string strToReturn = "";
		//--Processing Logic--//
		//--Select Data From Database--//
		SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.
			ConnectionStrings[CONNECTION_STRING].ToString());
		SqlCommand queryCommand = new SqlCommand(sqlQuery, sqlConnection);
		queryCommand.Parameters.Add("@articleId", SqlDbType.Int).Value = articleId;
		try
		{
			sqlConnection.Open();
			SqlDataReader dbReader = queryCommand.ExecuteReader();
			while (dbReader.Read())
			{
				tempNum = Convert.ToInt32(dbReader["commentId"]);
				numOfComments++;
			}
			dbReader.Close();
		}
		catch (Exception exeception)
		{
			log.SendErrors(ConstantErrors.ERROR_DBError_SERVICE_0020, exeception);
		}
		finally
		{
			queryCommand.Dispose();
			sqlConnection.Close();
		}
		// Form the string for likes
		strToReturn = numOfComments.ToString() + " comment" + (numOfComments == 1 ? "" : "s");
		//--Return Statement--//
		return strToReturn;
	}
}