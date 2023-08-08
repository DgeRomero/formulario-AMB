using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;

namespace Practica1
{
    public partial class Formulario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (Session["calle"] != null)
                {
                    string calle = Session["calle"].ToString();
                    List<Direccion> temporal = (List<Direccion>)Session["Direcciones"];
                    Direccion seleccionada = temporal.Find(x => x.Calle == calle);
                    if(seleccionada != null)
                    {
                        txtCalle.Text = seleccionada.Calle;
                        txtAltura.Text = seleccionada.Altura.ToString();
                    }
                    
                }
            }

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            List<Direccion> temporal = (List<Direccion>)Session["Direcciones"];

            if (Session["calle"] != null && Session["hayDir"] != null)
            {
                string calle = Session["calle"].ToString();
                Direccion seleccionada;
                
                seleccionada = temporal.Find(x => x.Calle == calle);

                if(seleccionada != null)
                {
                    seleccionada.Calle = txtCalle.Text;
                    seleccionada.Altura = int.Parse(txtAltura.Text);
                }               
            }
            else
                {
                    Direccion d = new Direccion();
                    d.Calle = txtCalle.Text;
                    d.Altura = int.Parse(txtAltura.Text);
                    temporal.Add(d);
                }
                

            

            Response.Redirect("Default.aspx");

        }
    }
}