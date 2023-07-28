<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="MesajDetay.aspx.cs" Inherits="CvEntityProject.MesajDetay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>MESAJ DETAYLARI</h2>
    <asp:TextBox ID="TxtAdSoyad" runat="server" Enabled="false" CssClass="form-control" ></asp:TextBox>
    <br />
    <asp:TextBox ID="TxtMail" runat="server" Enabled="false" CssClass="form-control"></asp:TextBox>
    <br />
    <asp:TextBox ID="TxtKonu" runat="server" Enabled="false" CssClass="form-control"></asp:TextBox>
    <br />
    <asp:TextBox ID="TxtMesaj" TextMode="MultiLine" Height="100" runat="server" Enabled="false" CssClass="form-control"></asp:TextBox>

</asp:Content>
