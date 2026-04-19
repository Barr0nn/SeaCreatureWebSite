<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" Runat="Server">
    <div class="login-form">
        <label for="userName">שם משתמש:</label><br>
        <input type="text" id="userName" name="userName"><br>
        <label for="password">סיסמה:</label><br>
        <input type="password" id="password" name="password"><br>
        <input type="submit" value="Submit">
    </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScript" Runat="Server">
</asp:Content>
