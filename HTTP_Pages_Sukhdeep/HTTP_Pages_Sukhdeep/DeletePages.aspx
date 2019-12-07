<%@ Page Title="" Language="C#" MasterPageFile="~/mylayout.Master" AutoEventWireup="true" CodeBehind="DeletePages.aspx.cs" Inherits="HTTP_Pages_Sukhdeep.DeletePages" %>
<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
    <div id="confirmation">Are you sure you want to delete?</div>
    <asp:button type="button" runat="server" text="Delete" onclick="delete_function" />
    

      </div>
</asp:Content>
