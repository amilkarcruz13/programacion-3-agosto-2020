<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Template.Master" CodeBehind="tablaMultiplicar.aspx.cs" Inherits="class_one.tablaMultiplicar" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <div class="row">
        <div class="col-md-12">
            <h2>Tabla de multiplicar</h2>
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
            <asp:TextBox ID="txb_numero" runat="server" TextMode="Number" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-md-3">
            <asp:Button ID="btn_multiplicar" Text="Multiplicar" CssClass="btn btn-success btn-block" runat="server" OnClick="multiplicar"/>
        </div>
     </div>
    <div class="row">
        <div class="col-md-12">
            <table class="table table-bordered">
                <thead class="thead">
                    <tr>
                        <th>Resultado</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Label ID="lbl_detalle" runat="server"></asp:Label>
                </tbody>
            </table>
        </div>
    </div>
</asp:Content>