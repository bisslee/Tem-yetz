using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace YetzFlow.Core.Interface
{
    public interface IVendaDireta
    {
        Task<List<Entity.VendaDireta>> GetAll();
        Task<Entity.VendaDireta> GetId(int id);
        Task<bool> Save(Entity.VendaDireta entity);
        Task<bool> Update(Entity.VendaDireta entity);
        Task<bool> Delete(int id);

    }
}
