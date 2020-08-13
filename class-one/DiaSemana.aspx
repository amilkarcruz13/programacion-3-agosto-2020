<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DiaSemana.aspx.cs" Inherits="class_one.DiaSemana" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <hr />
        <div class="col-md-3">
            <asp:TextBox ID="txb_numero" runat="server" type="number" placeholder="00" 
                CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-md-3">
            <asp:Button ID="btn_semana" runat="server" Text="Obtener" CssClass="btn btn-success" OnClick="btn_semana_Click"/>
        </div>
        <div class="col-md-6">
            <asp:Label ID="lbl_resultado" runat="server"></asp:Label>
        </div>
    </div>
</asp:Content>