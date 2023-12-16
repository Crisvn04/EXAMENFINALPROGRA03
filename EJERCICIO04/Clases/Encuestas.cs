using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace EJERCICIO04.Clases
{
	public class Encuestas
	{
		public string NumeroEncuesta { get; set; }
		public string Nombre { get; set; }
		public int Edad { get; set; }
		public string Correo { get; set; }
		public string Partido { get; set; }

		public Encuestas(string NumEncuesta, string nombre, int edad, string correo, string partido)
		{
			NumeroEncuesta = NumEncuesta;
			Nombre = nombre;
			Edad = edad;
			Correo = correo;
			Partido = partido;

		}

		public static int Agregar(int Edad , string Nombre, string Correo, string Partido)
		{
			int retorno = 0;

			SqlConnection Conn = new SqlConnection();
			try
			{
				using (Conn = DBconn.obtenerConexion())
				{
					SqlCommand cmd = new SqlCommand("AgregarEleccion", Conn)
					{
						CommandType = CommandType.StoredProcedure
					};
					cmd.Parameters.Add(new SqlParameter("@Edad", Edad));
					cmd.Parameters.Add(new SqlParameter("@Nombre", Nombre));
					cmd.Parameters.Add(new SqlParameter("@Correo", Correo));
					cmd.Parameters.Add(new SqlParameter("@NombrePartido", Partido));

					retorno = cmd.ExecuteNonQuery();
				}
			}
			catch (System.Data.SqlClient.SqlException ex)
			{
				retorno = -1;
			}
			finally
			{
				Conn.Close();
			}

			return retorno;
		}
	}

}
