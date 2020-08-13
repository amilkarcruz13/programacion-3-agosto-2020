<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Condicionales.aspx.cs" Inherits="class_one.Condicionales" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Sistema de Verificación de Pago de Impuestos por Sueldo Global</h1>
    <hr />
    <div class="row">
        <div class="col-md-1">
            <label>Ingresar parametro: </label>
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="txb_dato" runat="server" CssClass="form-control" type="number" required></asp:TextBox>
        </div>
        <div class="col-md-1">
            <asp:Button ID="btn_verificar" runat="server" CssClass="btn btn-success" Text="Verificar" OnClick="btn_verificar_Click"/>        
        </div>
        <div class="col-md-1">
            <asp:Label ID="lbl_resultado" runat="server" CssClass="label label-info" Text=""></asp:Label>
        </div>
    </div>
    <hr />
    <div class="row">
        <div class="col-md-12">
            <asp:Label ID="tbl_impuestos" runat="server"></asp:Label>
        </div>
    </div>
</asp:Content>
