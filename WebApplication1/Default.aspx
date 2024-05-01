<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    

    <div class="row">
        <div class="col-md-4">
            <asp:GridView ID="GridView1" runat="server" CssClass="gridview">
            </asp:GridView>
            <br />
        </div>
    </div>

</asp:Content>
