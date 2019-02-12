using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BKBSports_Article : System.Web.UI.Page
{
	ArticleDesign ArticleDesign = new ArticleDesign();
	protected void Page_Load(object sender, EventArgs e)
	{
		if (Request.QueryString["articleId"] != null)
		{
			// Build the article
			lblPageContent.Text = ArticleDesign.ArticleLayout(Convert.ToInt32(Request.QueryString["articleId"]));
		}
	}
}