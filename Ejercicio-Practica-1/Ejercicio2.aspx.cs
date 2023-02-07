using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicio_Practica_1
{
    public partial class Ejercicio2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //ocultamos el label resultado
            Mensaje.Visible = false;
        }

        protected void ButtonProcesar_Click(object sender, EventArgs e)
        {
            string Usuario, Contraseña;
            Usuario = TextBox1.Text;
            Contraseña = TextBox2.Text;
            Mensaje.Visible = true;
            if (Usuario == "Esme" && Contraseña == "hola")
            {
                Mensaje.InnerHtml = "¡¡¡El inicio de sesion fue exitoso!!!";
            }
            else
            {
                Mensaje.InnerHtml = "No se puedo iniciar sesion, vuelva a intentarlo";
            }
        }
    }
}