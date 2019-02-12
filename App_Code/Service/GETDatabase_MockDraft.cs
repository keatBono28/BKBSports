using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for GETDatabase_MockDraft
/// </summary>
public class GETDatabase_MockDraft
{
	DatabaseConnectionSecurity databaseConnectionSecurity = new DatabaseConnectionSecurity();
	LogErrors log = new LogErrors();
	ConstantErrors errorCode = new ConstantErrors();
	GETDatabaseService GETDatabase = new GETDatabaseService();
	public string BuildMockDraft()
	{
		string strToReturn = "";
		for (int i = 1; i < 33; i++)
		{
			strToReturn += GetMockDraft(i);
		}
		return strToReturn;
	}

	private string GetMockDraft(int draftNum)
	{
		/// <summary>
		/// Author:			K. Bonomo
		/// Team:			OG Starters
		/// Purpose:       
		/// Parameters:     
		/// Method Type:    
		/// Return Type:    
		/// Returns:        
		/// Exception:		
		/// Error Code:		
		/// SQL Type:		
		/// </summary>
		//--Variables--//
		string CONNECTION_STRING = databaseConnectionSecurity.BKBDBConnection();
		string sqlQuery = "SELECT * FROM [MockDraft] WHERE " +
			"DraftNum=@DraftNum";
		string strToReturn = "";
		//--Processing Logic--//
		//--Select Data From Database--//
		SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.
			ConnectionStrings[CONNECTION_STRING].ToString());
		SqlCommand queryCommand = new SqlCommand(sqlQuery, sqlConnection);
		queryCommand.Parameters.Add("@DraftNum", SqlDbType.Int).Value = draftNum;
		try
		{
			sqlConnection.Open();
			SqlDataReader dbReader = queryCommand.ExecuteReader();
			while (dbReader.Read())
			{
				strToReturn += "<h2>"+ draftNum.ToString() + ". " + dbReader["TeamName"].ToString() + " select " + dbReader["FirstName"].ToString() + " " + dbReader["LastName"].ToString();
				strToReturn += "<h3>" + dbReader["Position"].ToString() + " from " + dbReader["College"].ToString() + " (" + dbReader["Class"].ToString() + ")" + "</h3></h2>";
				strToReturn += "<p>" + dbReader["DraftSummary"].ToString() + "</p>";
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
		return strToReturn;
	}
}
