using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// DatabaseConnectionSecurity.cs
/// 
/// Author:         K. Bonomo
/// Team:			OG Starters
/// Created:        12-27-2018
/// Updated:        01-26-2019
/// Purpose:        This class will get the database
///					connection strings for the databases.
/// Package:		BKBSports.App_Code.Security
/// Classes:		
///	Lines:			48
/// Docs:  			https://bkbsportsanalytics.atlassian.net/wiki/spaces/BW/pages/1867825/DatabaseConnectionSecurity.cs
/// </summary>
/// 
public class DatabaseConnectionSecurity
{
    public string BKBDBConnection()
    {
		/// <summary>
		/// Author:			K. Bonomo
		/// Team:			OG Starters
		/// Purpose:        This method will return the 
		///					connection string name for
		///					the database
		/// Parameters:     
		/// Method Type:    Public
		/// Return Type:    String
		/// Returns:        Connection String name
		/// Exception:      
		/// Error Code:		
		/// SQL Type:		
		/// </summary>
		return "DB0001";
    }
}