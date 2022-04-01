<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UTTT.Ejemplo.Persona.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <link rel="stylesheet" href="https://unicons.iconscout.com/release/v4.0.0/css/line.css">
     <link  rel="stylesheet" href="css/styles.css"/ >
</head>
<body >


    <div class="container">
        <header class="d-flex flex-wrap align-items-center justify-content-center justify-content-md-between py-3 mb-4 border-bottom">
          <a href="/" class="d-flex align-items-center col-md-3 mb-2 mb-md-0 text-dark text-decoration-none">
            <i class="uil uil-amazon"></i>
          </a>

          <ul class="nav col-12 col-md-auto mb-2 justify-content-center mb-md-0">
            <li><a href="#" class="nav-link px-2 link-secondary">Home</a></li>
            <li><a href="#" class="nav-link px-2 link-dark">Features</a></li>
            <li><a href="#" class="nav-link px-2 link-dark">Pricing</a></li>
            <li><a href="#" class="nav-link px-2 link-dark">FAQs</a></li>
            <li><a href="#" class="nav-link px-2 link-dark">About</a></li>
          </ul>

          <div class="col-md-3 text-end">
          <a href="/Login.aspx">  <button type="button" class="btn btn-outline-primary me-2">Login</button></a>
            <a  class="text-white" href="/Register.aspx">  <button type="button" class="btn btn-primary">Sign-up</button></a>
          </div>
        </header>
     </div>

    <div class="container">
        <div class="row ">
            <div class="col-12 mt-5 d-flex justify-content-center">
                
                <form class="card col-sm-4 col-md-6 col-lg-4 p-3" id="form1" runat="server">

                    <div class="card-header mb-2 d-flex justify-content-center"><i class="uil uil-amazon"></i></div>

                    <div class="form-outline mb-4">
                        <%--<label class="form-label" for="form2Example1">Email address</label>--%>
                        <asp:TextBox ID="txtEmail" CssClass="form-control" TextMode="Email" runat="server" placeholder="Email"></asp:TextBox>
                        
                    </div>

                    <div class="form-outline mb-4">
                        <%--<label class="form-label" for="form2Example2">Password</label>--%>

                        <asp:TextBox ID="txtPassword" CssClass="form-control" TextMode="Password" runat="server" placeholder="Password"></asp:TextBox>
                    </div>

                    <div class="row mb-4">

                        <div class="col text-center">
                            <a  href="#!">Olvidaste tu contraseña?</a>
                        </div>
                    </div>


                    <asp:Button CssClass="btn btn-primary btn-block h-100 mb-4" ID="btnAgregar" runat="server" Text="Sign In"
                                OnClick="btnLogin_Click" ViewStateMode="Disabled" />

                    <hr />
                    <div class="d-flex justify-content-center">
                   


                        <asp:Button CssClass="mt-3 btn w-50 h-75 btn-block btn-success" ID="Button1" runat="server" Text="Registrarse"
                                ViewStateMode="Disabled" />
                    </div>
                </form>
            </div>
        </div>

    </div>

</body>
</html>
