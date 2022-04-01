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
    public partial class Home : System.Web.UI.Page
    {

        private DataContext dcGlobal = new DcMarketDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["usuarioLogueado"] == null)this.Response.Redirect("~/Login.aspx", false);

        }

        public List<producto> devolverProductos()
        {
            return dcGlobal.GetTable<producto>().ToList(); 
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["usuarioLogueado"] = null;
            this.Response.Redirect("~/Login.aspx", false);
        }

        public usuario getUsuario()
        {
            return (usuario) Session["usuarioLogueado"]; ;
        }

        protected void redirectEdit(object sender, EventArgs e)
        {
            this.Response.Redirect("~/EditarUsuario.aspx", false);

        }

        protected void redirectProductos(object sender, EventArgs e)
        {
            this.Response.Redirect("~/Productos.aspx", false);

        }
    }
}