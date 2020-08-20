<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Template.Master" CodeBehind="Administrador.aspx.cs" Inherits="class_one.Administrador" %>
<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <h2>GESTION DE ADMINISTRACION</h2>
    <div class="row">
        <div class="col-md-12">
            <div style="width: 100%;
            display: block;
            padding: 15px;
            font-size: 20px;
            font-weight: lighter;
            box-shadow: 1px 2px 2px rgba(0,0,0,0.4);
            background-color: #21b021;
            margin-bottom: 20px;
            color: #ffffff;
            text-align: center;
            ">
                <asp:Label ID="lbl_total" Text="0" runat="server" CssClass="label label-success">
               </asp:Label> Bs.
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <div style="width: 100%;
            display: block;
            padding: 15px;
            font-size: 20px;
            font-weight: lighter;
            box-shadow: 1px 2px 2px rgba(0,0,0,0.4);
            background-color: #ff6a00;
            margin-bottom: 20px;
            color: #ffffff;
            text-align: center;
            ">
                <asp:Label ID="lbl_inventario" Text="0 Productos en inventario" runat="server" CssClass="label label-success">
               </asp:Label>
            </div>
        </div>
    </div>
</asp:Content>
