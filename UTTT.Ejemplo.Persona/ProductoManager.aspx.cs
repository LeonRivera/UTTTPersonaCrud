using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UTTT.Ejemplo.Linq.Data.EntityMarket;

namespace UTTT.Ejemplo.Persona
{
    public partial class ProductoManager : System.Web.UI.Page
    {

        private DataContext dcGlobal = new DcMarketDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {

                var usuarioSession = (usuario)Session["usuarioLogueado"];

                //Primero debo traer al vendedor mediante su id
                var vendedor = dcGlobal.GetTable<vendedor>().First(v => v.id_usuario == usuarioSession.id_usuario);

                int idProductoSession;
                try
                {
                    idProductoSession = (int)Session["edit_Idproduct"];
                }
                catch(Exception _e)
                {
                    idProductoSession = 0;
                }

                //me traigo el producto con este id
                if (idProductoSession > 0)
                {
                    var producto = dcGlobal.GetTable<producto>().First(p => p.id_producto == idProductoSession);

                    txtNombre.Text = producto.nombre;
                    txtPrecio.Text = producto.precio.ToString();
                }
                
                
            }
        }
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["usuarioLogueado"] = null;
            this.Response.Redirect("~/Login.aspx", false);
        }
        protected void editarProducto(object sender, EventArgs e)
        {
            int idProductoSession = 0;
            try
            {
                idProductoSession = (int)Session["edit_Idproduct"];
            }catch(Exception _e)
            {

            }

            if(idProductoSession != 0)
            {
                var usuarioSession = (usuario)Session["usuarioLogueado"];

                //Primero debo traer al vendedor mediante su id
                var vendedor = dcGlobal.GetTable<vendedor>().First(v => v.id_usuario == usuarioSession.id_usuario);



                //me traigo el producto con este id
                var producto = dcGlobal.GetTable<producto>().First(p => p.id_producto == idProductoSession);

                producto.nombre = txtNombre.Text.Trim();
                producto.precio = int.Parse(txtPrecio.Text.Trim());
                producto.id_vendedor = vendedor.id_vendedor;





                dcGlobal.SubmitChanges();
            }
            else
            {

                //debo buscar el id del vendedor

                var usuarioSession = (usuario)Session["usuarioLogueado"];

                //Primero debo traer al vendedor mediante su id
                var vendedor = dcGlobal.GetTable<vendedor>().First(v => v.id_usuario == usuarioSession.id_usuario);

                var producto = new producto
                {
                    nombre = txtNombre.Text,
                    precio = int.Parse(txtPrecio.Text),
                    id_vendedor = vendedor.id_vendedor
                };
                dcGlobal.GetTable<producto>().InsertOnSubmit(producto);

                //despues de hacer esto mi usuario se pobla con el id creado;
                //despues debo insertar en vendedor o cliente de acuerdo al valor del perfil


                dcGlobal.SubmitChanges();
            }


            
            this.Response.Redirect("~/Productos.aspx", false);
        }

    }
}