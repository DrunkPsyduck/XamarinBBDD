using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinBBDD.Dependencies
{
    public interface IDatabase
    {
        SQLite.SQLiteConnection GetConnection();

    }
}
