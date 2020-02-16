using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using MPPSeguridad;
using System.Data;
using System.Windows.Forms;

namespace DALseguridad.Backup
{

    public class dalBackup
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
                    SqlCommand cmd = new SqlCommand(texto,cn,tx);
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
                tx.Rollback();
                MessageBox.Show("Error en el Backup",e.Message ,
                                MessageBoxButtons.OK, MessageBoxIcon.Error); ;
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
        public void EscribirSinTX(string texto)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(dalConexion.Cadena))
                {
                    cn.Open();
                    
                    SqlCommand cmd = new SqlCommand(texto, cn, tx);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    

                }
            }
            catch (Exception e)
            {
               
                MessageBox.Show("Error en el Backup", e.Message,
                                MessageBoxButtons.OK, MessageBoxIcon.Error); ;

            }
        }
    }
}
