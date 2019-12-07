<%@ Page Title="" Language="C#" MasterPageFile="~/mylayout.Master" AutoEventWireup="true" CodeBehind="AddNewPage.aspx.cs" Inherits="HTTP_Pages_Sukhdeep.AddNewPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
     <h2>New Page</h2>
    <div class="formrow">
        <div>
        <label>Page Title:</label>
        </div>
        <asp:TextBox runat="server" TextMode="multiline" Columns="50" Rows="5" ID="page_title"></asp:TextBox>
    </div>
    <div class="formrow">
        <div>
        <label>Page Body:</label>
        </div>
        <asp:TextBox runat="server" TextMode="multiline" Columns="50" Rows="5" ID="page_body"></asp:TextBox>
    </div>

    <asp:Button OnClick="Add_Page" Text="Add Page" runat="server" />

</asp:Content>
