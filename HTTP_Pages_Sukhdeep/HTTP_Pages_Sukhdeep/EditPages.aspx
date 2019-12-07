<%@ Page Title="" Language="C#" MasterPageFile="~/mylayout.Master" AutoEventWireup="true" CodeBehind="EditPages.aspx.cs" Inherits="HTTP_Pages_Sukhdeep.EditPages" %>
<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
    <div id="page" runat="server">
        <section>
           <%-- PAGE FOR UPDATE THE TITLE AND BODY AND THEN SAVING INTO DATABASE--%>
            <h1>Update Page Details</h1>
            <div>
                <%--HERE GOES MY TITLE TO EDIT --%>
                <label for="page_title">Page Title:</label>
                <asp:TextBox runat="server" id="page_title"></asp:TextBox>
                <asp:RequiredFieldValidator  runat="server" EnableClientScript="true" ErrorMessage="Please provide page title" ControlToValidate="page_title"></asp:RequiredFieldValidator>
            </div>
            <div><%--CREATE TEXT AREA FOR EDITING BODY--%>
                <label for="page_body">Page Body:</label>
                <asp:textbox runat="server" TextMode="multiline" Columns="50" Rows="5"  id="page_body"></asp:textbox>
                <asp:RequiredFieldValidator  runat="server" EnableClientScript="true" ErrorMessage="Please provide page content" ControlToValidate="page_body"></asp:RequiredFieldValidator>
            </div>
        </section>
         <section>
            <asp:Button runat="server" Text="Save" CssClass="edit_button"/>
        </section>
    </div>
</asp:Content>
