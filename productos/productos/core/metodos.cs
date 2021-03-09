using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace productos.core
{
    public class metodos
    {
        public static string getConnection
        {
            get
            {
                return getPropertyConfig("ConnectionDB");
            }
        }

        public static string getPropertyConfig(string property)
        {

            try
            {
                String ls_retorno = WebConfigurationManager.AppSettings[property];

                if (ls_retorno != null && ls_retorno.Trim().Length > 0)
                    return ls_retorno;

                String[] lls_servicios = HttpContext.Current.Request.ServerVariables["PATH_INFO"].ToString().Split('/');

                System.Configuration.Configuration leerWebConfig = WebConfigurationManager.OpenWebConfiguration(String.Concat("/", lls_servicios[1], "/"));

                if (0 < leerWebConfig.AppSettings.Settings.Count)
                {

                    System.Configuration.KeyValueConfigurationElement UserSettings = leerWebConfig.AppSettings.Settings[property];

                    if (null != UserSettings)
                        property = UserSettings.Value;
                    else
                        property = "";
                }
            }
            catch (Exception e)
            {
                Exception error = new Exception("Error de lectura para la propiedad: " + property + "||" + e.Message);
                throw (error);
            }
            return property;
        }

        public static int loginUsuario(String email, String clave)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet dt = new DataSet();
            SqlConnection con = new SqlConnection(getConnection);

            cmd = new SqlCommand("autentica_usuario", con);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@clave", SqlDbType.VarChar).Value = clave;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;
            da.SelectCommand = cmd;

            da.Fill(dt);
            cmd.Dispose();

            int resp = 0;

            if (dt.Tables[0].Rows.Count != 0)
            {
                resp = Convert.ToInt32(dt.Tables[0].Rows[0]["id_us"]);
            }

            return resp;
        }


        public static DataSet devuelveprod()
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet dt = new DataSet();
            SqlConnection con = new SqlConnection(getConnection);

            cmd = new SqlCommand("devuelveproductos", con);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;
            da.SelectCommand = cmd;

            da.Fill(dt);
            cmd.Dispose();

            return dt;
        }

    }
}