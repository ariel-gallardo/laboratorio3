<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FormularioDB.aspx.cs" Inherits="FormularioDB" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link rel="stylesheet" href="/css/bootstrap.min.css" />
    <link rel="stylesheet" href="/css/intlTelInput.css" />
    <link href="/css/Formulario.css" rel="stylesheet" />
    <script src="https://www.google.com/recaptcha/api.js"></script>
    <title>FormularioDB</title>
</head>
<body class="bg-light">
    <h1 class="text-center mt-3">REGISTRO</h1>
    <form id="FormRegister" runat="server">
        <asp:Panel ID="Panel1" runat="server" CssClass="mx-auto my-5 py-3 col-lg-3 border rounded" Direction="LeftToRight" EnableTheming="True" Height="100%" HorizontalAlign="Left" Width="50%">
            <asp:Label ID="Lab_Nombre" runat="server" Text="Nombre" CssClass="text-left" Font-Size="Small" Width="100%"></asp:Label>
            <asp:TextBox ID="TB_Nombre" runat="server" Width="49%" placeholder="Nombre/s"></asp:TextBox>
            <asp:TextBox ID="TB_Apellido" runat="server" Width="49%" placeholder="Apellido/s"></asp:TextBox>
            <div class="row justify-content-center text-center">
                <div class="col-6 mx-auto">
                    <asp:RequiredFieldValidator Display="Dynamic" runat="server" ControlToValidate="TB_Nombre" ErrorMessage="COMPLETAR" Font-Bold="True" Font-Size="XX-Small" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator Display="Dynamic" CssClass="text-left" ControlToValidate="TB_Nombre" ValidationExpression="[A-Za-z]*" ErrorMessage="SOLO LETRAS" runat="server" Font-Bold="True" Font-Size="XX-Small" ForeColor="Orange"></asp:RegularExpressionValidator>
                </div>
                <div class="col-6 mx-auto">
                    <asp:RequiredFieldValidator Display="Dynamic" runat="server" ControlToValidate="TB_Apellido" ErrorMessage="COMPLETAR" Font-Bold="True" Font-Size="XX-Small" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator Display="Dynamic" CssClass="text-left" ControlToValidate="TB_Apellido" ValidationExpression="[A-Za-z]*" ErrorMessage="SOLO LETRAS" runat="server" Font-Bold="True" Font-Size="XX-Small" ForeColor="Orange"></asp:RegularExpressionValidator>
                </div>
            </div>
            <asp:Label ID="Lab_Email" runat="server" CssClass="text-left" Font-Size="Small" Text="Nombre de usuario"></asp:Label>
            <asp:RequiredFieldValidator Display="Dynamic" runat="server" ControlToValidate="TB_Email" ErrorMessage="COMPLETAR" CssClass="mr-1" Font-Bold="True" Font-Size="XX-Small" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:CompareValidator Display="Dynamic" runat="server" ControlToValidate="TB_EmailV" ControlToCompare="TB_Email" Operator="NotEqual" ErrorMessage="NO DEBE SER IGUAL AL ALTERNATIVO" Font-Bold="True" Font-Size="XX-Small" ForeColor="#3333CC"></asp:CompareValidator>
            <asp:TextBox ID="TB_Email" runat="server" Width="100%" placeholder="direccion@correo.com.ar" type="email"></asp:TextBox>
            <asp:Label ID="Lab_Password" runat="server" CssClass="text-left" Font-Size="Small" Text="Contraseña"></asp:Label>
            <asp:RequiredFieldValidator Display="Dynamic" runat="server" ControlToValidate="TB_Password" ErrorMessage="COMPLETAR" CssClass="mr-1" Font-Bold="True" Font-Size="XX-Small" ForeColor="Red"></asp:RequiredFieldValidator>
            <div class="row">
                <asp:CompareValidator CssClass="col-12" Display="Dynamic" runat="server" ControlToValidate="TB_Password" ControlToCompare="TB_PasswordV" ErrorMessage="DEBE SER IDENTICA A LA VERIFICACION" Font-Bold="True" Font-Size="XX-Small" ForeColor="#3333CC"></asp:CompareValidator>
                <asp:RegularExpressionValidator CssClass="col-12" Display="Dynamic" ControlToValidate="TB_Password" runat="server" ValidationExpression="([?=*\w!@#$%^&*+;:]+[!@#$%^&*+;:]+[?=*\w!@#$%^&*+;:]*)+" ErrorMessage="DEBE TENER AL MENOS UN CARACTER !@#$%^&*+;:" Font-Bold="True" Font-Size="XX-Small" ForeColor="Red"></asp:RegularExpressionValidator>
            </div>
            <asp:TextBox ID="TB_Password" runat="server" Width="100%" type="password"></asp:TextBox>
            <asp:Label ID="Lab_PasswordV" runat="server" CssClass="text-left" Font-Size="Small" Text="Confirma tu contraseña" TextMode="Password"></asp:Label>
            <div class="row">
                <asp:RequiredFieldValidator CssClass="col-12" runat="server" ControlToValidate="TB_PasswordV" Display="Dynamic" ErrorMessage="COMPLETAR" Font-Bold="True" Font-Size="XX-Small" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator CssClass="col-12" Display="Dynamic" ControlToValidate="TB_PasswordV" runat="server" ValidationExpression="([?=*\w!@#$%^&*+;:]+[!@#$%^&*+;:]+[?=*\w!@#$%^&*+;:]*)+" ErrorMessage="DEBE TENER AL MENOS UN CARACTER !@#$%^&*+;:" Font-Bold="True" Font-Size="XX-Small" ForeColor="Red"></asp:RegularExpressionValidator>
            </div>
            <asp:TextBox TextMode="Password" ID="TB_PasswordV" runat="server" Width="100%"></asp:TextBox>
            <asp:Label ID="Lab_Nacimiento" runat="server" CssClass="text-left" Font-Size="Small" Text="Fecha de nacimiento"></asp:Label>
            <asp:RequiredFieldValidator Display="Dynamic" runat="server" ControlToValidate="TB_Nacimiento" ErrorMessage="COMPLETAR" Font-Bold="True" Font-Size="XX-Small" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:RangeValidator ID="RV_Nacimiento" ControlToValidate="TB_Nacimiento" Type="Date" MinimumValue="01/01/1930" runat="server" ErrorMessage="EXCEDE LOS LIMITES" Font-Size="XX-Small" ForeColor="Red"></asp:RangeValidator>
            <asp:TextBox ID="TB_Nacimiento" runat="server" Width="100%" type="Date"></asp:TextBox>
            <asp:Label ID="Lab_Sexo" runat="server" CssClass="text-left" Font-Size="Small" Text="Sexo"></asp:Label>
            <asp:CompareValidator Display="Dynamic" runat="server" ControlToValidate="DDL_Sexo" Operator="NotEqual" ValueToCompare="N" ErrorMessage="COMPLETAR" Font-Bold="True" Font-Size="XX-Small" ForeColor="Red"></asp:CompareValidator>
            <asp:DropDownList ID="DDL_Sexo" runat="server" Width="100%">
                <asp:ListItem Value="N">Seleccionar</asp:ListItem>
                <asp:ListItem Value="F">Femenino</asp:ListItem>
                <asp:ListItem Value="M">Masculino</asp:ListItem>
            </asp:DropDownList>
            <asp:Label ID="Lab_Telefono" runat="server" CssClass="text-left" Font-Size="Small" Text="Telefono Movil"></asp:Label>
            <asp:RequiredFieldValidator Display="Dynamic" runat="server" ControlToValidate="TB_Telefono" ErrorMessage="COMPLETAR" Font-Bold="True" Font-Size="XX-Small" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:TextBox ID="TB_Telefono" Width="100%" AutoCompleteType="Cellular" runat="server"></asp:TextBox>
            <asp:Label ID="Lab_EmailV" runat="server" CssClass="text-left" Font-Size="Small" Text="Dirección de correo alternativa"></asp:Label>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="TB_EmailV" Display="Dynamic" ErrorMessage="COMPLETAR" Font-Bold="True" Font-Size="XX-Small" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:TextBox ID="TB_EmailV" runat="server" Width="100%" placeholder="direccion@correo.com.ar" type="email"></asp:TextBox>
            <asp:Label ID="Lab_Ubicacion" runat="server" CssClass="text-left" Font-Size="Small" Text="Ubicación"></asp:Label>
            <asp:RequiredFieldValidator Display="Dynamic" runat="server" ControlToValidate="DDL_Ubicacion" ErrorMessage="COMPLETAR" Font-Bold="True" Font-Size="XX-Small" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:DropDownList CssClass="my-1" ID="DDL_Ubicacion" runat="server" Width="100%">
                <asp:ListItem Value="ARG">Argentina</asp:ListItem>
                <asp:ListItem Value="CLE">Chile</asp:ListItem>
                <asp:ListItem Value="URG">Uruguay</asp:ListItem>
            </asp:DropDownList>
            <asp:CheckBox ID="CB_Aceptar" AutoPostBack="True" OnCheckedChanged="AceptarTerminos" CausesValidation="true" runat="server" CssClass="text-left d-flex mx-auto" Font-Size="X-Small" Text="Acepto las Condiciones del servicio y la Política de privacidad de Google" Width="100%" />
            <asp:Label Visible="false" ID="Lab_Robot" runat="server" CssClass="text-left" Font-Size="Small" Text="Demuestranos que no eres un robot." Width="100%"></asp:Label>
            <div visible="false" class="g-recaptcha" data-sitekey="6LfKURIUAAAAAO50vlwWZkyK_G2ywqE52NU7YO0S" data-callback="verifyRecaptchaCallback" data-expired-callback="expiredRecaptchaCallback" id="B_Robot" runat="server"></div>
            <div class="row justify-content-end my-2">
                <asp:Button CausesValidation="true" Visible="false" ID="B_Siguiente" runat="server" CssClass="btn btn-outline-info my-2 mr-3" Font-Size="X-Small" Text="Siguiente Paso" OnClick="EnviarFormulario" />
            </div>
        </asp:Panel>
    </form>
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js"></script>
    <script src="/js/bootstrap.min.js"></script>
    <script src="/js/intlTelInput.js"></script>
    <script src="/js/Formulario.js"></script>
</body>
</html>
