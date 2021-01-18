using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace YetzFlow.DB.Interface
{
    public interface IPagador
    {
        Task<List<Entity.Pagador>> GetAll();
        Task<Entity.Pagador> GetId(int id);
        Task<bool> Save(Entity.Pagador entity);
        Task<bool> Update(Entity.Pagador entity);
        Task<bool> Delete(int id);

    }
}
