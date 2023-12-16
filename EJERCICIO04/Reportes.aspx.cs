using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace EJERCICIO04
{
	public partial class Usuarios : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack) 
			{
				LlenarGrid();
			}
		}

		protected void datagrid_SelectedIndexChanged(object sender, EventArgs e)
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
		protected void LlenarGrid()
		{
			string constr = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
			using (SqlConnection con = new SqlConnection(constr))
			{
				using (SqlCommand cmd = new SqlCommand("ReporteGeneral"))
				{
					using (SqlDataAdapter sda = new SqlDataAdapter())
					{
						cmd.Connection = con;
						sda.SelectCommand = cmd;
						using (DataTable dt = new DataTable())
						{
							sda.Fill(dt);
							datagrid.DataSource = dt;
							datagrid.DataBind();  // actualizar el grid view
						}
					}
				}
			}
		}





			
	}
}