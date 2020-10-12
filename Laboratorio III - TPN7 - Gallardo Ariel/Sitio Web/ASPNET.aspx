<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ASPNET.aspx.cs" Inherits="ASPNET" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link rel="stylesheet" href="/css/bootstrap.min.css" />
    <link href="/css/style.css" rel="stylesheet" />
    <title>ASP.NET</title>
</head>
<body>
    <main class="container">
        <form id="formASPNET" class="col-lg-6 py-lg-3 pl-lg-5 border rounded mx-auto bg-transparent text-white" method="POST" runat="server">
            <h1 class="text-center">Componentes ASP.NET</h1>
            <asp:Panel CssClass="form-group row" runat="server">
                <asp:Label CssClass="form-label pt-2" runat="server">Caja de Texto</asp:Label>
                <asp:Panel CssClass="col-lg-8" runat="server">
                    <asp:TextBox CssClass="form-control-plaintext pl-1" ID="inpCaja" runat="server" MaxLength="10"></asp:TextBox>
                </asp:Panel>
            </asp:Panel>
            <asp:Panel CssClass="form-group row" runat="server">
                <asp:Label CssClass="form-label pt-1 mr-5" runat="server">Combo</asp:Label>
                <asp:Panel CssClass="col-lg-8" runat="server">
                    <asp:DropDownList CssClass="custom-select" ID="comboSelect" runat="server">
                        <asp:ListItem Value="0">Seleccionar</asp:ListItem>
                        <asp:ListItem Value="A">A</asp:ListItem>
                        <asp:ListItem Value="B">B</asp:ListItem>
                        <asp:ListItem Value="C">C</asp:ListItem>
                        <asp:ListItem Value="D">D</asp:ListItem>
                        <asp:ListItem Value="E">E</asp:ListItem>
                    </asp:DropDownList>
                </asp:Panel>
            </asp:Panel>
            <asp:Panel runat="server" CssClass="form-group row">
                <asp:Label runat="server">Imagen</asp:Label>
                <asp:FileUpload ID="fImagen" CssClass="form-control-file col-lg-10" accept="image/*" runat="server" />
            </asp:Panel>
            <asp:Panel runat="server" CssClass="form-group row">
                <asp:Label CssClass="mr-5" runat="server">CheckBox</asp:Label>
                <asp:Panel runat="server" CssClass="col-lg-8">
                    <asp:CheckBoxList ID="chkBox" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem>SI</asp:ListItem>
                        <asp:ListItem>NO</asp:ListItem>
                    </asp:CheckBoxList>
                </asp:Panel>
            </asp:Panel>
            <asp:Panel runat="server" CssClass="form-group row">
                <asp:Label CssClass="py-2" runat="server">Hipervinculo</asp:Label>
                <asp:Panel runat="server" CssClass="col-lg-8">
                    <asp:TextBox ID="inpURL" CssClass="form-control-plaintext pl-1" runat="server" ToolTip="URL"></asp:TextBox>
                </asp:Panel>
            </asp:Panel>
            <asp:Panel runat="server" CssClass="form-group row">
                <asp:Label runat="server">Radio Button</asp:Label>
                <asp:Panel runat="server" CssClass="col-lg-8">
                    <asp:RadioButtonList ID="rTipo" runat="server" RepeatDirection="Horizontal" CellPadding="2">
                        <asp:ListItem>Alta</asp:ListItem>
                        <asp:ListItem>Media</asp:ListItem>
                        <asp:ListItem>Baja</asp:ListItem>
                    </asp:RadioButtonList>
                </asp:Panel>
            </asp:Panel>
            <asp:Panel runat="server" CssClass="form-group row">
                <asp:Label runat="server">Campo Oculto</asp:Label>
                <asp:Panel runat="server" CssClass="col-lg-8">
                    <asp:TextBox ID="inpOculto" Visible="false" runat="server">Programacion 3 ASP.NET</asp:TextBox>
                </asp:Panel>
            </asp:Panel>
            <asp:Panel runat="server" CssClass="form-group row">
                <asp:Label CssClass="mt-1" runat="server">Boton</asp:Label>
                <asp:Panel runat="server" CssClass="col-lg-8 text-center">
                    <asp:Button CssClass="btn btn-outline-light" runat="server" Text="Enviar" OnClick="MostrarDatosHTML" />
                </asp:Panel>
            </asp:Panel>
        </form>
        <asp:Panel runat="server" CssClass="my-3 bg-light border rounded pl-3 py-2 col-lg-6 mx-auto">
            <h2 class="text-center">Datos Ingresados HTML5</h2>

            <asp:Panel runat="server" CssClass="row">
                <h5>Caja de Texto:</h5>
                <p class="col" id="salCaja" runat="server"></p>
            </asp:Panel>
            <asp:Panel runat="server" CssClass="row">
                <h5>Combo:</h5>
                <p class="col" id="salCombo" runat="server"></p>
            </asp:Panel>
            <asp:Panel runat="server" CssClass="text-center">
                <h5>Imagen</h5>
                <img src="/" class="img-thumbnail" id="salImg" alt="Aun no se carga nada" runat="server" />
            </asp:Panel>
            <asp:Panel runat="server" CssClass="row">
                <h5>CheckBox:</h5>
                <p class="col" id="salCheck" runat="server"></p>
            </asp:Panel>
            <asp:Panel runat="server" CssClass="row">
                <h5>Hipervinculo:</h5>
                <a class="col" id="salURL" runat="server"></a>
            </asp:Panel>
            <asp:Panel runat="server" CssClass="row">
                <h5>Radio Button:</h5>
                <p class="col" id="salRadio" runat="server"></p>
            </asp:Panel>
            <asp:Panel runat="server" CssClass="row">
                <h5>Campo Oculto:</h5>
                <p class="col" id="salOculto" runat="server"></p>
            </asp:Panel>
        </asp:Panel>
    </main>
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js"></script>
    <script src="/js/bootstrap.min.js"></script>
    <script src="/js/checkbox.js"></script>
</body>
</html>
