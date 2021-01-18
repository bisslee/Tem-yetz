using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YetzFlow.Core.Interface;

namespace YetzFlow.Core
{
    public class Voucher : IVoucher
    {
        private readonly string connstring;
        public Voucher(string _connstring)
        {
            connstring = _connstring;
        }
        public async Task<bool> Delete(int id)
        {
            return await new DB.Voucher(connstring).Delete(id);
        }

        public async Task<List<Entity.Voucher>> GetAll()
        {
            return await new DB.Voucher(connstring).GetAll();
        }

        public async Task<Entity.Voucher> GetId(int id)
        {
            return await new DB.Voucher(connstring).GetId(id);
        }

        public async Task<bool> Save(Entity.Voucher entity)
        {
            return await new DB.Voucher(connstring).Save(entity);
        }

        public async Task<bool> Update(Entity.Voucher entity)
        {
            return await new DB.Voucher(connstring).Update(entity);
        }
    }
}
