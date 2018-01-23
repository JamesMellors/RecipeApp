using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace RecepeApp
{
    interface ISQLite
    {
        SQLiteAsyncConnection GetConnection();
        
    }
}
