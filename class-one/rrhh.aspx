<%@ Page Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="rrhh.aspx.cs" Inherits="class_one.rrhh" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Bienvenidos al Sistema de RRHH </h1>
    <div class="row">
        <div class="col-md-3">
            <asp:TextBox runat="server" ID="txb_nombre" CssClass="form-control" placeholder="nombre de obrero" required ></asp:TextBox>
        </div>
        <div class="col-md-3">
            <asp:TextBox runat="server" ID="txb_salario" CssClass="form-control" placeholder="0000" type="number"  required ></asp:TextBox>
        </div>
        <div class="col-md-3">
            <asp:Button runat="server" ID="btn_incremento" CssClass="btn btn-info" Text="Obtener Aumento" OnClick="btn_incremento_Click"></asp:Button>
        </div>
        <div class="col-md-3">
            <asp:Label runat="server" ID="lbl_resultado" CssClass="label label-info" ></asp:Label>
        </div>
    </div>
    <hr />
    <div class="row">
        <div class="col-md-12">
            <table class="table table-stripped table-bordered">
                <thead>
                    <tr>
                        <th>NOMBRE</th>
                        <th>SUELDO ACTUAL</th>
                        <th>INCREMENTO</th>
                        <th>SUELDO NUEVO</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Label ID="lbl_detalle" runat="server"></asp:Label>               
                </tbody>
            </table>
        </div>
    </div>
</asp:Content>