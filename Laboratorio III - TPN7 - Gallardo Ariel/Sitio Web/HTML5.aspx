<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HTML5.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="/css/bootstrap.min.css">
    <link href="/css/style.css" rel="stylesheet" />
    <title>HTML5</title>
</head>
<body>
    <main class="container">
        <form id="formHTML" class="col-lg-6 py-lg-3 pl-lg-5 border rounded mx-auto bg-transparent text-white" method="POST" runat="server">
            <h1 class="text-center">Componentes HTML5</h1>
            <div class="form-group row">
                <label class="form-label pt-2" for="inpCaja">Caja de Texto</label>
                <div class="col-lg-8">
                    <input class="form-control-plaintext pl-1" type="text" placeholder="Ingresar un texto" id="inpCaja" runat="server" required/>
                </div>
            </div>
            <div class="form-group row">
                <label class="form-label pt-1 mr-5" for="comboSelect">Combo</label>
                <div class="col-lg-8">
                   <select id="comboSelect" class="custom-select" runat="server" required>
                       <option value="0" disabled selected="selected">Seleccionar</option>
                        <option value="A">A</option>
                        <option value="B">B</option>
                        <option value="C">C</option>
                        <option value="D">D</option>
                        <option value="E">E</option>
                    </select>
                </div>
            </div>
            <div class="form-group row">
                <label class="form-label" for="fImagen">Imagen</label>
                <div class="col-lg-4">
                    <input id="fImagen" class="form-control-file" type="file" accept="image/*" runat="server"/>
                </div>
            </div>
            <div class="form-group row">
                <label class="form-label mr-5">CheckBox</label>
                <div class="col-lg-8">
                    <label class="mr-1" for="SI">SI<input type="checkbox" name="chkBox" value="SI"/></label>   
                    <label class="mr-1" for="NO">NO<input type="checkbox" name="chkBox" value="NO"/></label>
                </div>
            </div>
            <div class="form-group row">
                <label class="form-label py-2" for="inpURL">Hipervinculo</label>
                <div class="col-lg-8">
                    <input class="form-control-plaintext pl-1" type="text" id="inpURL" placeholder="URL" runat="server" required/>
                </div>
            </div>
            <div class="form-group row">
                <label class="form-label">Radio Button</label>
                <div class="col-lg-8">
                    <label for="alta">Alta</label>
                    <input class="mr-1"  type="radio" name="rTipo" value="alta"/>
                    <label for="media">Media</label>
                    <input class="mr-1" type="radio" name="rTipo" value="media"/>
                    <label for="baja">Baja</label>
                    <input class="mr-1"  type="radio" name="rTipo" value="baja"/>
                </div>
            </div>
            <div class="form-group row">
                <label for="inpOculto">Campo Oculto</label>
                <div class="col-lg-8">
                    <input type="text" id="inpOculto" value="Programacion 3 ASP.NET" runat="server" hidden/>
                </div>
            </div>
            <div class="form-group row">
                <label class="mt-1">Boton</label>
                <div class ="col-lg-8 text-center">
                    <button type="submit" name="btnHTML" class="btn btn-outline-light" runat="server" onserverClick="MostrarDatosHTML">Enviar</button>
                </div>
            </div>
        </form>
        <div class="my-3 bg-light border rounded pl-3 py-2 col-lg-6 mx-auto">
            <h2 class="text-center">Datos Ingresados HTML5</h2>
            <div class="row"><h5>Caja de Texto:</h5><p class="col" id="salCaja" runat="server"></p></div>
            <div class="row"><h5>Combo:</h5><p class="col" id="salCombo" runat="server"></p></div>
            <div class ="text-center"><h5>Imagen</h5><img class="img-thumbnail" id="salImg" alt="Aun no se carga nada" runat="server"/></div>
            <div class="row"><h5>CheckBox:</h5><p class="col" id="salCheck" runat="server"></p></div>
            <div class="row"><h5>Hipervinculo:</h5><a class="col" id="salURL" runat="server"></a></div>
            <div class="row"><h5>Radio Button:</h5><p class="col" id="salRadio" runat="server"></p></div>
            <div class="row"><h5>Campo Oculto:</h5><p class="col" id="salOculto" runat="server"></p></div>
        </div>
    </main>
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
<script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js"></script>
<script src="/js/bootstrap.min.js"></script>
<script src="/js/checkbox.js"></script>
</body>
</html>
