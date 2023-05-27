using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.DatabaseManager
{
    internal interface IDML
    {
        int Insert(Record record); // CRUD CREATE
        int Update(Record record); // CRUD UPDATE
        int Delete(int id); // CRUD DELETE
    }
}
