using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace eProdaja_API.Util
{
    public class ExceptionHandler
    {
        public static string HandleException(EntityException ex)
        {
            SqlException error = ex.InnerException as SqlException;
            switch (error.Number)
            {
                case 2627:return getConstraintExcepionMessage(error);
            }
            return error.Message + "(" + error.Number + ")";
        }

        private static string getConstraintExcepionMessage(SqlException error)
        {

            string msg = error.Message;
            int pocetak = msg.IndexOf("'");
            int kraj = msg.IndexOf("'", pocetak + 1);

            if(pocetak > 0 && kraj > 0)
            {
                string nazivOgranicenja = msg.Substring(pocetak + 1, kraj - pocetak - 1);
                if (nazivOgranicenja == "CS_Email")
                    msg = " email_con";
                else if (nazivOgranicenja == "CS_KorisnickoIme")
                    msg = " username_con";

            }
            return msg;
        }
    }
}