<%@ Page Title="" Language="C#" MasterPageFile="~/mylayout.Master" AutoEventWireup="true" CodeBehind="ListPages.aspx.cs" Inherits="HTTP_Pages_Sukhdeep.ListPages" %>
<asp:Content ID="pages_links" ContentPlaceHolderID="body" runat="server">
     <h1>Pages</h1>
    <%--THIS IS MY INTERFACE AND MAIN HOME PAGE--%>
    <a href="AddNewPage.aspx"> Add New</a>
    
    <div class="_table" runat="server">
        <div class="listitem">
            <div class="col3">Page Title</div>
          
            <div class="col3"> Actions</div>
        </div>
        <div id="pages_result" runat="server">

        </div>
    </div>
</asp:Content>

