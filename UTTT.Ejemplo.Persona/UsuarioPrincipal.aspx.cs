using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UTTT.Ejemplo.Linq.Data.Entity;
using UTTT.Ejemplo.Linq.Data.EntityMarket;
using UTTT.Ejemplo.Linq.Data.Properties;

namespace UTTT.Ejemplo.Persona
{
    public partial class Usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
            }
        }

        private void GetUsuarios()
        {
            //var data = new Linq.Data.EntityMarket.DcMarketDataContext();
            ////var data = new DcMarketDataContext();
            //dgvUsuarios.DataSource = data.GetTable<usuario>();
            //dgvUsuarios.DataBind();
        }


        protected void btnBuscar_Click(object sender, EventArgs e)
        {
           
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            
        }
    }
}