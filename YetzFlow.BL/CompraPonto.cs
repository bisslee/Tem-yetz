using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YetzFlow.Core.Interface;

namespace YetzFlow.Core
{
    public class CompraPonto : ICompraPonto
    {
        private readonly string connstring;
        public CompraPonto(string _connstring)
        {
            connstring = _connstring;
        }
        public async Task<bool> Delete(int id)
        {
            return await new DB.CompraPonto(connstring).Delete(id);
        }

        public async Task<List<Entity.CompraPonto>> GetAll()
        {
            return await new DB.CompraPonto(connstring).GetAll();
        }

        public async Task<Entity.CompraPonto> GetId(int id)
        {
            return await new DB.CompraPonto(connstring).GetId(id);
        }

        public async Task<bool> Save(Entity.CompraPonto entity)
        {
            return await new DB.CompraPonto(connstring).Save(entity);
        }

        public async Task<bool> Update(Entity.CompraPonto entity)
        {
            return await new DB.CompraPonto(connstring).Update(entity);
        }
    }
}
