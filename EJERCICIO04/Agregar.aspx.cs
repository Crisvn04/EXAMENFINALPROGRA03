using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EJERCICIO04
{
	public partial class Tecnicos : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			
		}

		public void alertas(String texto)
		{
			string message = texto;
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("<script type = 'text/javascript'>");
			sb.Append("window.onload=function(){");
			sb.Append("alert('");
			sb.Append(message);
			sb.Append("')};");
			sb.Append("</script>");
			ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());

		}

	
		

		protected void BtnAgregar_Click(object sender, EventArgs e)
		{
			if (int.Parse(tEdad.Text) > 18 && int.Parse(tEdad.Text) < 50)
			{
				if (tCorreo.Text.Contains("@") && tCorreo.Text.Contains("."))
				{
				int retorno = Clases.Encuestas.Agregar(int.Parse(tEdad.Text), tNombre.Text, tCorreo.Text, tPartido.Text);
					if (retorno > 0)
					{
					alertas("Encuesta Agregada");

					}
					else
					{
						alertas("Error al agregar encuesta ");

					}
				}
			}
			else if (int.Parse(tEdad.Text) < 18 || int.Parse(tEdad.Text) > 50)
			{
				alertas("Error al agregar encuesta ");

			}
		}
	}
}