<%@ Page Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="conversionDolar.aspx.cs" Inherits="class_one.conversionDolar" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>CONVERSION DE MONEDA</h2>
    
    <div class="row">
            <div class="col-md-3">
                <label>Cantidad</label>
                <asp:TextBox ID="txb_cantidad" type="number" CssClass="form-control"
                    runat="server" placeholder="0000"></asp:TextBox>
            </div>
            <div class="col-md-3">
                <label>Tipo de Cambio $</label>
                <asp:TextBox ID="txb_cambio"  CssClass="form-control"
                    runat="server" placeholder="00.00"></asp:TextBox>
            </div>
            <div class="col-md-3">
                <br />
                <asp:Button ID="btn_cambio" Text="Obtener" CssClass="btn btn-success" runat="server" OnClick="btn_cambio_Click"/>
            </div>
        </div>
        <div class="row">
            <div class="col-md-3">
                <hr />
                <asp:Label ID="lbl_resultado" CssClass="" runat="server"/>
            </div>
        </div>
</asp:Content>