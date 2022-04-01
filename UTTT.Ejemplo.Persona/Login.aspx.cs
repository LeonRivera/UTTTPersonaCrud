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
    public partial class Login : System.Web.UI.Page
    {
        private DataContext dcGlobal = new DcMarketDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogin_Click(object sender, EventArgs e) 
        {
            var usuario = dcGlobal.GetTable<usuario>().First(u => u.nombre == this.txtEmail.Text);
            if(Encrypt.encriptar(this.txtPassword.Text) == usuario.contraseña)
            {
                Session["usuarioLogueado"] = usuario;
                this.Response.Redirect("~/Home.aspx", false);
            }
        }
     
    }
}