using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLibrary
{
    public interface IDataAccess
    {
        Task<IEnumerable<TEntity>> LoadData<TEntity, TParam>(string sql, TParam parameters, string connectionString);
        Task SaveData<TEntity>(string sql, TEntity parameters, string connectionString);
    }
}