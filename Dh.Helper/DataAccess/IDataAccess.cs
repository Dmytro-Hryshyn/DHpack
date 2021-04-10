using System.Collections.Generic;

namespace Dh.Helper.DataAccess
{
    public interface IDataAccess
    {
        List<T> LoadData<T, U>(string sqlStatement, U parameter, string connectionString);
        void SaveData<T>(string sqlStatement, T parameters, string connectionString);
    }
}
