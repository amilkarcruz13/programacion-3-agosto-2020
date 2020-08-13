<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PromNotasDinamico.aspx.cs" Inherits="class_one.PromNotasDinamico" %>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>Promedio de notas dinamico</h2>
    <legend>Registro</legend>
    <div class="row" id="Materias">
        <div class="col-md-3">
            <label>Materia</label>
            <asp:TextBox ID="txb_materia" runat="server" CssClass="form-control"
                placeholder="Nombre de materia"></asp:TextBox>
        </div>
        <div class="col-md-2">
            <label>Examen</label>
            <asp:TextBox ID="txb_examen_mat" runat="server" CssClass="form-control"
                placeholder="Nota de examen" type="number"></asp:TextBox>
        </div>
        <div class="col-md-2">
            <label>1er Tarea</label>
            <asp:TextBox ID="txb_primer_t_mat" runat="server" CssClass="form-control"
                placeholder="...nota" type="number"></asp:TextBox>
        </div>
        <div class="col-md-2">
            <label>2da Tarea</label>
            <asp:TextBox ID="txb_segunda_t_mat" runat="server" CssClass="form-control"
                placeholder="...nota" type="number"></asp:TextBox>
        </div>
        <div class="col-md-2">
            <label>3er Tarea</label>
            <asp:TextBox ID="txb_tercer_t_mat" runat="server" CssClass="form-control"
                placeholder="...nota" type="number"></asp:TextBox>
        </div>
        <div class="col-md-1">
            <asp:Button ID="btn_promedio" runat="server" CssClass="btn btn-success" 
                text="Agregar" Style="margin-top:20px;" OnClick="btn_promedio_Click" Visible="False" />
            <asp:Button ID="btn_promedioD" runat="server" CssClass="btn btn-success" 
                text="Agregar" Style="margin-top:20px;" OnClick="btn_promedioD_Click"/>
        </div>
    </div>
    <hr />
    <div class="row">
        <div class="col-md-12">
            <table class="table table-stripped table-bordered">
                <thead>
                    <tr>
                        <th>MATERIA</th>
                        <th>PROMEDIO EXAMEN</th>
                        <th>PROMEDIO TAREAS</th>
                        <th>PROMEDIO FINAL</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Label ID="lbl_detalle" runat="server"></asp:Label>
                </tbody>
            </table>
        </div>
    </div>
</asp:Content>