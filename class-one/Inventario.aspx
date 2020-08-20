<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Template.Master" CodeBehind="Inventario.aspx.cs" Inherits="class_one.Inventario" %>
<asp:Content runat="server" ContentPlaceHolderID="MainContent"> 
    <div class="row">
        <h2> Gestión de inventarios</h2>
    </div>
    <div class="row">
        <div class="col-md-3">
            <asp:TextBox ID="txb_producto" CssClass="form-control" 
            placeholder="..nombre de producto" required="required" runat="server"></asp:TextBox>
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="txb_cantidad" type="number" CssClass="form-control" 
            placeholder="000" required="required" runat="server"></asp:TextBox>
        </div>
        <div class="col-md-3">
            <asp:Button ID="btn_guardar" CssClass="btn btn-succes" 
            runat="server" Text="Registrar" OnClick="btn_guardar_Click"/>
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <table class="table table-bordered table-stripped">
                <thead>
                    <tr>
                        <th>PRODUCTO</th>
                        <th>CANTIDAD</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Label ID="lbl_detalle" runat="server"></asp:Label>
                </tbody>
            </table>
        </div>
    </div>
</asp:Content>

