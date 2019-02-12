using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


/// ArticleSummaryCardLayout.cs
/// 
/// Author:         K. Bonomo
/// Team:			OG Starters
/// Created:        01-19-2019
/// Updated:        02-03-2019
/// Purpose:        This clas will build the layout
///					of the article summary cards for
///					the homepage.
/// Package:		BKBSports.App_Code.Layout.ArticleDesign
/// Classes:		- GETDatabase_Article.cs
///	Lines:			
/// Docs:  			https://bkbsportsanalytics.atlassian.net/wiki/spaces/BW/pages/1998889/ArticleSummaryCardLayout.cs
/// </summary>
public class ArticleSummaryCardLayout
{
    //--Objects & Classes--//
    GETDatabase_Article article = new GETDatabase_Article();
	//--Public Methods--//
    public string BuildArticleSummaryColumn()
    {
		/// <summary>
		/// Author:			K. Bonomo
		/// Team:			OG Starters
		/// Purpose:        This method will build the column 
		///					that will hold all the article summary
		///					cards for the home page.
		/// Parameters:     
		/// Method Type:    Public
		/// Return Type:    string
		/// Returns:        Article summary cards
		/// Exception:		
		/// Error Code:		
		/// SQL Type:		
		/// </summary> 
		//--Variables--//
		string articleColumn = "";
        int articleCount = article.GETArticleId(); // This will need chagned for a calculation
		//--Processing Logic--//
		int mostRecentArticleId = article.GETArticleId();
        //--Build Column for Articles--//
        articleColumn += "<div class=centerColumn>";// Start center column div tag
        for (int i = 0; i < articleCount; i++)
        {
            articleColumn += BuildArticleSummaryCard(mostRecentArticleId);
            mostRecentArticleId--;
        }
        articleColumn += "</div>";
        //Return the article column
        return articleColumn;
    }
	//--Private Methods--//
	private string BuildArticleSummaryCard(int mostRecentArticleId)
    {
		/// <summary>
		/// Author:			K. Bonomo
		/// Team:			OG Starters
		/// Purpose:        This method will build the individual
		///					article summary card for the column.
		/// Parameters:     
		/// Method Type:    Private
		/// Return Type:    string
		/// Returns:        Article summary card
		/// Exception:		
		/// Error Code:		
		/// SQL Type:		
		/// </summary> 
		//--Variables--//
		string articleSummaryCard = "";
        //--Logic to Build--//
        articleSummaryCard += "<div class=articleSummaryCard>"; // Start article summary card div tag
        articleSummaryCard += "<h3>" + article.GETArticle_Title(mostRecentArticleId) + "</h3>"; // Getting title of the article 
		articleSummaryCard += "<p>" + article.GETArticle_ArticleSummary(mostRecentArticleId) +        
		"<div class=ReadMore><a href=Article.aspx?articleId="+ mostRecentArticleId +"> Read More...</a></div></p>"; // Getting the article summary
		articleSummaryCard += BuildArticleDetails(mostRecentArticleId);
        articleSummaryCard += "</div>"; // End article summary card div tag
        //Return the article summary card
        return articleSummaryCard;
    }
    private string BuildArticleDetails(int mostRecentArticleId)
    {
		/// <summary>
		/// Author:			K. Bonomo
		/// Team:			OG Starters
		/// Purpose:        This method will build the individual
		///					article details for the summary card.
		/// Parameters:     
		/// Method Type:    Private
		/// Return Type:    string
		/// Returns:        Article summary card details
		/// Exception:		
		/// Error Code:		
		/// SQL Type:		
		/// </summary> 
		//--Variables--//
		string articleDetails = "";
        //--Building Logic--//
        articleDetails += "<div class=articleDetailsRow>";// Starting div tag for the details row
        articleDetails += "<div class=articleDetailsLeftColumn>"; // starting the div tag for the left column of the details
        articleDetails += "<div class=articleDetails>";// Starting div tag for the like and comments
        articleDetails += "<p>" + article.GETArticle_LikesAndCommentDetials(mostRecentArticleId) +  "</p>"; // Place holder for the number of likes and comments
        articleDetails += "</div>"; // Ending div tag for article details
        articleDetails += "</div>"; // Ending div tag for left column
        articleDetails += "<div class=articleDetailsRightColumn>"; // Starting div tag for the right column
        articleDetails += "<div class=articleAuthorInfo>";// Starting div tag for the like and comments
        articleDetails += "<p>" + article.GETArticle_Author(mostRecentArticleId) + " | "+ article.GETArticle_CreateDate(mostRecentArticleId) +"</p>";
        articleDetails += "</div>"; // Ending Div tag for the ArticleAuthorInfo
        articleDetails += "</div>"; // Ending Div tag for the right column
        articleDetails += "</div>"; // Ending div tag for the row
        //Return
        return articleDetails;
    }
	






}