<%@ Page Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="MayorMenor_Lista.aspx.cs" Inherits="class_one.MayorMenor_Lista" %>
<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <div class="row">
        <div class="col-md-12">
            <h3>Mayor menor lista</h3>
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
            <asp:TextBox ID="txb_limite" runat="server" CssClass="form-control" 
                placeholder="limite" TextMode="Number" required></asp:TextBox>
        </div>
        <div class="col-md-3">
            <asp:TextBox ID="txb_numero" runat="server" CssClass="form-control" 
                placeholder="Numero" TextMode="Number" required></asp:TextBox>
        </div>
        <div class="col-md-3">
            <asp:Button ID="btn_agregar" runat="server"  onClick="agregar"
               Text="Agregar" CssClass="btn btn-success btn-block"/>
        </div>
        <div class="col-md-3">
            <asp:Button ID="btn_ejecutar" runat="server" OnClick="mayorMenor" 
               Text="Ejecutar" CssClass="btn btn-success btn-block"/>
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <table class="table table-stripped table-bordered">
                <thead>
                    <tr>
                        <th>LISTA</th>
                        <th>MAYOR</th>
                        <th>MENOR</th>
                        <th>DIFERENCIA</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Label ID="lbl_detalle" runat="server"></asp:Label>
                </tbody>
            </table>
        </div>
    </div>
</asp:Content>

