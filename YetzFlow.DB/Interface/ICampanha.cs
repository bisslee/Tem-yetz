using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace YetzFlow.DB.Interface
{
    public interface ICampanha
    {
        Task<List<Entity.Campanha>> GetAll();
        Task<Entity.Campanha> GetId(int id);
        Task<bool> Save(Entity.Campanha entity);
        Task<bool> Update(Entity.Campanha entity);
        Task<bool> Delete(int id);
    }
}
