﻿<%@ Page Title="Add Player" Language="C#" MasterPageFile="~/Modules/PlayerManagement/PlayerManagement.master" AutoEventWireup="True" CodeBehind="Create.aspx.cs" Inherits="Bandits.Modules.PlayerManagement.Create" %>
<%@ Register Src="~/Source/PlayerManagement/PlayerWizard.ascx" TagPrefix="ui" TagName="PlayerWizard" %>

<asp:Content ID="MainContent" ContentPlaceHolderID="ModuleContent" runat="server">
    <ui:PlayerWizard runat="server" ID="PlayerWizard" />

</asp:Content>
