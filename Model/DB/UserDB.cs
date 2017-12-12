using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;

namespace Model.DB
{
  public  class UserDB
    {
        PPCRentalDB db = null;
        public UserDB()
        {
             db = new PPCRentalDB();
        }
        public int Insert(USER entity)
        {
            db.USERs.Add(entity);
            db.SaveChanges();
            return entity.ID;
        }

        public USER GetByID(string username)
        {
            return db.USERs.SingleOrDefault(x => x.Email == username);
        } 

        public bool Login ( string user, string pass)
        {
            var result = db.USERs.Count(x => x.Email == user && x.Password == pass);
            if(result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
