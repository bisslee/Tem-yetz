using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YetzFlow.Core.Interface;

namespace YetzFlow.Core
{
    public class NotaFiscal : INotaFiscal
    {
        private readonly string connstring;
        public NotaFiscal(string _connstring)
        {
            connstring = _connstring;
        }
        public async Task<bool> Delete(int id)
        {
            return await new DB.NotaFiscal(connstring).Delete(id);
        }

        public async Task<List<Entity.NotaFiscal>> GetAll()
        {
            return await new DB.NotaFiscal(connstring).GetAll();
        }

        public async Task<Entity.NotaFiscal> GetId(int id)
        {
            return await new DB.NotaFiscal(connstring).GetId(id);
        }

        public async Task<bool> Save(Entity.NotaFiscal entity)
        {
            return await new DB.NotaFiscal(connstring).Save(entity);
        }

        public async Task<bool> Update(Entity.NotaFiscal entity)
        {
            return await new DB.NotaFiscal(connstring).Update(entity);
        }
    }
}
