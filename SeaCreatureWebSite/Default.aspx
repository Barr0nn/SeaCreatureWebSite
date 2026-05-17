<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" Runat="Server">
    <div class="AboutPage">
      <h1>About SeaCreature</h1>
      <p>Studio SeaCreature is an indie game studio formed in 2025</p>
        <!--<h1>The studio members : </h1>
        <h2>Bar Native</h2>
        <p>Bar is a lead game director / programmer. His current projects include Xero</p> --> 
        <h2>Our projects</h2>
        <nav class="main_nav">
  <button class="Navbar" onclick="window.location.href='../XeroProj.aspx'"><a href="XeroProj.aspx">The Xero Project</a></button>
  <button class="Navbar" onclick="window.location.href='../SeaEngine.aspx'"><a href="SeaEngine.aspx"  id="SeaEngine" runat="server">The SeaEngine</a></button>
</nav>
    </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScript" Runat="Server">
</asp:Content>