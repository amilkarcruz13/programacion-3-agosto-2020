﻿<%@ Page Language="C#" MasterPageFile="~/SegundoParcial.Master" AutoEventWireup="true" CodeBehind="Cliente.aspx.cs" Inherits="class_one.Cliente" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <div class="row">
        <div class="col-md-3">
            <asp:TextBox ID="txb_nombre" runat="server" CssClass="form-control" placeholder="Nombre de cliente" required></asp:TextBox>
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="txb_apellido" runat="server" CssClass="form-control" placeholder="Apellido de cliente" required></asp:TextBox>
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="txb_celular" runat="server" CssClass="form-control" placeholder="Celular" required></asp:TextBox>
        </div>
        <div class="col-md-3">
            <asp:Button ID="btn_registrar" runat="server" Text="Registrar" CssClass="btn btn-info btn-block" OnClick="btn_registrar_Click"/>
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <table class="table table-stripped table-bordered">
                <thead>
                    <tr>
                        <th>NOMBRE</th>
                        <th>APELLIDO</th>
                        <th>CELULAR</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Label ID="lbl_detalle" runat="server"></asp:Label>
                </tbody>
            </table>
        </div>
    </div>
</asp:Content>