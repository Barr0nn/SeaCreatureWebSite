<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AboutXero.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" Runat="Server">
    <img src="Images/XERO-LOGO.png" alt="Xero Logo" id="Logo" />
    <div class="Combat">
        <h1>Combat</h1>
        <p>Xero's combat revolves aound the dual-action turn based combat system</p>
        <h3>The way it works: </h3>
        <p>Each battle is devided into 3 steps.</p>
        <ul>
            <li>Round</li>
            <li>Turn</li>
            <li>Action</li>
        </ul>
        <p>Each round contains one turn for each cahracter</p>
        <p>And each turn allows the character to use 2 actions (hence the name Dual-Action Combat System</p>
        <h3>Some ground rules:</h3>
        <ul>
            <li>The same action cannot be preformed twice in the same turn</li>
            <li>The second action will be 25% weaker than the first, unless the action has a set value instead of a set precentage</li>
        </ul>
    </div>
    
    <div class="story">

    </div>

    <div class="characters">

    </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderScript" Runat="Server">

</asp:Content>

