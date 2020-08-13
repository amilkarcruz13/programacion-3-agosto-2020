<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="class_one._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h3>EJERCICIOS PROGRAMACION III</h3>
        <p class="lead">Suma: </p>
        <div class="row">
              <div class="col-md-3">
                  <asp:TextBox ID="txb1" CssClass="form-control" runat="server" type="number" placeholder="..dato 1"></asp:TextBox>
              </div>
              <div class="col-md-3">
                  <asp:TextBox ID="txb2" CssClass="form-control" runat="server" type="number" placeholder="..dato 2"></asp:TextBox>
              </div>
              <div class="col-md-3">
                  <asp:Button ID="btn_sumar" CssClass="btn btn-success btn-block" runat="server" text="Sumar" OnClick="btn_sumar_Click"></asp:Button>
              </div>
            <div class="col-md-3">
                <asp:Label ID="lbl_suma" CssClass="label label-info" runat="server" Text="..resultado"></asp:Label>
            </div>
        </div>

        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Aprender mas..</a>
        </p>
    </div>

    

</asp:Content>
