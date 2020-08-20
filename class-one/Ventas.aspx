<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Template.Master" CodeBehind="Ventas.aspx.cs" Inherits="class_one.Ventas" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <h2>Gestión de ventas</h2>
    </div>
    <div class="row">
        <div class="col-md-3">
            <asp:TextBox ID="txb_producto" CssClass="form-control" 
            placeholder="..nombre de producto" required="required" runat="server"></asp:TextBox>
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="txb_precio" type="number" CssClass="form-control" 
            placeholder="000" required="required" runat="server"></asp:TextBox>
        </div>
        <div class="col-md-3">
            <asp:Button ID="btn_guardar" CssClass="btn btn-succes" 
            runat="server" Text="Registrar" OnClick="btn_guardar_Click"/>
        </div>
        <div class="col-md-3">
            <asp:Label ID="lbl_total" CssClass="label label-success" 
            runat="server" Text="0"></asp:Label>
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <table class="table table-bordered table-stripped">
                <thead>
                    <tr>
                        <th>PRODUCTO</th>
                        <th>PRECIO</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Label ID="lbl_detalle" runat="server"></asp:Label>
                </tbody>
            </table>
        </div>
    </div>

</asp:Content>

