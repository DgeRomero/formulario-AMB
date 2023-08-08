using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;

namespace Practica1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["Direcciones"] == null)
            {
                DireccionNegocio negocio = new DireccionNegocio();
                Session.Add("Direcciones", negocio.listar());
            }
            dvgDireccion.DataSource = Session["Direcciones"];
            dvgDireccion.DataBind();
            
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Session["hayDir"] != null)
            {
                Session.Remove("hayDir");
                Response.Redirect("Formulario.aspx");
            }
            else
            {
                Response.Redirect("Formulario.aspx");
            }
            
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            string calle = (string)Session["calle"];
            Response.Redirect("Formulario.aspx?calle=" + calle);
        }

        protected void dvgDireccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string calle = dvgDireccion.SelectedDataKey.Value.ToString();
            bool hayDir = true;
            Session.Add("calle", calle);
            Session.Add("hayDir", hayDir);
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            string calle = dvgDireccion.SelectedDataKey.Value.ToString();
            List<Direccion> lista = (List<Direccion>)Session["Direcciones"];
            Direccion seleccionada = lista.Find(x => x.Calle == calle);

            lista.Remove(seleccionada);
           

            Response.Redirect("Default.aspx");
        }
    }
}