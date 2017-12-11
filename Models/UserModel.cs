using Models.framwork;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class UserModel
    {
        private PPCRentalDB db = null;
        public UserModel()
        {
            db = new PPCRentalDB();
        }
        public bool Login(string username, string password)
        {
            object[] sqlPara =
            {
                new SqlParameter("@username", username),
                new SqlParameter("@password", password),
            };

            var re = db.Database.SqlQuery<bool>("ppc_User_Login @username, @password", sqlPara).SingleOrDefault();
            return re;
        }
    }
}
