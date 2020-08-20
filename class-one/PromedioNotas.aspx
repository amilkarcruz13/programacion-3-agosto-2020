<%@ Page Language="C#" MasterPageFile="~/Template.Master" AutoEventWireup="true" CodeBehind="PromedioNotas.aspx.cs" Inherits="class_one.PromedioNotas" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server" ID="BodyContent">
    <h2>Promedio de notas</h2>
    <div class="row">
        <div class="col-md-6">
            <legend>Materia: Matematicas</legend>
            <div class="row" id="Matematicas">
                <div class="col-md-3">
                    <label>Examen</label>
                    <asp:TextBox ID="txb_examen_mat" runat="server" CssClass="form-control"
                        placeholder="Nota de examen" type="number"></asp:TextBox>
                </div>
                <div class="col-md-3">
                    <label>1er Tarea</label>
                    <asp:TextBox ID="txb_primer_t_mat" runat="server" CssClass="form-control"
                        placeholder="...nota" type="number"></asp:TextBox>
                </div>
                <div class="col-md-3">
                    <label>2da Tarea</label>
                    <asp:TextBox ID="txb_segunda_t_mat" runat="server" CssClass="form-control"
                        placeholder="...nota" type="number"></asp:TextBox>
                </div>
                <div class="col-md-3">
                    <label>3er Tarea</label>
                    <asp:TextBox ID="txb_tercer_t_mat" runat="server" CssClass="form-control"
                        placeholder="...nota" type="number"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="col-md-6">
            <legend>Materia: Fisica</legend>
            <div class="row" id="Fisica">
                <div class="col-md-3">
                    <label>Examen</label>
                    <asp:TextBox ID="txb_examen_fis" runat="server" CssClass="form-control"
                        placeholder="nota de examen" type="number"></asp:TextBox>
                </div>
                <div class="col-md-3">
                    <label>1er Tarea</label>
                    <asp:TextBox ID="txb_primer_t_fis" runat="server" CssClass="form-control"
                        placeholder="...nota" type="number"></asp:TextBox>
                </div>
                <div class="col-md-3">
                    <label>2da Tarea</label>
                    <asp:TextBox ID="txb_segunda_t_fis" runat="server" CssClass="form-control"
                        placeholder="...nota" type="number"></asp:TextBox>
                </div>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-md-6">
            <legend>Materia: Quimica</legend>
            <div class="row" id="Quimica">
                <div class="col-md-3">
                    <label>Examen</label>
                    <asp:TextBox ID="txb_examen_qui" runat="server" CssClass="form-control"
                        placeholder="Nota de examen" type="number"></asp:TextBox>
                </div>
                <div class="col-md-3">
                    <label>1er Tarea</label>
                    <asp:TextBox ID="txb_primer_t_qui" runat="server" CssClass="form-control"
                        placeholder="...nota" type="number"></asp:TextBox>
                </div>
                <div class="col-md-3">
                    <label>2da Tarea</label>
                    <asp:TextBox ID="txb_segunda_t_qui" runat="server" CssClass="form-control"
                        placeholder="...nota" type="number"></asp:TextBox>
                </div>
                <div class="col-md-3">
                    <label>3er Tarea</label>
                    <asp:TextBox ID="txb_tercer_t_qui" runat="server" CssClass="form-control"
                        placeholder="...nota" type="number"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="col-md-6">
            <br />
            <asp:Button ID="btn_promedio" CssClass="btn btn-success btn-block" 
                text="Obtener Promedio" runat="server" OnClick="btn_promedio_Click"
                style="margin-top:55px;"/>
        </div>
    </div>
    <hr />
    <div class="row">
        <div class="col-md-12">
            <table class="table table-stripped table-bordered">
                <thead>
                    <tr>
                        <th>MATEMATICAS</th>
                        <th>FISICA</th>
                        <th>QUIMICA</th>
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
