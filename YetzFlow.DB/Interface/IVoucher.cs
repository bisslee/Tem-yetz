using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace YetzFlow.DB.Interface
{
    public interface IVoucher
    {
        Task<List<Entity.Voucher>> GetAll();
        Task<Entity.Voucher> GetId(int id);
        Task<bool> Save(Entity.Voucher entity);
        Task<bool> Update(Entity.Voucher entity);
        Task<bool> Delete(int id);

    }
}
