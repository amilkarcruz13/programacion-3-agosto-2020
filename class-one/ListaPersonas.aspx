<%@ Page Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="ListaPersonas.aspx.cs" Inherits="class_one.ListaPersonas" %>
<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <div class="row">
        <div class="col-md-12">
            <h3>LISTA DE PERSONAS</h3>
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
            <asp:TextBox ID="txb_nombre" runat="server" CssClass="form-control" 
                placeholder="Nombre" required></asp:TextBox>
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="txb_apellido" runat="server" CssClass="form-control" 
                placeholder="Apellido" required></asp:TextBox>
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="txb_fecha" TextMode="Date" runat="server" CssClass="form-control" 
                placeholder="" required></asp:TextBox>
        </div>
        <div class="col-md-3">
            <asp:Button ID="btn_guardar" runat="server" Text="Guardar" OnClick="guardar" CssClass="btn btn-info btn-block"/>
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <table class="table table-stripped table-bordered">
                <tr>
                    <td>
                        <asp:Label ID="lbl_mensaje" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </div>
    
</asp:Content>

