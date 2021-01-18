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
    public class NotaFiscal : INotaFiscal
    {
        private readonly string connstring;
        public NotaFiscal(string _connstring)
        {
            connstring = _connstring;
        }

        #region Gets
        public async Task<List<Entity.NotaFiscal>> GetAll()
        {
            string sqlquery = @"SELECT IdNotasFiscal,IdPagador,Numero,Valor,DataEmissao,IdStatus,Observacao FROM NotasFiscais";

            return await Get(sqlquery, null);
        }

        public async Task<Entity.NotaFiscal> GetId(int id)
        {
            string sqlquery = @"SELECT IdNotasFiscal,IdPagador,Numero,Valor,DataEmissao,IdStatus,Observacao FROM NotasFiscais Where IdNotasFiscal = @IdNotasFiscal";
            SqlParameter[] parameters =
            {
                new SqlParameter("@IdNotasFiscal", SqlDbType.Int)
            };
            parameters[0].Value = id;
            var resp = await Get(sqlquery, parameters);
            return resp.First();
        }

        private async Task<List<Entity.NotaFiscal>> Get(string sqlquery, SqlParameter[] parameters)
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
                        List<Entity.NotaFiscal> entities = new List<Entity.NotaFiscal>();

                        while (dr.Read())
                        {
                            var entity = new Entity.NotaFiscal();
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
        public async Task<bool> Save(Entity.NotaFiscal entity)
        {
            string sqlquery = @"Delete FROM Pagadores Where IdPagador = @IdPagador";
            SqlParameter[] parameters =
            {
                new SqlParameter("@IdPagador", SqlDbType.Int)
            };

            //Pagador item

            return await ExecuteQuery(sqlquery, parameters);
        }
        public async Task<bool> Update(Entity.NotaFiscal entity)
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
            var entity = new Entity.NotaFiscal();

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

        private Entity.NotaFiscal LoadEntity(SqlDataReader dr)
        {
            var entity = new Entity.NotaFiscal();
            entity.IdNotasFiscal = Int32.Parse(dr["IdNotasFiscal"].ToString());
            entity.IdStatus = Int32.Parse(dr["IdStatus"].ToString());
            entity.IdPagador = Int32.Parse(dr["IdPagador"].ToString());            
            entity.Numero = Int32.Parse(dr["Numero"].ToString());
            entity.Observacao = dr["Observacao"].ToString();
            entity.DataEmissao = DateTime.Parse(dr["Numero"].ToString());
            entity.Valor = Double.Parse(dr["Numero"].ToString());
            
            return entity;
        }
    }
}
