<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="XeroProj.aspx.cs" Inherits="XeroProj" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" Runat="Server">
    <div class="ProjInfo">
        <img src="Images/XERO-LOGO.png" alt="Xero Logo" id="Logo" />
        <p>Xero is an action-based RPG game made for the PlayStation Vita platform aimed to release somewhere around 2028-2029</p>
        <h1>Technical details</h1>
        <p>Xero will run on the GODOT 3.5 engine</p>
        <p>The game should be around 4-5GB, but might be larger</p>
        <br/>
        <a href="AboutXero.aspx" class="link">Read More</a>
        <br/>
        <a href="https://github.com/SeaCreature-Studio/Xero" class="link">Download for PlayStation Vita (.VPK)</a>
    </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScript" Runat="Server">
</asp:Content>

