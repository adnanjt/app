using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace app.web.core
{
    public interface IQueryDataFromDatabase
    {
        IDataReader run_query(IDbConnection connection, string query);
    }
}
