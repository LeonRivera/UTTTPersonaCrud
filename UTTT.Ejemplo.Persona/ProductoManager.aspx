<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductoManager.aspx.cs" Inherits="UTTT.Ejemplo.Persona.ProductoManager" %>

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
    
    <form runat="server">

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
              <%if (Session["usuarioLogueado"] == null)
                  { %>
          <a href="/Login.aspx">  <button type="button" class="btn btn-outline-primary me-2">Login</button></a>
            <a  class="text-white" href="/Register.aspx">  <button type="button" class="btn btn-primary">Sign-up</button></a>
          <%}
              else
              { %>
              <asp:Button CssClass="btn btn-outline-danger me-2" ID="btnLogout" runat="server" Text="Logout"
                                OnClick="btnLogout_Click" ViewStateMode="Disabled" />
              <%} %>
          </div>
        </header>
     </div>

<div class="pricing-header px-3 py-3 pt-md-5 pb-md-4 mx-auto text-center">
      <h1 class="display-4">Producto</h1>
    </div>
        
    <div class="container">
        <div class="col-12 d-flex justify-content-center">
            <div class="card w-25">
                <div class="card-header text-center"><h2><i class="uil uil-user-circle"></i></h2></div>
                    <div class="card-body">
                        <div class="d-flex justify-content-between">
                            <div>
                                <div class="d-flex  align-content-center">
                                    <p>Nombre:</p>
                                    <asp:TextBox ID="txtNombre" CssClass="form-control"   runat="server" placeholder="nombre"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                    <hr />
                        <div>
                            <div class="d-flex justify-content-between">
                                <p>Precio:</p>
                                <asp:TextBox ID="txtPrecio" CssClass="form-control"  runat="server" placeholder="precio"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                <div class="card-footer">
                        <asp:Button CssClass="mt-3 btn w-100 h-75 btn-block btn-success" ID="Button1" runat="server" Text="Confirmar"
                             OnClick="editarProducto"    ViewStateMode="Disabled" />
                </div>
            

         </div>
    </div>
</div>
    
    <div class="container">
        
      <footer class="pt-4 my-md-5 pt-md-5 border-top">
        <div class="row">
          <div class="col-12 col-md">
            <img class="mb-2" src="https://getbootstrap.com/docs/4.0/assets/brand/bootstrap-solid.svg" alt="" width="24" height="24">
            <small class="d-block mb-3 text-muted">© 2017-2018</small>
          </div>
          <div class="col-6 col-md">
            <h5>Features</h5>
            <ul class="list-unstyled text-small">
              <li><a class="text-muted" href="#">Cool stuff</a></li>
              <li><a class="text-muted" href="#">Random feature</a></li>
              <li><a class="text-muted" href="#">Team feature</a></li>
              <li><a class="text-muted" href="#">Stuff for developers</a></li>
              <li><a class="text-muted" href="#">Another one</a></li>
              <li><a class="text-muted" href="#">Last time</a></li>
            </ul>
          </div>
          <div class="col-6 col-md">
            <h5>Resources</h5>
            <ul class="list-unstyled text-small">
              <li><a class="text-muted" href="#">Resource</a></li>
              <li><a class="text-muted" href="#">Resource name</a></li>
              <li><a class="text-muted" href="#">Another resource</a></li>
              <li><a class="text-muted" href="#">Final resource</a></li>
            </ul>
          </div>
          <div class="col-6 col-md">
            <h5>About</h5>
            <ul class="list-unstyled text-small">
              <li><a class="text-muted" href="#">Team</a></li>
              <li><a class="text-muted" href="#">Locations</a></li>
              <li><a class="text-muted" href="#">Privacy</a></li>
              <li><a class="text-muted" href="#">Terms</a></li>
            </ul>
          </div>
        </div>
      </footer>
    </div>
    
    </form>
    
</body>
</html>


