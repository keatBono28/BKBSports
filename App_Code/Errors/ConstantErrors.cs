using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// ConstantErrors.cs
/// 
/// Author:         K. Bonomo
/// Team:			OG Starters
/// Created:        12-27-2018
/// Updated:        02-03-2019
/// Purpose:        This class will contain all the
///					error codes for database connectivity.
///					The Error code is broken up as 
///					follows: ClassName.cs-MethodName
/// Package:		BKBSports.App_Code.Errors
/// Classes:		
///	Lines:			90
/// Docs:  			https://bkbsportsanalytics.atlassian.net/wiki/spaces/BW/pages/1900588/ConstantErrors.cs
/// </summary>

public class ConstantErrors
{
    //--Database Security Errros--//
    public const string ERROR_DBError_SECURITY_0001 = "DatabaseSecurity.cs-ValidateUserExists";
    public const string ERROR_DBError_SECURITY_0002 = "DatabaseSecurity.cs-ValidateUserAcctType";
    //--Database Service Errors--//
    public const string ERROR_DBError_SERVICE_0001 = "GETDatabaseService.cs-GETUserFullName";
    public const string ERROR_DBError_SERVICE_0002 = "GETDatabaseService.cs-GETUserFirstName";
    public const string ERROR_DBError_SERVICE_0003 = "GETDatabaseService.cs-GETUserLastName";
    public const string ERROR_DBError_SERVICE_0004 = "GETDatabase_Article.cs-GETArticle_ParaOne";
    public const string ERROR_DBError_SERVICE_0005 = "GETDatabase_Article.cs-GETArticle_ParaTwo";
    public const string ERROR_DBError_SERVICE_0006 = "GETDatabase_Article.cs-GETArticle_ParaThree";
    public const string ERROR_DBError_SERVICE_0007 = "GETDatabase_Article.cs-GETArticle_ParaFour";
    public const string ERROR_DBError_SERVICE_0008 = "GETDatabase_Article.cs-GETArticle_ParaFive";
    public const string ERROR_DBError_SERVICE_0009 = "GETDatabase_Article.cs-GETArticle_ParaSix";
    public const string ERROR_DBError_SERVICE_0010 = "GETDatabase_Article.cs-GETArticle_ParaSeven";
    public const string ERROR_DBError_SERVICE_0011 = "GETDatabase_Article.cs-GETArticle_ParaEight";
    public const string ERROR_DBError_SERVICE_0012 = "GETDatabase_Article.cs-GETArticle_ParaNine";
    public const string ERROR_DBError_SERVICE_0013 = "GETDatabaseService.cs-GETUserAcctType";
    public const string ERROR_DBError_SERVICE_0014 = "GETDatabaseService.cs-GETUserAcctFlag";
    public const string ERROR_DBError_SERVICE_0015 = "GETDatabase_Article.cs-GETArticle_Title";
    public const string ERROR_DBError_SERVICE_0016 = "GETDatabase_Article.cs-GETArticleId";
    public const string ERROR_DBError_SERVICE_0017 = "GETDatabase_Article.cs-GETArticle_Author";
    public const string ERROR_DBError_SERVICE_0018 = "GETDatabase_Article.cs-GETArticle_CreateDate";
	public const string ERROR_DBError_SERVICE_0019 = "GETDatabase_Article.cs-GETArticle_LikeCount";
	public const string ERROR_DBError_SERVICE_0020 = "GETDatabase_Article.cs-GETArticle_CommentCount";
	public const string ERROR_DBError_SERVICE_0021 = "GETDatabase_Article.cs-GETArticle_ArticleSummary";
	//--Admin Access Errors--//
	public const string ERROR_DBError_ADMINACCESS_0001 = "POSTAdminDatabase.cs-POSTNewEditor_AcctLogin";
    public const string ERROR_DBError_ADMINACCESS_0002 = "POSTAdminDatabase.cs-POSTNewEditor_UserInfo";
    public const string ERROR_DBError_ADMINACCESS_0003 = "POSTAdminDatabase.cs-POSTNewEditor_UserAcct";
    public const string ERROR_DBError_ADMINACCESS_0004 = "UPDATEAdminDatabase.cs-UPDATEAdmin_AcctLogin";
    public const string ERROR_DBError_ADMINACCESS_0005 = "UPDATEAdminDatabase.cs-UPDATEAdmin_UserInfo";
    public const string ERROR_DBError_ADMINACCESS_0006 = "UPDATEAdminDatabase.cs-UPDATEAdmin_UserAcct";
    public const string ERROR_DBError_ADMINACCESS_0007 = "UPDATEAdminDatabase.cs-UPDATEAdmin_UserAcct_acctFlag";
    //--Editor Access Errors--//
    public const string ERROR_DBError_EDITORACCESS_0001 = "POSTEditorDatabase.cs-POSTArticle_Article";
    public const string ERROR_DBError_EDITORACCESS_0002 = "POSTEditorDatabase.cs-POSTArticle_Picture";
    public const string ERROR_DBError_EDITORACCESS_0003 = "POSTEditorDatabase.cs-POSTArticle_Video";
    public const string ERROR_DBError_EDITORACCESS_0004 = "POSTEditorDatabase.cs-POSTArticle_Source";
    public const string ERROR_DBError_EDITORACCESS_0005 = "POSTEditorDatabase.cs-POSTArticle_ArticlePicture";
    public const string ERROR_DBError_EDITORACCESS_0006 = "POSTEditorDatabase.cs-POSTArticle_ArticleVideo";
    public const string ERROR_DBError_EDITORACCESS_0007 = "UPDATEEditorDatabase.cs-UPDATEEditor_AcctLogin";
    public const string ERROR_DBError_EDITORACCESS_0008 = "UPDATEEditorDatabase.cs-UPDATEEditor_UserInfo";
    public const string ERROR_DBError_EDITORACCESS_0009 = "UPDATEEditorDatabase.cs-UPDATEEditor_UserAcct_Maintenance";
    public const string ERROR_DBError_EDITORACCESS_0010 = "UPDATEEditor_Article.cs-UPDATE_Article_ParaOne";
    public const string ERROR_DBError_EDITORACCESS_0011 = "UPDATEEditor_Article.cs-UPDATE_Article_ParaTwo";
    public const string ERROR_DBError_EDITORACCESS_0012 = "UPDATEEditor_Article.cs-UPDATE_Article_ParaThree";
    public const string ERROR_DBError_EDITORACCESS_0013 = "UPDATEEditor_Article.cs-UPDATE_Article_ParaFour";
    public const string ERROR_DBError_EDITORACCESS_0014 = "UPDATEEditor_Article.cs-UPDATE_Article_ParaFive";
    public const string ERROR_DBError_EDITORACCESS_0015 = "UPDATEEditor_Article.cs-UPDATE_Article_ParaSix";
    public const string ERROR_DBError_EDITORACCESS_0016 = "UPDATEEditor_Article.cs-UPDATE_Article_ParaSeven";
    public const string ERROR_DBError_EDITORACCESS_0017 = "UPDATEEditor_Article.cs-UPDATE_Article_ParaEight";
    public const string ERROR_DBError_EDITORACCESS_0018 = "UPDATEEditor_Article.cs-UPDATE_Article_ParaNine";
    public const string ERROR_DBError_EDITORACCESS_0019 = "UPDATEEditor_Article.cs-UPDATE_Article_Maintenance";
    public const string ERROR_DBError_EDITORACCESS_0020 = "POSTEditorDatabase.cs-POSTArticle_ArticleSummary";
    public const string ERROR_DBError_EDITORACCESS_0021 = "UPDATEEditor_Article.cs-UPDATE_Article_ArticleSummary";
	//--Public Access Errors--//
	public const string ERROR_DBError_PUBLICACCESS_0001 = "POSTPublicDatabase.cs-POSTNewPublic_AcctLogin";
	public const string ERROR_DBError_PUBLICACCESS_0002 = "POSTPublicDatabase.cs-POSTNewPublic_UserInfo";
	public const string ERROR_DBError_PUBLICACCESS_0003 = "POSTPublicDatabase.cs-POSTNewPublic_UserAcct";
	public const string ERROR_DBError_PUBLICACCESS_0004 = "POSTPublicDatabase.cs-POSTNewPublic_ArticleComment";
	public const string ERROR_DBError_PUBLICACCESS_0005 = "POSTPublicDatabase.cs-POSTNewPublic_CommentLike";
	public const string ERROR_DBError_PUBLICACCESS_0006 = "POSTPublicDatabase.cs-POSTNewPublic_ArticleLike";
	public const string ERROR_DBError_PUBLICACCESS_0007 = "UPDATEPublicDatabase.cs-UPDATEPublic_AcctLogin";
	public const string ERROR_DBError_PUBLICACCESS_0008 = "UPDATEPublicDatabase.cs-UPDATEPublic_UserInfo";
	public const string ERROR_DBError_PUBLICACCESS_0009 = "UPDATEPublicDatabase.cs-UPDATEPublic_UserAcct_Maintenance";
}