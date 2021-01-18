using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using YetzFlow.DB.Interface;

namespace YetzFlow.DB
{
    public class Usuario : IUsuario
    {
        private readonly string connstring;
        public Usuario(string _connstring)
        {
            connstring = _connstring;
        }
        public async Task<Entity.Usuario> Login(string email, string senha)
        {
            string sqlquery = @"select * from Usuarios where email = @email and senha=@senha";

            SqlParameter[] parameters =
                {
                    new SqlParameter("@email", SqlDbType.VarChar,100),
                    new SqlParameter("@senha", SqlDbType.VarChar,50)
                };

            try
            {
                using (SqlConnection conn = new SqlConnection(connstring))
                {
                    using (SqlCommand cmd = new SqlCommand(sqlquery, conn))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }
                        parameters[0].Value = email;
                        parameters[1].Value = senha;
                        conn.Open();

                        var dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            Entity.Usuario usuario = new Entity.Usuario();

                            while (dr.Read())
                            {
                                usuario = LoadCliente(dr);

                            }
                            return await Task.FromResult(usuario);
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        public async Task<Entity.Usuario> NewPassowrd(string email, string novaSenha)
        {
            var usuario = new Entity.Usuario();
            string sqlquery = @"update Usuarios set senha=@novaSenha where email = @email";

            SqlParameter[] parameters =
                {
                    new SqlParameter("@email", SqlDbType.VarChar,100),
                    new SqlParameter("@novaSenha", SqlDbType.VarChar,50)
                };

            try
            {
                using (SqlConnection conn = new SqlConnection(connstring))
                {
                    using (SqlCommand cmd = new SqlCommand(sqlquery, conn))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }
                        parameters[0].Value = email;
                        parameters[1].Value = novaSenha;
                        conn.Open();

                        var result = cmd.ExecuteNonQuery();
                        if (result > 0 )
                        {
                            usuario = Login(email, novaSenha).Result;                            
                        }
                        return await Task.FromResult(usuario);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private Entity.Usuario LoadCliente(SqlDataReader dr)
        {
            var usuario = new Entity.Usuario();
            usuario.IdUsuario = Int32.Parse(dr["IdUsuario"].ToString());
            usuario.Nome = dr["Nome"].ToString();            
            usuario.Email = dr["Email"].ToString();
            
            return usuario;
        }
    }
}
