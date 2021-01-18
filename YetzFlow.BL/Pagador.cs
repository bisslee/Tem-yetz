using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YetzFlow.Core.Interface;

namespace YetzFlow.Core
{
    public class Pagador : IPagador
    {
        private readonly string connstring;
        public Pagador(string _connstring)
        {
            connstring = _connstring;
        }
        public async Task<bool> Delete(int id)
        {
            return await new DB.Pagador(connstring).Delete(id);
        }

        public async Task<List<Entity.Pagador>> GetAll()
        {
            return await new DB.Pagador(connstring).GetAll();
        }

        public async Task<Entity.Pagador> GetId(int id)
        {
            return await new DB.Pagador(connstring).GetId(id);
        }

        public async Task<bool> Save(Entity.Pagador entity)
        {
            return await new DB.Pagador(connstring).Save(entity);
        }

        public async Task<bool> Update(Entity.Pagador entity)
        {
            return await new DB.Pagador(connstring).Update(entity);
        }
    }
}
