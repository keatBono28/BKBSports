using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// GETDatabase_Article
/// 
/// Author:         K. Bonomo
/// Created:        01-09-2019
/// Updated:        01-09-2019
/// Purpose:        This class services requests to the 
///                 database that will update data based 
///                 on information passed in.
/// Documentation:  Can be found in BKBSports Runbook.
/// </summary>
public class GETDatabase_Article
{
    //--Objects & Classes--//
    DatabaseConnectionSecurity databaseConnectionSecurity = new DatabaseConnectionSecurity();
    LogErrors log = new LogErrors();
    ConstantErrors errorCode = new ConstantErrors();
    //--Get Methods--//
    public string GETArticle_ParaOne(int articleId)
    {
        /// <summary>
        /// Purpose:        This method will take one parameter
        ///                 and retrun the Article paragraph one
        /// Parameters:     int articleId
        /// Returns:        artilceParaOne
        /// Exception:      return failed, paragraph is empty
        /// Method Type:    Public
        /// Return Type:    string
        /// </summary>
        /// 
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "SELECT articleParaOne FROM [Articles] WHERE " +
            "articleId=@articleId";
        string paragraph = "";
        //--Get data from database--//
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
        return paragraph;
    }
    public string GETArticle_ParaTwo(int articleId)
    {
        /// <summary>
        /// Purpose:        This method will take one parameters
        ///                 and retrun the Article paragraph two
        /// Parameters:     int articleId
        /// Returns:        artilceParaTwo
        /// Exception:      return failed, paragraph is empty
        /// Method Type:    Public
        /// Return Type:    string
        /// </summary>
        /// 
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "SELECT articleParaTwo FROM [Articles] WHERE " +
            "articleId=@articleId";
        string paragraph = "";
        //--Get data from database--//
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
        return paragraph;
    }
    public string GETArticle_ParaThree(int articleId)
    {
        /// <summary>
        /// Purpose:        This method will take one parameters
        ///                 and retrun the Article paragraph three
        /// Parameters:     int articleId
        /// Returns:        artilceParaThree
        /// Exception:      return failed, paragraph is empty
        /// Method Type:    Public
        /// Return Type:    string
        /// </summary>
        /// 
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "SELECT articleParaThree FROM [Articles] WHERE " +
            "articleId=@articleId";
        string paragraph = "";
        //--Get data from database--//
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
        return paragraph;
    }
    public string GETArticle_ParaFour(int articleId)
    {
        /// <summary>
        /// Purpose:        This method will take one parameters
        ///                 and retrun the Article paragraph four
        /// Parameters:     int articleId
        /// Returns:        artilceParaFour
        /// Exception:      return failed, paragraph is empty
        /// Method Type:    Public
        /// Return Type:    string
        /// </summary>
        /// 
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "SELECT articleParaFour FROM [Articles] WHERE " +
            "articleId=@articleId";
        string paragraph = "";
        //--Get data from database--//
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
        return paragraph;
    }
    public string GETArticle_ParaFive(int articleId)
    {
        /// <summary>
        /// Purpose:        This method will take one parameters
        ///                 and retrun the Article paragraph five
        /// Parameters:     int articleId
        /// Returns:        artilceParaFive
        /// Exception:      return failed, paragraph is empty
        /// Method Type:    Public
        /// Return Type:    string
        /// </summary>
        /// 
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "SELECT articleParaFive FROM [Articles] WHERE " +
            "articleId=@articleId";
        string paragraph = "";
        //--Get data from database--//
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
        return paragraph;
    }
    public string GETArticle_ParaSix(int articleId)
    {
        /// <summary>
        /// Purpose:        This method will take one parameters
        ///                 and retrun the Article paragraph six
        /// Parameters:     int articleId
        /// Returns:        artilceParaSix
        /// Exception:      return failed, paragraph is empty
        /// Method Type:    Public
        /// Return Type:    string
        /// </summary>
        /// 
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "SELECT articleParaSix FROM [Articles] WHERE " +
            "articleId=@articleId";
        string paragraph = "";
        //--Get data from database--//
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
        return paragraph;
    }
    public string GETArticle_ParaSeven(int articleId)
    {
        /// <summary>
        /// Purpose:        This method will take one parameters
        ///                 and retrun the Article paragraph seven
        /// Parameters:     int articleId
        /// Returns:        artilceParaSeven
        /// Exception:      return failed, paragraph is empty
        /// Method Type:    Public
        /// Return Type:    string
        /// </summary>
        /// 
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "SELECT articleParaSeven FROM [Articles] WHERE " +
            "articleId=@articleId";
        string paragraph = "";
        //--Get data from database--//
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
        return paragraph;
    }
    public string GETArticle_ParaEight(int articleId)
    {
        /// <summary>
        /// Purpose:        This method will take one parameters
        ///                 and retrun the Article paragraph Eight
        /// Parameters:     int articleId
        /// Returns:        artilceParaEight
        /// Exception:      return failed, paragraph is empty
        /// Method Type:    Public
        /// Return Type:    string
        /// </summary>
        /// 
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "SELECT articleParaEight FROM [Articles] WHERE " +
            "articleId=@articleId";
        string paragraph = "";
        //--Get data from database--//
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
        return paragraph;
    }
    public string GETArticle_ParaNine(int articleId)
    {
        /// <summary>
        /// Purpose:        This method will take one parameters
        ///                 and retrun the Article paragraph Nine
        /// Parameters:     int articleId
        /// Returns:        artilceParaNine
        /// Exception:      return failed, paragraph is empty
        /// Method Type:    Public
        /// Return Type:    string
        /// </summary>
        /// 
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "SELECT articleParaNine FROM [Articles] WHERE " +
            "articleId=@articleId";
        string paragraph = "";
        //--Get data from database--//
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
        return paragraph;
    }








}