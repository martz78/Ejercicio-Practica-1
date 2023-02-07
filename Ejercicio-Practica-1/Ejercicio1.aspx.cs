using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicio_Practica_1
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //ocultamos el label resultado
            Mensaje.Visible = false;
        }

        protected void ButtonProcesar_Click(object sender, EventArgs e)
        {
            //apturando datos del formulario
            string nombreProducto = TextBox1.Text;
            string unidades = TextBox2.Text;
            string precio = TextBox3.Text;

            //Mostrar el mensaje
            Mensaje.Visible = true;
            Mensaje.InnerHtml = "<p>Hola</p>";
            Mensaje.InnerHtml += "El nombre del producto es " + nombreProducto;
            Mensaje.InnerHtml += ",tenemos"  + unidades +  "unidades disponibles";
            Mensaje.InnerHtml += " y tienen un precio de " + precio + " cada una";

            //limpiar textbox 
            ClearTexBox();
        }

        private void ClearTexBox()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
        }

        protected void ButtonBorrar_Click(object sender, EventArgs e)
        {
            Mensaje.InnerText = "";
        }
    }
}