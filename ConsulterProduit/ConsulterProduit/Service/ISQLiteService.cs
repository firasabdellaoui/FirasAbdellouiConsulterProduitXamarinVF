using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;

namespace ConsulterProduit.Droid
{
    public interface ISQLiteService
    {
        SQLiteAsyncConnection GetConnection(string dbPath);
    }
}