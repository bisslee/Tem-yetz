using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YetzFlow.DB.Interface;

namespace YetzFlow.DB
{
    public class Pagador : IPagador
    {
        private readonly string connstring;
        public Pagador(string _connstring)
        {
            connstring = _connstring;
        }

        #region Gets
        public async Task<List<Entity.Pagador>> GetAll()
        {
            string sqlquery = @"SELECT IdPagador,Nome,Email,Contato,CNPJ,Telefone,Celular FROM Pagadores";

            return await Get(sqlquery, null);
        }

        public async Task<Entity.Pagador> GetId(int id)
        {
            string sqlquery = @"SELECT IdPagador,Nome,Email,Contato,CNPJ,Telefone,Celular FROM Pagadores Where IdPagador = @IdPagador";
            SqlParameter[] parameters =
            {
                new SqlParameter("@IdPagador", SqlDbType.Int)
            };
            parameters[0].Value = id;
            var resp = await Get(sqlquery, parameters);
            return resp.First();
        }

        private async Task<List<Entity.Pagador>> Get(string sqlquery, SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                using (SqlCommand cmd = new SqlCommand(sqlquery, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    conn.Open();

                    var dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        List<Entity.Pagador> entities = new List<Entity.Pagador>();

                        while (dr.Read())
                        {
                            var entity = new Entity.Pagador();
                            entity = LoadEntity(dr);
                            entities.Add(entity);
                        }
                        return await Task.FromResult(entities);
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }
        #endregion Gets

        #region Executes
        public async Task<bool> Delete(int id)
        {
            string sqlquery = @"update Pagadores set Ativo = 0 Where IdPagador = @IdPagador";
            SqlParameter[] parameters =
            {
                new SqlParameter("@IdPagador", SqlDbType.Int)
            };
            parameters[0].Value = id;

            return await ExecuteQuery(sqlquery, parameters); 
        }
        public async Task<bool> Save(Entity.Pagador entity)
        {
            string sqlquery = @"INSERT INTO Pagadores   
                                (Nome,Email,Contato,CNPJ,Telefone,Celular,DataCriacao,IdUsuarioCriacao)
                                VALUES
                                (@Nome,@Email,@Contato,@CNPJ,@Telefone,@Celular,@DataCriacao,@IdUsuarioCriacao)" ;
            SqlParameter[] parameters =
            {   new SqlParameter("@Nome", SqlDbType.VarChar),
                new SqlParameter("@Email", SqlDbType.VarChar),
                new SqlParameter("@Contato", SqlDbType.VarChar),
                new SqlParameter("@CNPJ", SqlDbType.VarChar),
                new SqlParameter("@Telefone", SqlDbType.VarChar),
                new SqlParameter("@Celular", SqlDbType.VarChar),
                new SqlParameter("@DataCriacao", SqlDbType.DateTime),
                new SqlParameter("@IdUsuarioCriacao", SqlDbType.Int),
            };
            parameters[0].Value = entity.Nome;
            parameters[1].Value = entity.Email;
            parameters[2].Value = entity.Contato;
            parameters[3].Value = entity.CNPJ;
            parameters[4].Value = entity.Telefone;
            parameters[5].Value = entity.Celular;
            parameters[6].Value = DateTime.Now;
            parameters[7].Value = entity.IdUsuarioCriacao;


            //Pagador item

            return await ExecuteQuery(sqlquery, parameters);
        }
        public async Task<bool> Update(Entity.Pagador entity)
        {
            string sqlquery = @"UPDATE Pagadores SET Nome = @Nome, Email = @Email,Contato =@Contato
                                ,CNPJ = @CNPJ, Telefone = @Telefone, Celular = @Celular
                                ,DataAtualizacao = @DataAtualizacao, IdUsuarioAtualizacao = @IdUsuarioAtualizacao
                                Where IdPagador = @IdPagador";
            SqlParameter[] parameters =
            {
                new SqlParameter("@IdPagador", SqlDbType.Int),
                new SqlParameter("@Nome", SqlDbType.VarChar),
                new SqlParameter("@Email", SqlDbType.VarChar),
                new SqlParameter("@Contato", SqlDbType.VarChar),
                new SqlParameter("@CNPJ", SqlDbType.VarChar),
                new SqlParameter("@Telefone", SqlDbType.VarChar),
                new SqlParameter("@Celular", SqlDbType.VarChar),
                new SqlParameter("@DataAtualizacao", SqlDbType.DateTime),
                new SqlParameter("@IdUsuarioAtualizacao", SqlDbType.Int),
            };
            parameters[0].Value = entity.IdPagador;
            parameters[1].Value = entity.Nome;
            parameters[2].Value = entity.Email;
            parameters[3].Value = entity.Contato;
            parameters[4].Value = entity.CNPJ;
            parameters[5].Value = entity.Telefone;
            parameters[6].Value = entity.Celular;
            parameters[7].Value = DateTime.Now;
            parameters[8].Value = entity.IdUsuarioAtualizacao;


            return await ExecuteQuery(sqlquery, parameters);
        }
        public async Task<bool> ExecuteQuery(string sqlquery, SqlParameter[] parameters)
        {
            var entity = new Entity.Pagador();

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

                        conn.Open();

                        var result = cmd.ExecuteNonQuery();

                        return await Task.FromResult(result > 0);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion Executes

        private Entity.Pagador LoadEntity(SqlDataReader dr)
        {
            var entity = new Entity.Pagador();
            entity.IdPagador = Int32.Parse(dr["IdPagador"].ToString());
            entity.Nome = dr["Nome"].ToString();
            entity.Contato = dr["Contato"].ToString();
            entity.CNPJ = dr["CNPJ"].ToString();
            entity.Email = dr["Email"].ToString();
            entity.Celular = dr["Celular"].ToString();
            entity.Telefone = dr["Telefone"].ToString();

            return entity;
        }
    }
}
