using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace YetzFlow.DB.Interface
{
    public interface ICompraPonto
    {
        Task<List<Entity.CompraPonto>> GetAll();
        Task<Entity.CompraPonto> GetId(int id);
        Task<bool> Save(Entity.CompraPonto entity);
        Task<bool> Update(Entity.CompraPonto entity);
        Task<bool> Delete(int id);

    }
}
