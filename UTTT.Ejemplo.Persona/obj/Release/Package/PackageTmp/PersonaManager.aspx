<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PersonaManager.aspx.cs" Inherits="UTTT.Ejemplo.Persona.PersonaManager" Debug="false" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <title></title>
    <script type="text/javascript">


        function validaNumeros(evt) {
            //valida que solo se ingresen números en la caja de texto
            var code = (evt.which) ? evt.which : evt.keyCode;
            if (code == 8) {
                return true;
            } else if (code >= 48 && code <= 57) {
                return true;
            } else {
                return false;
            }
        }

        function validaLetras(e) {
            //valida que solo ingrese letras y algunos caracteres especiales
            key = e.keyCode || e.which;
            tecla = String.fromCharCode(key).toLowerCase();
            console.log(tecla);
            letras = "áéíóúabcdefghijklmnñopqrstuvwxyz ";
            especiales = "8-37-39-46";
            tecla_especial = false;
            for (var i in especiales) {
                if (key == especiales[i]) {
                    tecla_especial = true;
                    break;
                }
            }
            if (letras.indexOf(tecla) == -1 && !tecla_especial) {
                return false;
            }
        }

        function validarSoloNumerosYLetras(e) {
            //valida que solo ingrese letras, numeros y algunos caracteres especiales
            key = e.keyCode || e.which;
            tecla = String.fromCharCode(key).toLowerCase();
            console.log(tecla);
            letrasNumeros = "1234567890áéíóúabcdefghijklmnñopqrstuvwxyz";
            especiales = "8-37-39-46";
            tecla_especial = false;


            console.log(tecla);
            for (var i in especiales) {
                if (key == especiales[i]) {
                    tecla_especial = true;
                    break;
                }
            }
            if (letrasNumeros.indexOf(tecla) == -1 && !tecla_especial) {
                return false;
            }
        }



    </script>
</head>
<body>


    <header class="p-3 bg-dark text-white">
        <div class="container">
            <div class="d-flex flex-wrap align-items-center justify-content-center justify-content-lg-start">
                <a href="/" class="d-flex align-items-center mb-2 mb-lg-0 text-white text-decoration-none">
                    <svg class="bi me-2" width="40" height="32" role="img" aria-label="Bootstrap">
                        <use xlink:href="#bootstrap"></use>
                    </svg>
                </a>

                <ul class="nav col-12 col-lg-auto me-lg-auto mb-2 justify-content-center mb-md-0">
                    <li><a href="PersonaPrincipal.aspx" class="nav-link px-2 text-secondary">Home</a></li>

                </ul>


            </div>
        </div>
    </header>

    <div class="container d-flex justify-content-center">

        <form id="form1" runat="server" class="d-flex flex-column justify-content-center">

            <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true">
            </asp:ScriptManager>

            <div class="card mt-5">
                <div style="font-family: Arial; font-size: medium; font-weight: bold">
                    <h1 class="text-center">Persona</h1>
                </div>
                <div class="card-header d-flex justify-content-center">

                    <asp:Label ID="lblAccion" runat="server" Text="Accion" Font-Bold="True"></asp:Label>
                </div>

                <div class="card-body">
                    <div class="">
                        <p class="m-0 form-label">Sexo:</p>
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                                <asp:DropDownList CssClass="m-0 form-control bg-primary text-white" ID="ddlSexo" runat="server"
                                    >
                                </asp:DropDownList>
                                <triggers>
                                    <asp:AsyncPostBackTrigger ControlID="ddlSexo" EventName="SelectedIndexChanged" />
                                </triggers>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>

                    <div>
                        <p class="m-0 form-label">Clave unica:</p>
                        <asp:TextBox ID="txtClaveUnica" CssClass="form-control" runat="server"
                            ViewStateMode="Disabled"
                            onkeypress="return validaNumeros(event);" pattern=".{1,3}"
                            title="1 a 3 es la longitud maxima que se permite ingresar"></asp:TextBox>
                    </div>

                    <div>
                        <p class="m-0">Nombre:</p>
                        <asp:TextBox
                            ID="txtNombre" runat="server" onkeypress="return validaLetras(event);" CssClass="form-control" ViewStateMode="Disabled"></asp:TextBox>
                    </div>

                    <div>
                        <p class="m-0">A Paterno:</p>
                        <asp:TextBox
                            ID="txtAPaterno" runat="server" onkeypress="return validaLetras(event);" CssClass="form-control" ViewStateMode="Disabled"></asp:TextBox>
                    </div>

                    <div>
                        <p class="m-0">A Materno:</p>
                        <asp:TextBox ID="txtAMaterno" onkeypress="return validaLetras(event);" runat="server" CssClass="form-control"
                            ViewStateMode="Disabled"></asp:TextBox>
                    </div>


                    <div>
                        <p class="m-0">CURP:</p>
                        <asp:TextBox ID="txtCurp" ValidationGroup="grupoValid" onkeypress="return validarSoloNumerosYLetras(event);" runat="server" CssClass="form-control"
                            ViewStateMode="Disabled"></asp:TextBox>
                    </div>

                    <div>
                        <p class="m-0">Fecha de nacimiento:</p>


                        <div class="d-flex">
                             <asp:TextBox ID="txtFechaNacimiento" CssClass="form-control" runat="server"></asp:TextBox>


                        <asp:ImageButton  ID="imgPopup" ImageUrl="Images/calendar.svg"
                            runat="server" CausesValidation="False" Width="25px"/>
                        </div>
                       


                        <ajaxToolkit:CalendarExtender ID="CalendarExtender1" PopupButtonID="imgPopup" Format="dd/MM/yyyy"
                            runat="server" TargetControlID="txtFechaNacimiento" />
                    </div>


                    <div class="mt-2 d-flex justify-content-between">
                        <asp:Button CssClass="btn btn-primary" ID="btnAceptar" OnClick="btnAceptar_Click" runat="server" Text="Aceptar"
                            ViewStateMode="Disabled" CausesValidation="True" />
                        <asp:Button ID="btnCancelar" CssClass="btn btn-danger" runat="server" Text="Cancelar"
                            OnClick="Redirigir" ViewStateMode="Disabled" CausesValidation="False" />
                    </div>
                </div>
            </div>













            <%--  --%>
            <asp:Label ID="Label1" CssClass="alert alert-danger" runat="server"  Visible="False"></asp:Label>
            <asp:RequiredFieldValidator CssClass="alert alert-danger" ValidationGroup="grupoValid" ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtCurp" ErrorMessage="Curp requerido"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator CssClass="alert alert-danger" ID="RegularExpressionValidator1" runat="server" ClientIDMode="AutoID" ControlToValidate="txtCurp" ErrorMessage="El CURP no cumple con las caracteristicas deseadas" ValidationExpression="^[A-Z]{1}[AEIOU]{1}[A-Z]{2}[0-9]{2}(0[1-9]|1[0-2])(0[1-9]|1[0-9]|2[0-9]|3[0-1])[HM]{1}(AS|BC|BS|CC|CS|CH|CL|CM|DF|DG|GT|GR|HG|JC|MC|MN|MS|NT|NL|OC|PL|QT|QR|SP|SL|SR|TC|TS|TL|VZ|YN|ZS|NE)[B-DF-HJ-NP-TV-Z]{3}[0-9A-Z]{1}[0-9]{1}$"></asp:RegularExpressionValidator>
            <asp:RequiredFieldValidator CssClass="alert alert-danger" ValidationGroup="grupoValid" ID="RequiredFieldValidator4" runat="server" ErrorMessage="Apellido materno es obligatorio" ControlToValidate="txtAMaterno"></asp:RequiredFieldValidator>
            <asp:RequiredFieldValidator CssClass="alert alert-danger" ValidationGroup="grupoValid" ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtClaveUnica" ErrorMessage="Clave es obligatorio "></asp:RequiredFieldValidator>
            <asp:RequiredFieldValidator CssClass="alert alert-danger" ID="RequiredFieldValidator3" ValidationGroup="grupoValid" runat="server" ErrorMessage="Apellido paterno es obligatorio" ControlToValidate="txtAPaterno"></asp:RequiredFieldValidator>
            
           



            <asp:RequiredFieldValidator CssClass="alert alert-danger" ValidationGroup="grupoValid"
                ID="RequiredFieldValidator2" runat="server" ErrorMessage="Nombre es obligatorio" ControlToValidate="txtNombre"></asp:RequiredFieldValidator>



            <asp:RangeValidator CssClass="m-0 alert alert-danger" ValidationGroup="grupoValid" ID="RangeValidator1" runat="server"
                ControlToValidate="ddlSexo" ErrorMessage="Selecciona un sexo obligatorio" MaximumValue="2"
                MinimumValue="0" Type="Integer"></asp:RangeValidator>


            <%--  --%>
        </form>




    </div>


</body>
</html>
