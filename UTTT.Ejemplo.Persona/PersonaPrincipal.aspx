<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PersonaPrincipal.aspx.cs" Inherits="UTTT.Ejemplo.Persona.PersonaPrincipal" Debug="false" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">

    <title></title>
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
                    <h1 class="text-center">Persona</h1>
                </div>
                <div class="card-body">
                    <div class="row">
                        <div class=" mt-2 col-lg-8 col-sm-12 d-flex align-items-center justify-content-between">
                            <p class="m-0">
                                Nombre:
                            </p>

                            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control form-control-dark w-50"
                                ViewStateMode="Disabled" AutoPostBack="true" OnTextChanged="txtNombre_TextChanged"></asp:TextBox>
                            <ajaxToolkit:AutoCompleteExtender ID="AutoCompleteExtender1" runat="server" CompletionInterval="100"
                                MinimumPrefixLength="2" ServiceMethod="txtNombre_TextChanged" TargetControlID="txtNombre" EnableCaching="false">
                            </ajaxToolkit:AutoCompleteExtender>

                            <asp:Button CssClass="btn btn-primary mr-10" ID="btnBuscar" runat="server" Text="Buscar"
                                OnClick="btnBuscar_Click" ViewStateMode="Disabled" />

                            <asp:Button CssClass="btn btn-success" ID="btnAgregar" runat="server" Text="Agregar"
                                OnClick="btnAgregar_Click" ViewStateMode="Disabled" />

                        </div>
                        <div class="col-lg-4 mt-2 col-sm-12 d-flex align-items-center justify-content-center">
                            <p class="m-0 ">Sexo:</p>
                            <asp:DropDownList CssClass="form-control form-control-dark bg-primary text-white" ID="ddlSexo" runat="server">
                            </asp:DropDownList>

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
                            <div>
                                <asp:GridView ID="dgvPersonas" CssClass="table table-responsive" runat="server"
                                    AllowPaging="True" AutoGenerateColumns="False" DataSourceID="DataSourcePersona"
                                    Width="" CellPadding="3" GridLines="Horizontal"
                                    OnRowCommand="dgvPersonas_RowCommand" BackColor="White"
                                    BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px"
                                    ViewStateMode="Disabled">
                                    <AlternatingRowStyle BackColor="#F7F7F7" />
                                    <Columns>
                                        <asp:BoundField DataField="strClaveUnica" HeaderText="Clave Unica"
                                            ReadOnly="True" SortExpression="strClaveUnica" />
                                        <asp:BoundField DataField="strNombre" HeaderText="Nombre" ReadOnly="True"
                                            SortExpression="strNombre" />
                                        <asp:BoundField DataField="strAPaterno" HeaderText="APaterno" ReadOnly="True"
                                            SortExpression="strAPaterno" />
                                        <asp:BoundField DataField="strAMaterno" HeaderText="AMaterno" ReadOnly="True"
                                            SortExpression="strAMaterno" />
                                        <asp:BoundField DataField="strCURP" HeaderText="Curp" ReadOnly="True"
                                            SortExpression="strCURP" />
                                        <asp:BoundField DataField="CatSexo" HeaderText="Sexo"
                                            SortExpression="CatSexo" />

                                        <asp:TemplateField HeaderText="Editar">
                                            <ItemTemplate>
                                                <asp:ImageButton runat="server" ID="imgEditar" CommandName="Editar" CommandArgument='<%#Bind("id") %>' ImageUrl="~/Images/editrecord_16x16.png" />
                                            </ItemTemplate>
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <ItemStyle HorizontalAlign="Center" />

                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Eliminar" Visible="True">
                                            <ItemTemplate>
                                                <asp:ImageButton runat="server" ID="imgEliminar" CommandName="Eliminar" CommandArgument='<%#Bind("id")%>' ImageUrl="~/Images/delrecord_16x16.png" OnClientClick="javascript:return confirm('¿Está seguro de querer eliminar el registro seleccionado?', 'Mensaje de sistema')" />
                                            </ItemTemplate>
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <ItemStyle HorizontalAlign="Center" />
                                        </asp:TemplateField>

                                        <asp:TemplateField HeaderText="Direccion">
                                            <ItemTemplate>
                                                <asp:ImageButton runat="server" ID="imgDireccion" CommandName="Direccion" CommandArgument='<%#Bind("id")%>' ImageUrl="~/Images/editrecord_16x16.png" />
                                            </ItemTemplate>
                                            <HeaderStyle HorizontalAlign="Center" />
                                            <ItemStyle HorizontalAlign="Center" />

                                        </asp:TemplateField>
                                    </Columns>
                                    <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                                    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                                    <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                                    <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                                    <SortedAscendingCellStyle BackColor="#F4F4FD" />
                                    <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
                                    <SortedDescendingCellStyle BackColor="#D8D8F0" />
                                    <SortedDescendingHeaderStyle BackColor="#3E3277" />
                                </asp:GridView>
                            </div>
                        </div>
                    </div>



                </div>
            </div>
        </div>







        <asp:LinqDataSource ID="DataSourcePersona" runat="server"
            ContextTypeName="UTTT.Ejemplo.Linq.Data.Entity.DcGeneralDataContext"
            OnSelecting="DataSourcePersona_Selecting"
            Select="new (strNombre, strAPaterno, strAMaterno, CatSexo, strCURP,  strClaveUnica,id)"
            TableName="Persona" EntityTypeName="">
        </asp:LinqDataSource>



    </form>



</body>
</html>
