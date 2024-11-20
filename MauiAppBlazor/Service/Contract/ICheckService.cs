using MauiAppBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppBlazor.Service.Contract
{
    public interface ICheckService
    {
        Task<IEnumerable<Bill>> GetItems();
        Task<Bill> GetItem(int id);
        Task<bool> NewCheck(long checkId, long workerId, Dictionary<long, long> ProductsIdAndAmoun);


    }
}
