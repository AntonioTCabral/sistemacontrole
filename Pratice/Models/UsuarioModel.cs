using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using System.Configuration;


namespace Pratice.Models
{
    public class UsuarioModel
    {
        public int Id_Usuario { get; set; }
        public string Email_usuario { get; set; }
        public string NomeUsuario { get; set; }
        public string SenhaUsuario { get; set; }
        


        public string ValidaUsuario(string email, string senha)
        {
            //var localDB = ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;
            string localDB = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ControleBD;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;";
            string query = "select * from Usuario A where A.email_usuario = " + "'"+email+"'" + " and A.senha =" + "'"+senha+"'";
            SqlConnection conection = new SqlConnection(localDB);
            SqlCommand commander = new SqlCommand(query, conection);

           

            try
            {
                if (UsuarioExistente(email))
                {
                    conection.Open();
                    SqlDataReader reader = commander.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true.ToString();
                    }
                    else
                    {
                        ArgumentException exception = new ArgumentException("Usuario ou senha incorreta");
                        return exception.Message;
                    }

                }
                else
                {
                    return "Usuario não cadastrado";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                conection.Close();
            }

            
        }

        public bool UsuarioExistente(string email)
        {
            string localDB = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ControleBD;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;";
            string query = "select * from Usuario A where A.email_usuario = " + "'" + email + "'";

            //SqlConnection conn = new SqlConnection(localDB);
           

            using (SqlConnection conn = new SqlConnection(localDB))
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, conn);
                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if(conn != null)
                    {
                        conn.Dispose();
                    }
                }
            }
        }

        public UsuarioModel RetornaDadosUsuario(string email, string senha)
        {
            string localDB = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ControleBD;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;";
            string query = "select * from Usuario A where A.email_usuario = " + "'" + email + "'" + " and A.senha =" + "'" + senha + "'";
            SqlConnection conection = new SqlConnection(localDB);
            SqlCommand commander = new SqlCommand(query, conection);
            

            UsuarioModel cliente = new UsuarioModel();

            try
            {
                conection.Open();
                SqlDataReader leitor = commander.ExecuteReader();
                while (leitor.Read())
                {
                    //passo os valores para o objeto cliente 
                    //que será retornado 
                    cliente.Id_Usuario = Convert.ToInt32(leitor["id"].ToString());
                    cliente.NomeUsuario = leitor["nome_usuario"].ToString();
                    cliente.Email_usuario = leitor["senha"].ToString();
                    cliente.SenhaUsuario = leitor["email_usuario"].ToString();

                    
                }
                return cliente;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conection.Close();
            }
        }

    }
}
