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
    public class CompraPonto : ICompraPonto
    {
        private readonly string connstring;
        public CompraPonto(string _connstring)
        {
            connstring = _connstring;
        }

        #region Gets
        public async Task<List<Entity.CompraPonto>> GetAll()
        {
            string sqlquery = @"SELECT IdCompraPonto,IdCampanha,IdTipoCredito,IdObservacao,Unidades,Pontos,TotalPontos,ValorYetz,ValorPontos,ValorTotal   FROM CompraPontos";

            return await Get(sqlquery, null);
        }

        public async Task<Entity.CompraPonto> GetId(int id)
        {
            string sqlquery = @"SELECT IdCompraPonto,IdCampanha,IdTipoCredito,IdObservacao,Unidades,Pontos,TotalPontos,ValorYetz,ValorPontos,ValorTotal   FROM CompraPontos Where IdCompraPonto = @IdCompraPonto";
            SqlParameter[] parameters =
            {
                new SqlParameter("@IdCompraPonto", SqlDbType.Int)
            };
            parameters[0].Value = id;
            var resp = await Get(sqlquery, parameters);
            return resp.First();
        }

        private async Task<List<Entity.CompraPonto>> Get(string sqlquery, SqlParameter[] parameters)
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
                        List<Entity.CompraPonto> entities = new List<Entity.CompraPonto>();

                        while (dr.Read())
                        {
                            var entity = new Entity.CompraPonto();
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
            string sqlquery = @"Delete FROM Pagadores Where IdPagador = @IdPagador";
            SqlParameter[] parameters =
            {
                new SqlParameter("@IdPagador", SqlDbType.Int)
            };
            parameters[0].Value = id;

            return await ExecuteQuery(sqlquery, parameters);
        }
        public async Task<bool> Save(Entity.CompraPonto entity)
        {
            string sqlquery = @"Delete FROM Pagadores Where IdPagador = @IdPagador";
            SqlParameter[] parameters =
            {
                new SqlParameter("@IdPagador", SqlDbType.Int)
            };

            //Pagador item

            return await ExecuteQuery(sqlquery, parameters);
        }
        public async Task<bool> Update(Entity.CompraPonto entity)
        {
            string sqlquery = @"Delete FROM Pagadores Where IdPagador = @IdPagador";
            SqlParameter[] parameters =
            {
                new SqlParameter("@IdPagador", SqlDbType.Int)
            };

            //Pagador item

            return await ExecuteQuery(sqlquery, parameters);
        }
        public async Task<bool> ExecuteQuery(string sqlquery, SqlParameter[] parameters)
        {
            var entity = new Entity.CompraPonto();

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

        private Entity.CompraPonto LoadEntity(SqlDataReader dr)
        {
            var entity = new Entity.CompraPonto();
            entity.IdCompraPonto = Int32.Parse(dr["IdCompraPonto"].ToString());
            entity.IdCampanha = Int32.Parse(dr["IdCampanha"].ToString());
            entity.IdTipoCredito = Int32.Parse(dr["IdTipoCredito"].ToString());
            entity.IdObservacao = Int32.Parse(dr["IdObservacao"].ToString());
            entity.Unidades = Int32.Parse(dr["Unidades"].ToString());
            entity.Pontos = Int64.Parse(dr["Pontos"].ToString());
            entity.TotalPontos = Double.Parse(dr["Pontos"].ToString());
            entity.ValorYetz = Double.Parse(dr["ValorYetz"].ToString());
            entity.ValorPontos = Double.Parse(dr["ValorPontos"].ToString());
            entity.ValorTotal = Double.Parse(dr["ValorTotal"].ToString());
            return entity;
        }
    }
}
