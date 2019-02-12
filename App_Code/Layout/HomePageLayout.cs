using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for HomePageLayout
/// </summary>
public class HomePageLayout
{
    //--Objects & Methods--//
    ArticleSummaryCardLayout summaryCard = new ArticleSummaryCardLayout();
    public string HPLayout()
    {
        string strToReturn = "";
        strToReturn += "<div class=row>";// Start div for row
        strToReturn += "<div class=leftColumn>";// start div for left column
        strToReturn += "<div class=statBar>"; // Start div for stat bar
        strToReturn += "<h2>Stats</h2>";// Heading for stats bar
        strToReturn += "<p>"+ "Stats coming soon..." +"</p>"; // Para for stats // Get test method for the draft
        strToReturn += "</div>";// Ending the stat bar div
        strToReturn += "</div>";// Ending the left column div
        strToReturn += summaryCard.BuildArticleSummaryColumn(); // Calling method to get center column
        strToReturn += "<div class=rightColumn>";//Starting div for the right column
        strToReturn += "<div class=twitterFeed>";//Starting div for the twitter feed
        strToReturn += "<h3>Twitter</h3>";//username of tweet
        strToReturn += "<p>tweets coming soon...</p>";//Twitter data
        strToReturn += "</div>";// Ending div for twitter feed
        strToReturn += "</div>";// Ending div for right column
        strToReturn += "</div>";//Ending the Row DIV
        return strToReturn;
    }
	
}