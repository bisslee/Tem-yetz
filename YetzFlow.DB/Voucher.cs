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
    public class Voucher : IVoucher
    {
        private readonly string connstring;
        public Voucher(string _connstring)
        {
            connstring = _connstring;
        }
        #region Gets
        public async Task<List<Entity.Voucher>> GetAll()
        {
            string sqlquery = @"SELECT IdVoucher,Nome,IdTipo,IdOrigem,CodigoPlataforma,Valor FROM Vouchers";

            return await Get(sqlquery, null);
        }

        public async Task<Entity.Voucher> GetId(int id)
        {
            string sqlquery = @"SELECT IdVoucher,Nome,IdTipo,IdOrigem,CodigoPlataforma,Valor FROM Vouchers Where IdVoucher = @IdVoucher";
            SqlParameter[] parameters =
            {
                new SqlParameter("@IdVoucher", SqlDbType.Int)
            };
            parameters[0].Value = id;
            var resp = await Get(sqlquery, parameters);
            return resp.First();
        }

        private async Task<List<Entity.Voucher>> Get(string sqlquery, SqlParameter[] parameters)
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
                        List<Entity.Voucher> entities = new List<Entity.Voucher>();

                        while (dr.Read())
                        {
                            var entity = new Entity.Voucher();
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
        public async Task<bool> Save(Entity.Voucher entity)
        {
            string sqlquery = @"Delete FROM Pagadores Where IdPagador = @IdPagador";
            SqlParameter[] parameters =
            {
                new SqlParameter("@IdPagador", SqlDbType.Int)
            };

            //Pagador item

            return await ExecuteQuery(sqlquery, parameters);
        }
        public async Task<bool> Update(Entity.Voucher entity)
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
            var entity = new Entity.Voucher();

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

        private Entity.Voucher LoadEntity(SqlDataReader dr)
        {
            var entity = new Entity.Voucher();
            entity.IdVoucher = Int32.Parse(dr["IdVoucher"].ToString());
            entity.Nome = dr["Nome"].ToString();
            entity.CodigoPlataforma = Int32.Parse(dr["CodigoPlataforma"].ToString());
            entity.IdOrigem = Int32.Parse(dr["IdOrigem"].ToString());
            entity.IdTipo = Int32.Parse(dr["IdTipo"].ToString());
            entity.Valor = Double.Parse(dr["Valor"].ToString()); 

            return entity;
        }
    }
}
