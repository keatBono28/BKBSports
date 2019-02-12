using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ArticleDesign
/// </summary>
public class ArticleDesign
{
	GETDatabase_Article article = new GETDatabase_Article();

	public string ArticleLayout(int articleId)
	{
		string article = "";
		article += "<div class=row>";// Start div for row
		article += "<div class=articleLeftColumn>";// Start div for left column
		article += "<div class=statBar>"; // Start div for stat bar
		article += "<h2>Mock Draft</h2>";// Heading for stats bar
		article += "<p>" + GetMockDraftTest() + "</p>"; // Para for stats // Get test method for the draft
		article += "</div>";// Ending the stat bar div
		article += "</div>";// Ending the left column div
		article += "<div class=articleRightColumn>"; //Start div for right column
		article += BuildArticle(articleId); // Build the article body
		article += "</div>"; // Ending div for right column
		return article;
	}

	private string BuildArticle(int articleId)
	{
		string strToReturn = "";
		strToReturn += "<div class=article>";
		strToReturn += "<div class=ArticleTitle>";// Start div for article header
		strToReturn += "<h2>" + article.GETArticle_Title(articleId) + "</h2>"; // Get the title
		strToReturn += "</div>"; // ending div for article header
		strToReturn += "<div class=articleBody>"; // Start div for article body
		if (article.GETArticle_ParaOne(articleId) != "" || article.GETArticle_ParaOne(articleId) != null)
		{
			strToReturn += "<p>" + article.GETArticle_ParaOne(articleId) + "</p>";
			if (article.GETArticle_ParaTwo(articleId) != "" || article.GETArticle_ParaTwo(articleId) != null)
			{
				strToReturn += "<p>" + article.GETArticle_ParaTwo(articleId) + "</p>";
				if (article.GETArticle_ParaThree(articleId) != "" || article.GETArticle_ParaThree(articleId) != null)
				{
					strToReturn += "<p>" + article.GETArticle_ParaThree(articleId) + "</p>";
					if (article.GETArticle_ParaFour(articleId) != "" || article.GETArticle_ParaFour(articleId) != null)
					{
						strToReturn += "<p>" + article.GETArticle_ParaFour(articleId) + "</p>";
						if (article.GETArticle_ParaFive(articleId) != "" || article.GETArticle_ParaFive(articleId) != null)
						{
							strToReturn += "<p>" + article.GETArticle_ParaFive(articleId) + "</p>";
							if (article.GETArticle_ParaSix(articleId) != "" || article.GETArticle_ParaSix(articleId) != null)
							{
								strToReturn += "<p>" + article.GETArticle_ParaSix(articleId) + "</p>";
								if (article.GETArticle_ParaSeven(articleId) != "" || article.GETArticle_ParaSeven(articleId) != null)
								{
									strToReturn += "<p>" + article.GETArticle_ParaSeven(articleId) + "</p>";
									if (article.GETArticle_ParaEight(articleId) != "" || article.GETArticle_ParaEight(articleId) != null)
									{
										strToReturn += "<p>" + article.GETArticle_ParaEight(articleId) + "</p>";
										if (article.GETArticle_ParaNine(articleId) != "" || article.GETArticle_ParaNine(articleId) != null)
										{
											strToReturn += "<p>" + article.GETArticle_ParaNine(articleId) + "</p>";
										}
									}
								}
							}
						}
					}
				}
			}
		}
		strToReturn += "</div>"; // ending div for article body
		//--Looking to see if there is a flag for the article--//
		if (article.GETArticle_ArticleFlag(articleId) == "Mock Draft")
		{
			strToReturn += "<div class=MockDraft>"; // Start div for mock draft
			GETDatabase_MockDraft mockDraft = new GETDatabase_MockDraft();
			strToReturn += mockDraft.BuildMockDraft();
			strToReturn += "</div>"; // ending div for mock draft
		}
		strToReturn += "</div>";
		return strToReturn;
	}

	// get rid of this
	private string GetMockDraftTest()
	{
		string strToReturn = "";
		strToReturn += "<p>1. Arizona Cardinal - Qunnen Williams</p>";
		strToReturn += "<p>2. San Francisco 49ers - Nick Bosa</p>";
		strToReturn += "<p>3. New York Jets - Jonah Williams</p>";
		strToReturn += "<p>4. Oakland Raiders - Josh Allen</p>";
		strToReturn += "<p>5. Tampa Bay Buccaneers - Greedy Williams</p>";
		strToReturn += "<p>6. New York Giants - Dwayne Haskins</p>";
		strToReturn += "<p>7. Jacksonville Jaquars - Cody Ford</p>";
		strToReturn += "<p>8. Detroit Lions - Ed Oliver</p>";
		strToReturn += "<p>9. Buffalo Bills - Marquise Brown</p>";
		strToReturn += "<p>10. Denver Broncos - Drew Lock</p>";
		strToReturn += "<p>11. Cincinnati Bengals - Devin White</p>";
		strToReturn += "<p>12. Green Bay Packers - Deionte Thompson</p>";
		strToReturn += "<p>13. Miami Dolphins - Rashan Gary</p>";
		strToReturn += "<p>14. Atlanta Falcons - Clelin Ferrell</p>";
		strToReturn += "<p>15. Washington Redskins - Daniel Jones</p>";
		strToReturn += "<p>16. Carolina Panthers - Devin Bush</p>";
		strToReturn += "<p>17. Cleveland Browns - Bryon Murphy</p>";
		strToReturn += "<p>18. Minnesota Vikings - Yodny Cajuste</p>";
		strToReturn += "<p>19. Tennessee Titans - Brian Burns</p>";
		strToReturn += "<p>20. Pittsburgh Steelers - Trayvon Mullen</p>";
		strToReturn += "<p>21. Seattle Seahawks - Irv Smith</p>";
		strToReturn += "<p>22. Baltimore Ravens - AJ Brown</p>";
		strToReturn += "<p>23. Houston Texans - Greg Little</p>";
		strToReturn += "<p>24. Oakland Raiders (Via Chicago) - Deandre Baker</p>";
		strToReturn += "<p>25. Philadelphia Eagles - Jeffery Simmons</p>";
		strToReturn += "<p>26. Indianapolis Colts - N'Keal Harry</p>";
		strToReturn += "<p>27. Oakland Raiders (Via Dallas) - Josh Jacobs</p>";
		strToReturn += "<p>28. Los Angeles Chargers - Jachai Polite</p>";
		strToReturn += "<p>29. Kansas City Chiefs - Taylor Rapp</p>";
		strToReturn += "<p>30. Green Bay Packers (Via New Orleans) - Montez Sweat</p>";
		strToReturn += "<p>31. Los Angeles Rams - Dre'Mont Jones</p>";
		strToReturn += "<p>32. New England Patriots - Christian Wilkins</p>";
		strToReturn += "<a href=Article.aspx>" + "Read more about the 2019 Mock Draft" + "</a>";
		//--Return Statement--//
		return strToReturn;
	}
}