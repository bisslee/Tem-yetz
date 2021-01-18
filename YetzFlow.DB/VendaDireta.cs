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
    public class VendaDireta : IVendaDireta
    {
        private readonly string connstring;
        public VendaDireta(string _connstring)
        {
            connstring = _connstring;
        }

        #region Gets
        public async Task<List<Entity.VendaDireta>> GetAll()
        {
            string sqlquery = @"SELECT IdVendaDireta,IdCampanha,IdPagador,NumeroNota,Valor,DataEmissao,IdStatus,Observacao FROM VendasDiretas";

            return await Get(sqlquery, null);
        }

        public async Task<Entity.VendaDireta> GetId(int id)
        {
            string sqlquery = @"SELECT IdVendaDireta,IdCampanha,IdPagador,NumeroNota,Valor,DataEmissao,IdStatus,Observacao FROM VendasDiretas Where IdVendaDireta = @IdVendaDireta";
            SqlParameter[] parameters =
            {
                new SqlParameter("@IdVendaDireta", SqlDbType.Int)
            };
            parameters[0].Value = id;
            var resp = await Get(sqlquery, parameters);
            return resp.First();
        }

        private async Task<List<Entity.VendaDireta>> Get(string sqlquery, SqlParameter[] parameters)
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
                        List<Entity.VendaDireta> entities = new List<Entity.VendaDireta>();

                        while (dr.Read())
                        {
                            var entity = new Entity.VendaDireta();
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
        public async Task<bool> Save(Entity.VendaDireta entity)
        {
            string sqlquery = @"Delete FROM Pagadores Where IdPagador = @IdPagador";
            SqlParameter[] parameters =
            {
                new SqlParameter("@IdPagador", SqlDbType.Int)
            };

            //Pagador item

            return await ExecuteQuery(sqlquery, parameters);
        }
        public async Task<bool> Update(Entity.VendaDireta entity)
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
            var entity = new Entity.VendaDireta();

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

        private Entity.VendaDireta LoadEntity(SqlDataReader dr)
        {
            var entity = new Entity.VendaDireta();
            entity.IdVendaDireta = Int32.Parse(dr["IdPagador"].ToString());
            entity.IdPagador = Int32.Parse(dr["IdPagador"].ToString());
            entity.IdCampanha = Int32.Parse(dr["IdCampanha"].ToString());
            entity.NumeroNota = Int32.Parse(dr["NumeroNota"].ToString());
            entity.Valor = Double.Parse(dr["Valor"].ToString());
            entity.DataEmissao = DateTime.Parse(dr["DataEmissao"].ToString());
            entity.IdStatus= Int32.Parse(dr["IdStatus"].ToString());
            entity.Observacao = dr["Observacao"].ToString();
            
            return entity;
        }
    }
}
