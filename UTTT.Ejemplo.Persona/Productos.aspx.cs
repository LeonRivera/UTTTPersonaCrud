using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UTTT.Ejemplo.Linq.Data.EntityMarket;
using UTTT.Ejemplo.Persona.Control.Ctrl;

namespace UTTT.Ejemplo.Persona
{
    public partial class Productos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                var data = new DcMarketDataContext();
                var usuarioSession = (usuario)Session["usuarioLogueado"];

                //Primero debo traer al vendedor mediante su id
                var vendedor = data.GetTable<vendedor>().First(v => v.id_usuario == usuarioSession.id_usuario);

                //Traigo los productos que corresponden a ese id
                var productos = data.GetTable<producto>().Where(u => u.id_vendedor == vendedor.id_vendedor);
                dgvProductos.DataSource = productos;
                dgvProductos.DataBind();
            }
            
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["usuarioLogueado"] = null;
            this.Response.Redirect("~/Login.aspx", false);
        }

        protected void redirectProductoManager(object sender, EventArgs e)
        {
            this.Response.Redirect("~/ProductoManager.aspx", false);
        }

        

        protected void dgvProductos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                int idProducto = int.Parse(e.CommandArgument.ToString());
                switch (e.CommandName)
                {
                    case "Editar":
                        this.editar(idProducto);
                        break;
                    case "Eliminar":
                        this.eliminar(idProducto);
                        break;
                    
                }
            }
            catch (Exception _e)
            {
                this.showMessage("Ha ocurrido un problema al seleccionar");
            }
        }

        public void editar(int idProducto)
        {
            Session["edit_Idproduct"] = idProducto;
            this.Response.Redirect("~/ProductoManager.aspx", false);
        }

        public void eliminar(int idProducto)
        {
            DataContext dcDelete = new DcMarketDataContext();
            var producto = dcDelete.GetTable<producto>().First(p => p.id_producto == idProducto);
            dcDelete.GetTable<producto>().DeleteOnSubmit(producto);
            dcDelete.SubmitChanges();
            this.Response.Redirect("~/Productos.aspx", false);
            this.showMessage("El registro se elimino correctamente.");
        }




    }
}