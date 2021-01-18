using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YetzFlow.Core.Interface;

namespace YetzFlow.Core
{
    public class VendaDireta : IVendaDireta
    {
        private readonly string connstring;
        public VendaDireta(string _connstring)
        {
            connstring = _connstring;
        }
        public async Task<bool> Delete(int id)
        {
            return await new DB.VendaDireta(connstring).Delete(id);
        }

        public async Task<List<Entity.VendaDireta>> GetAll()
        {
            return await new DB.VendaDireta(connstring).GetAll();
        }

        public async Task<Entity.VendaDireta> GetId(int id)
        {
            return await new DB.VendaDireta(connstring).GetId(id);
        }

        public async Task<bool> Save(Entity.VendaDireta entity)
        {
            return await new DB.VendaDireta(connstring).Save(entity);
        }

        public async Task<bool> Update(Entity.VendaDireta entity)
        {
            return await new DB.VendaDireta(connstring).Update(entity);
        }
    }
}
