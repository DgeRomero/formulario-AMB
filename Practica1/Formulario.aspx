<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="Practica1.Formulario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row justify-content-center m-5">
        <div class="col-6">
            <div class="mb-3">
                <label for="txtCalle" class="form-label">Calle</label>
                <asp:TextBox runat="server" ID="txtCalle" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label for="txtAltura" class="form-label">Altura</label>
                <asp:TextBox runat="server" ID="txtAltura" CssClass="form-control" />
            </div>
        </div>
    </div>
    <div class="row justify-content-center">
             
                <asp:Button Text="Aceptar" ID="btnAceptar" onclick="btnAceptar_Click" CssClass="btn btn-danger col-1" runat="server" />
                <div class="col-1"></div>
                <asp:Button Text="Cancelar" ID="btnCancelar" CssClass="btn btn-danger col-1" OnClick="btnCancelar_Click" runat="server" />
            </div>



</asp:Content>
