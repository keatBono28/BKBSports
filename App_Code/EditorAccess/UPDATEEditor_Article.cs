using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// UPDATEEditor_Article
/// 
/// Author:         K. Bonomo
/// Created:        01-08-2019
/// Updated:        01-09-2019
/// Purpose:        This class services requests to the 
///                 database that will update data based 
///                 on information passed in.
/// Documentation:  Can be found in BKBSports Runbook.
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
        /// Purpose:        This method will take three parameters
        ///                 and update the Article paragraph one
        /// Parameters:     int userId, int articleId, string articleParaOne
        /// Returns:        true, if update is valid
        /// Exception:      udpate failed
        /// Method Type:    Public
        /// Return Type:    Boolean
        /// </summary>
        /// 
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "UPDATE [Articles] set articleParaOne=@articleParaOne" +
            " WHERE articleId=@articleId AND userId=@userId";
        Boolean updateValid = false;
        //--Insert data into database--//
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
        return updateValid;
    }
    public Boolean UPDATE_Article_ParaTwo(int articleId, int userId, string articleParaTwo)
    {

        /// <summary>
        /// Purpose:        This method will take three parameters
        ///                 and update the Article paragraph two
        /// Parameters:     int userId, int articleId, string articleParaTwo
        /// Returns:        true, if update is valid
        /// Exception:      udpate failed
        /// Method Type:    Public
        /// Return Type:    Boolean
        /// </summary>
        /// 
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "UPDATE [Articles] set articleParaTwo=@articleParaTwo" +
            " WHERE articleId=@articleId AND userId=@userId";
        Boolean updateValid = false;
        //--Insert data into database--//
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
        return updateValid;
    }
    public Boolean UPDATE_Article_ParaThree(int articleId, int userId, string articleParaThree)
    {

        /// <summary>
        /// Purpose:        This method will take three parameters
        ///                 and update the Article paragraph three
        /// Parameters:     int userId, int articleId, string articleParaThree
        /// Returns:        true, if update is valid
        /// Exception:      udpate failed
        /// Method Type:    Public
        /// Return Type:    Boolean
        /// </summary>
        /// 
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "UPDATE [Articles] set articleParaThree=@articleParaThree" +
            " WHERE articleId=@articleId AND userId=@userId";
        Boolean updateValid = false;
        //--Insert data into database--//
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
        return updateValid;
    }
    public Boolean UPDATE_Article_ParaFour(int articleId, int userId, string articleParaFour)
    {

        /// <summary>
        /// Purpose:        This method will take three parameters
        ///                 and update the Article paragraph four
        /// Parameters:     int userId, int articleId, string articleParaFour
        /// Returns:        true, if update is valid
        /// Exception:      udpate failed
        /// Method Type:    Public
        /// Return Type:    Boolean
        /// </summary>
        /// 
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "UPDATE [Articles] set articleParaFour=@articleParaFour" +
            " WHERE articleId=@articleId AND userId=@userId";
        Boolean updateValid = false;
        //--Insert data into database--//
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
        return updateValid;
    }
    public Boolean UPDATE_Article_ParaFive(int articleId, int userId, string articleParaFive)
    {

        /// <summary>
        /// Purpose:        This method will take three parameters
        ///                 and update the Article paragraph five
        /// Parameters:     int userId, int articleId, string articleParaFive
        /// Returns:        true, if update is valid
        /// Exception:      udpate failed
        /// Method Type:    Public
        /// Return Type:    Boolean
        /// </summary>
        /// 
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "UPDATE [Articles] set articleParaFive=@articleParaFive" +
            " WHERE articleId=@articleId AND userId=@userId";
        Boolean updateValid = false;
        //--Insert data into database--//
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
        return updateValid;
    }
    public Boolean UPDATE_Article_ParaSix(int articleId, int userId, string articleParaSix)
    {

        /// <summary>
        /// Purpose:        This method will take three parameters
        ///                 and update the Article paragraph six
        /// Parameters:     int userId, int articleId, string articleParaSix
        /// Returns:        true, if update is valid
        /// Exception:      udpate failed
        /// Method Type:    Public
        /// Return Type:    Boolean
        /// </summary>
        /// 
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "UPDATE [Articles] set articleParaSix=@articleParaSix" +
            " WHERE articleId=@articleId AND userId=@userId";
        Boolean updateValid = false;
        //--Insert data into database--//
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
        return updateValid;
    }
    public Boolean UPDATE_Article_ParaSeven(int articleId, int userId, string articleParaSeven)
    {

        /// <summary>
        /// Purpose:        This method will take three parameters
        ///                 and update the Article paragraph seven
        /// Parameters:     int userId, int articleId, string articleParaSeven
        /// Returns:        true, if update is valid
        /// Exception:      udpate failed
        /// Method Type:    Public
        /// Return Type:    Boolean
        /// </summary>
        /// 
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "UPDATE [Articles] set articleParaSeven=@articleParaSeven" +
            " WHERE articleId=@articleId AND userId=@userId";
        Boolean updateValid = false;
        //--Insert data into database--//
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
        return updateValid;
    }
    public Boolean UPDATE_Article_ParaEight(int articleId, int userId, string articleParaEight)
    {

        /// <summary>
        /// Purpose:        This method will take three parameters
        ///                 and update the Article paragraph eight
        /// Parameters:     int userId, int articleId, string articleParaEight
        /// Returns:        true, if update is valid
        /// Exception:      udpate failed
        /// Method Type:    Public
        /// Return Type:    Boolean
        /// </summary>
        /// 
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "UPDATE [Articles] set articleParaEight=@articleParaEight" +
            " WHERE articleId=@articleId AND userId=@userId";
        Boolean updateValid = false;
        //--Insert data into database--//
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
        return updateValid;
    }
    public Boolean UPDATE_Article_ParaNine(int articleId, int userId, string articleParaNine)
    {

        /// <summary>
        /// Purpose:        This method will take three parameters
        ///                 and update the Article paragraph nine
        /// Parameters:     int userId, int articleId, string articleParaNine
        /// Returns:        true, if update is valid
        /// Exception:      udpate failed
        /// Method Type:    Public
        /// Return Type:    Boolean
        /// </summary>
        /// 
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "UPDATE [Articles] set articleParaNine=@articleParaNine" +
            " WHERE articleId=@articleId AND userId=@userId";
        Boolean updateValid = false;
        //--Insert data into database--//
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
        return updateValid;
    }
    public Boolean UPDATE_Article_Maintenance(int articleId)
    {
        /// <summary>
        /// Purpose:        This method will take one parameter
        ///                 and update the Article maintenance timestamp
        /// Parameters:     int userId
        /// Returns:        true, if update is valid
        /// Exception:      udpate failed
        /// Method Type:    Public
        /// Return Type:    Boolean
        /// </summary>
        /// 
        //--Variables--//
        string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
        string sqlQuery = "UPDATE [Articles] set articleMaintenance=@articleMaintenance" +
            " WHERE articleId=@articleId";
        Boolean updateValid = false;
        //--Insert data into database--//
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
        return updateValid;
    }





}