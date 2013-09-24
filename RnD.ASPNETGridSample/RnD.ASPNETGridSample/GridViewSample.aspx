<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="GridViewSample.aspx.cs" Inherits="RnD.ASPNETGridSample.GridViewSample" %>

<asp:Content ID="HeaderContent" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div id="defaultPage" style="width: 100%; display: inline-block;">
        <div style="float: left; width: 50%; display: inline-block;">
            <div>
                <h2>
                    Basic GridView Sample</h2>
                <p>
                    <a href="~/BasicGridView.aspx" class="button">Basic GridView</a>
                </p>
            </div>
            <div>
                <h2>
                   GridView CRUD And Bind By Code Sample</h2>
                <p>
                    <a href="~/GridViewCrud.aspx" class="button">GridView CRUD</a>
                </p>
            </div>
        </div>
        <div style="float: right; width: 50%; display: inline-block;">
            <div>
                <h2>
                    Sample</h2>
                <p>
                    <a href="#" id="" class="button">Click</a>
                </p>
            </div>
            <div>
                <h2>
                    Sample</h2>
                <p>
                    <a href="#" id="" class="button">Click</a>
                </p>
            </div>
        </div>
    </div>
</asp:Content>
