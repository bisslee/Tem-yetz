using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace YetzFlow.Core.Interface
{
    public interface INotaFiscal
    {
        Task<List<Entity.NotaFiscal>> GetAll();
        Task<Entity.NotaFiscal> GetId(int id);
        Task<bool> Save(Entity.NotaFiscal entity);
        Task<bool> Update(Entity.NotaFiscal entity);
        Task<bool> Delete(int id);

    }
}
