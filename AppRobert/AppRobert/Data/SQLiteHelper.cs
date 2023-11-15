using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using AppRobert.Models;
using System.Threading.Tasks;

namespace AppRobert.Data
{
    public class SQLiteHelper
    {
        SQLiteAsyncConnection Db;
        public SQLiteHelper(string DBPath)
        {
            Db = new SQLiteAsyncConnection(DBPath);
            Db.CreateTableAsync<Usuarios>().Wait();

        }

        public Task<int> SaveUsuariosAsync(Usuarios Usua)
        {
            if (Usua.IdUsuario == 0)
            {
                return Db.InsertAsync(Usua);
            }
            else
            {
                return null;
            }

        }

    }
}
