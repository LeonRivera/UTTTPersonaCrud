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
    public partial class EditarUsuario : System.Web.UI.Page
    {
        private DataContext dcGlobal = new DcMarketDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuarioLogueado"] == null) this.Response.Redirect("~/Login.aspx", false);


            //devolver el drop down con la primera opcion el valor desde base y la segunda
            //la otra ponerlo con un if dependiendo de que haya
            if (!this.IsPostBack)
            {
                var usuario = (usuario)Session["usuarioLogueado"];
                txtEmail.Text = usuario.nombre;
                txtPassword.Text = usuario.contraseña;
                txtDireccion.Text = usuario.direccion;
                txtPerfil.Text = usuario.perfil;
            }

            string hola = "hola";
        }
        public usuario getUsuario()
        {
            return (usuario)Session["usuarioLogueado"]; ;
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["usuarioLogueado"] = null;
            this.Response.Redirect("~/Login.aspx", false);
        }

        protected void editarUsuario(object sender, EventArgs e)
        {
            var usuarioSession = (usuario) Session["usuarioLogueado"];
            var usuario = dcGlobal.GetTable<usuario>().First(u => u.nombre == usuarioSession.nombre);
            usuario.nombre = txtEmail.Text.Trim();
            usuario.contraseña = Encrypt.encriptar(txtPassword.Text);
            usuario.direccion = txtDireccion.Text.Trim();
            //perfil = this.ddlPerfil.Text
            usuario.perfil = txtPerfil.Text.Trim();
            dcGlobal.SubmitChanges();
            Session["usuarioLogueado"] = usuario;
            this.Response.Redirect("~/Home.aspx", false);

        }
    }
}