using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YetzFlow.Core.Interface;

namespace YetzFlow.Core
{
    public class Campanha : ICampanha
    {
        private readonly string connstring;
        public Campanha(string _connstring)
        {
            connstring = _connstring;
        }
        public async Task<bool> Delete(int id)
        {
            return await new DB.Campanha(connstring).Delete(id);
        }

        public async Task<List<Entity.Campanha>> GetAll()
        {
            return await new DB.Campanha(connstring).GetAll();
        }

        public async Task<Entity.Campanha> GetId(int id)
        {
            return await new DB.Campanha(connstring).GetId(id);
        }

        public async Task<bool> Save(Entity.Campanha entity)
        {
            return await new DB.Campanha(connstring).Save(entity);
        }

        public async Task<bool> Update(Entity.Campanha entity)
        {
            return await new DB.Campanha(connstring).Update(entity);
        }
    }
}
