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
    public class Campanha : ICampanha
    {
        private readonly string connstring;
        public Campanha(string _connstring)
        {
            connstring = _connstring;
        }

        #region Gets
        public async Task<List<Entity.Campanha>> GetAll()
        {
            string sqlquery = @"SELECT IdCampanha,Nome,NomeCliente,DataInicio,DataTermino,FatorConversao,Taxa FROM Campanhas";

            return await Get(sqlquery, null);
        }

        public async Task<Entity.Campanha> GetId(int id)
        {
            string sqlquery = @"SELECT IdCampanha,Nome,NomeCliente,DataInicio,DataTermino,FatorConversao,Taxa FROM Campanhas Where IdCampanha = @IdCampanha";
            SqlParameter[] parameters =
            {
                new SqlParameter("@IdCampanha", SqlDbType.Int)
            };
            parameters[0].Value = id;
            var resp = await Get(sqlquery, parameters);
            return resp.First();
        }

        private async Task<List<Entity.Campanha>> Get(string sqlquery, SqlParameter[] parameters)
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
                        List<Entity.Campanha> entities = new List<Entity.Campanha>();

                        while (dr.Read())
                        {
                            var entity = new Entity.Campanha();
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

            string sqlquery = @"update Campanhas set Ativo = 0 Where IdCampanha = @IdCampanha";
            SqlParameter[] parameters =
            {
                new SqlParameter("@IdCampanha", SqlDbType.Int)
            };
            parameters[0].Value = id;

            return await ExecuteQuery(sqlquery, parameters);
        }
        public async Task<bool> Save(Entity.Campanha entity)
        {
            string sqlquery = @"INSERT INTO Campanhas
                                   (Nome,NomeCliente,DataInicio,DataTermino,FatorConversao,Taxa,DataCriacao,IdUsuarioCriacao)
                             VALUES
                                   (@Nome,@NomeCliente,@DataInicio,@DataTermino,@FatorConversao,@Taxa,@DataCriacao,@IdUsuarioCriacao)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@Nome", SqlDbType.VarChar),
                new SqlParameter("@NomeCliente", SqlDbType.VarChar),                
                new SqlParameter("@DataInicio", SqlDbType.DateTime),
                new SqlParameter("@DataTermino", SqlDbType.DateTime),
                new SqlParameter("@FatorConversao", SqlDbType.Float),
                new SqlParameter("@Taxa", SqlDbType.Float),
                new SqlParameter("@DataAtualizacao", SqlDbType.DateTime),
                new SqlParameter("@IdUsuarioAtualizacao", SqlDbType.Int),
            };

            return await ExecuteQuery(sqlquery, parameters);
        }
        public async Task<bool> Update(Entity.Campanha entity)
        {
            string sqlquery = @"UPDATE Campanhas SET Nome = @Nome,NomeCliente = @NomeCliente
                                ,DataInicio = @DataInicio,DataTermino = @DataTermino
                                ,FatorConversao = @FatorConversao,Taxa = @Taxa,
                                ,DataAtualizacao = @DataAtualizacao
                                ,IdUsuarioAtualizacao = @IdUsuarioAtualizacao
                                Where IdCampanha = @IdCampanha";

            SqlParameter[] parameters =
            {
                new SqlParameter("@Nome", SqlDbType.VarChar),
                new SqlParameter("@NomeCliente", SqlDbType.VarChar),
                new SqlParameter("@IdCampanha", SqlDbType.Int),
                new SqlParameter("@DataInicio", SqlDbType.DateTime),
                new SqlParameter("@DataTermino", SqlDbType.DateTime),
                new SqlParameter("@FatorConversao", SqlDbType.Float),
                new SqlParameter("@Taxa", SqlDbType.Float),
                new SqlParameter("@DataAtualizacao", SqlDbType.DateTime),
                new SqlParameter("@IdUsuarioAtualizacao", SqlDbType.Int),
            };

            //Pagador item

            return await ExecuteQuery(sqlquery, parameters);
        }
        public async Task<bool> ExecuteQuery(string sqlquery, SqlParameter[] parameters)
        {
            var entity = new Entity.Campanha();

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

        private Entity.Campanha LoadEntity(SqlDataReader dr)
        {
            var entity = new Entity.Campanha();
            entity.IdCampanha = Int32.Parse(dr["IdCampanha"].ToString());
            entity.Nome = dr["Nome"].ToString();
            entity.NomeCliente = dr["NomeCliente"].ToString();
            entity.DataInicio = Convert.ToDateTime( dr["DataInicio"].ToString());
            entity.DataTermino = Convert.ToDateTime(dr["DataTermino"].ToString());
            entity.FatorConversao = Convert.ToDouble( dr["FatorConversao"].ToString());
            entity.Taxa = Convert.ToDouble(dr["Taxa"].ToString());

            return entity;
        }
    }
}
