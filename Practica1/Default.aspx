<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Practica1.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <main class="m-5">
        <section>
            <div class="container">
                <div class="row">
                    <div class="col">
                        <asp:GridView runat="server" ID="dvgDireccion" DataKeyNames="Calle" OnSelectedIndexChanged="dvgDireccion_SelectedIndexChanged" CssClass="table table-danger table-bordered" AutoGenerateColumns="false">
                            <Columns>
                                <asp:BoundField HeaderText="Calle" DataField="Calle" />
                                <asp:BoundField HeaderText="Altura" DataField="Altura" />
                                <asp:CommandField ShowSelectButton="true" SelectText=">Seleccionar<" ItemStyle-CssClass="text-center" ControlStyle-CssClass="text-bg-danger text-decoration-none" />
                            </Columns>
                        </asp:GridView>
                    </div>
                </div>
            </div>
            <div class="container">
                <div class="row">
                    <div class="col-1"></div>
                    <div class="col-8">
                        <asp:Button Text="Agregar" ID="btnAceptar" CssClass="btn btn-danger" runat="server" OnClick="btnAceptar_Click" /></div>
                    <div class="col-3">
                        <asp:Button Text="Modificar" ID="btnModificar" OnClick="btnModificar_Click" CssClass="btn btn-danger" runat="server" />
                        <asp:Button Text="Eliminar" ID="btnEliminar" CssClass="btn btn-danger" runat="server" OnClick="btnEliminar_Click" />                        
                    </div>
                       
                </div>
            </div>


        </section>
    </main>
</asp:Content>
