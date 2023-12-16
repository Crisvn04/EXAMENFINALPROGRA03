<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Agregar.aspx.cs" Inherits="EJERCICIO04.Tecnicos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div>  

          <p>&nbsp;</p>
</div>
<div>
    <br />
    <br />
   

<div class="container text-center">
    Edad: <asp:TextBox ID="tEdad" class="form-control" runat="server" ></asp:TextBox>
    Nombre: <asp:TextBox ID="tNombre" class="form-control" runat="server"></asp:TextBox>
    Correo: <asp:TextBox ID="tCorreo" class="form-control" runat="server"></asp:TextBox>
    NombrePartido: <asp:TextBox ID="tPartido" class="form-control" runat="server"></asp:TextBox>
</div>

    <br />
    <br />
    <br />

</div>
<div class="container text-center">

    <asp:Button ID="BtnAgregar" class="btn btn-outline-primary" runat="server" Text="Agregar" OnClick="BtnAgregar_Click" />
   

    </div>
</asp:Content>
