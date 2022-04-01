<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UsuarioPrincipal.aspx.cs" Inherits="UTTT.Ejemplo.Persona.Usuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">

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


    <form id="form1" class="mt-5" runat="server">

        <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true">
        </asp:ScriptManager>

        <div class="container">

            <div class="card">
                <div class="card-header">
                    <h1 class="text-center">Usuarios</h1>
                </div>
                <div class="card-body">
                    <div class="row">
                        <div class=" mt-2 col-lg-8 col-sm-12 d-flex align-items-center justify-content-between">
                            <p class="m-0">
                                Nombre:
                            </p>

                           
                           

                            <asp:Button CssClass="btn btn-primary mr-10" ID="btnBuscar" runat="server" Text="Buscar"
                                OnClick="btnBuscar_Click" ViewStateMode="Disabled" />

                            <asp:Button CssClass="btn btn-success" ID="btnAgregar" runat="server" Text="Agregar"
                                OnClick="btnAgregar_Click" ViewStateMode="Disabled" />

                        </div>
                       
                    </div>
                </div>
            </div>



        </div>

















        <div class="container">
            <div class="card">
                <h4 class="text-center card-header">Detalle
                </h4>
                <div class="card-body">

                    <div class="row">
                        <div class="col-12 table-responsive">
                            <div class="d-flex justify-content-center">
                                <asp:GridView ID="dgvUsuarios" CssClass="table table-responsive table-striped" runat="server" AutoGenerateColumns="False" DataSourceID="LinqDataSource1" Width="379px">

                                    <Columns>



                                        <asp:BoundField DataField="id_usuario" HeaderText="id_usuario" ReadOnly="True" SortExpression="id_usuario" />
                                        <asp:BoundField DataField="nombre" HeaderText="nombre" ReadOnly="True" SortExpression="nombre" />
                                        <asp:BoundField DataField="contraseña" HeaderText="contraseña" ReadOnly="True" SortExpression="contraseña" />
                                        <asp:BoundField DataField="estado" HeaderText="estado" ReadOnly="True" SortExpression="estado" />
                                        <asp:BoundField DataField="perfil" HeaderText="perfil" ReadOnly="True" SortExpression="perfil" />

                                        <asp:TemplateField HeaderText="Editar">
                                            <ItemTemplate>
                                                <asp:ImageButton runat="server" ID="imgEditar" CommandName="Editar" CommandArgument='<%#Bind("id_usuario") %>' ImageUrl="~/Images/editrecord_16x16.png" />
                                            </ItemTemplate>
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <ItemStyle HorizontalAlign="Center" />

                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Eliminar" Visible="True">
                                            <ItemTemplate>
                                                <asp:ImageButton runat="server" ID="imgEliminar" CommandName="Eliminar" CommandArgument='<%#Bind("id_usuario")%>' ImageUrl="~/Images/delrecord_16x16.png" OnClientClick="javascript:return confirm('¿Está seguro de querer eliminar el registro seleccionado?', 'Mensaje de sistema')" />
                                            </ItemTemplate>
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <ItemStyle HorizontalAlign="Center" />
                                        </asp:TemplateField>



                                    </Columns>
                                </asp:GridView>
                                <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="UTTT.Ejemplo.Linq.Data.EntityMarket.DcMarketDataContext" EntityTypeName="" Select="new (id_usuario, nombre, contraseña, estado, perfil)" TableName="usuario">
                                </asp:LinqDataSource>
                            </div>
                        </div>
                    </div>



                </div>
            </div>
        </div>





    </form>
</body>
</html>
