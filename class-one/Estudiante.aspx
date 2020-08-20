<%@ Page Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="Estudiante.aspx.cs" Inherits="class_one.Estudiante" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-12">
            <label class="label label-success"  style="width: 100%;
            display: block;
            padding: 15px;
            font-size: 20px;
            font-weight: lighter;
            box-shadow: 1px 2px 2px rgba(0,0,0,0.4);
            background-color: #21b021;
            margin-bottom: 20px;
            color: #ffffff;
            text-align: center;
            ">GESTION DE INSTANCIA DE OBJETOS EN C#</label>
        </div>
        <div class="col-md-12">
            <table class="table table-stripped table-bordered">
                <tr>
                    <td>
                        <asp:Label ID="lbl_mensaje" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lbl_mensaje2" runat="server"></asp:Label>
                    </td>

                </tr>
            </table>

        </div>
    </div>
</asp:Content>