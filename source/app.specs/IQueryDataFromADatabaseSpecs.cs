using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using app.web.core;
using developwithpassion.specifications.rhinomocks;
using Machine.Specifications;

namespace app.specs
{
    public class query_from_database_concern : Observes<IQueryDataFromDatabase >
    {

    }

    public class when_runing_query : query_from_database_concern
    {




        Because b = () =>
        {

        };

        It should_open_the_connection = () =>
        {

        };


        It should_run_the_send_query = () =>
        {

        };



    }

    internal class QueryDataTest : IQueryDataFromDatabase
    {
        public IDataReader run_query(IDbConnection connection, string query)
        {
            connection.Open();
            var command =connection.CreateCommand();
            command.CommandText = query;
            return command.ExecuteReader();
        }
    }
}
