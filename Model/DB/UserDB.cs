using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;
using PagedList;

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

        public bool Update(USER entity)
        {
            try
            {
                var user = db.USERs.Find(entity.ID);
                user.FullName = entity.FullName;
                user.Password = entity.Password;
                db.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
          
        }
        public IEnumerable<USER> ListAll(int page, int size)
        {
            return db.USERs.OrderByDescending(x =>x.ID).ToPagedList(page, size);
        }

        public USER GetByID(string username)
        {
            return db.USERs.SingleOrDefault(x => x.Email == username);
        } 
        public USER ViewDetail(int id)
        {
            return db.USERs.Find(id);
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
