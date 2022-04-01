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
    public partial class Register : System.Web.UI.Page
    {
        private DataContext dcGlobal = new DcMarketDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<string> perfiles = new List<string>();
                perfiles.Insert(0, "Seleccionar Perfil");
                perfiles.Insert(1, "cliente");
                perfiles.Insert(2, "vendedor");
                this.ddlPerfil.DataSource = perfiles;
                this.ddlPerfil.DataBind();
            }
           
        }
        
        protected void btnRegister_Click(object sender, EventArgs e)
        {

            var usuario = new usuario
            {
                nombre = txtEmail.Text,
                contraseña = Encrypt.encriptar(txtPassword.Text),
                estado = "activo",
                perfil = this.ddlPerfil.Text
            };
            dcGlobal.GetTable<usuario>().InsertOnSubmit(usuario);

            //despues de hacer esto mi usuario se pobla con el id creado;
            //despues debo insertar en vendedor o cliente de acuerdo al valor del perfil


            dcGlobal.SubmitChanges();
            this.Response.Redirect("~/Login.aspx");
        }
    }
}