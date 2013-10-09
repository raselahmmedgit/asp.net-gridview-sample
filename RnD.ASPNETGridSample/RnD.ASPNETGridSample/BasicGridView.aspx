<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="BasicGridView.aspx.cs" Inherits="RnD.ASPNETGridSample.BasicGridView" %>

<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div id="basicGridViewPage">
        <div id="bindByCodeZone">
            <div>
                <h2>
                    Basic Grid Bind By Code</h2>
            </div>
            <div>
                <asp:GridView ID="gvBasicByCode" runat="server" BackColor="#DEBA84" 
                    BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                    CellSpacing="2">
                    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                    <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                    <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#FFF1D4" />
                    <SortedAscendingHeaderStyle BackColor="#B95C30" />
                    <SortedDescendingCellStyle BackColor="#F1E5CE" />
                    <SortedDescendingHeaderStyle BackColor="#93451F" />
                </asp:GridView>
            </div>
        </div>
        <div id="bindBySqlDataSource">
            <div>
                <h2>
                    Basic Grid Bind By SqlDataSource</h2>
            </div>
            <div>
                <%--<asp:GridView ID="gvBasicBySqlDataSource" runat="server" BackColor="White" 
                    BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" 
                    CellSpacing="1" GridLines="None" DataSourceID="ObjectDataSource1">
                    <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
                    <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                    <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
                    <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#594B9C" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#33276A" />
                </asp:GridView>
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server">
                </asp:ObjectDataSource>
                <asp:EntityDataSource ID="EntityDataSource1" runat="server">
                </asp:EntityDataSource>--%>
            </div>
        </div>
        <%--<asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>--%>
    </div>
</asp:Content>
