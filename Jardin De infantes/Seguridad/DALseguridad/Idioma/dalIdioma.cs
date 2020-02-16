using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DALseguridad.Idioma
{
    public class dalIdioma
    {
        DataTable dt = new DataTable();
        SqlTransaction tx;
        public DataTable Leer(string texto)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(dalConexion.Cadena))
                {
                    cn.Open();
                    tx = cn.BeginTransaction();
                    SqlCommand cmd = new SqlCommand(texto, cn, tx);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    tx.Commit();
                    cn.Close();
                    return dt;
                }
            }
            catch (Exception e)
            {

                MessageBox.Show("Error en el Backup", e.Message,
                                MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                tx.Rollback();
                return null;
            }

        }

        public void Escribir(string texto)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(dalConexion.Cadena))
                {
                    cn.Open();
                    tx = cn.BeginTransaction();
                    SqlCommand cmd = new SqlCommand(texto, cn, tx);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    tx.Commit();

                }
            }
            catch (Exception e)
            {
                tx.Rollback();
                MessageBox.Show("Error en el Backup", e.Message,
                                MessageBoxButtons.OK, MessageBoxIcon.Error); ;

            }
        }
    }
}
