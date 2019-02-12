<%@ Page Title="" Language="C#" MasterPageFile="~/BKBSports/Heading.master" AutoEventWireup="true" CodeFile="DiscussionBoards.aspx.cs" Inherits="BKBSports_DiscussionBoards" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="StyleSheet" Runat="Server">
	<link rel="stylesheet" href="Styling/MasterStyle.css" type="text/css" />
	<link rel="stylesheet" href="Styling/ArticleSummaryCard.css" type="text/css" />
	<link rel="stylesheet" href="Styling/HomePage.css" type="text/css" />
	<link rel="stylesheet" href="Styling/ArticleDesign.css" type="text/css" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
	<asp:Label ID="lblPageContent" runat="server" Text=""></asp:Label>
</asp:Content>

