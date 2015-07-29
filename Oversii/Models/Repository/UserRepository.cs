using Oversii.Models.DB;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Collections.Generic;
namespace Oversii.Models.Repository
{
    public class UserRepository
    {
        //public void AddUserAccount(UserAccount resident)
        //{

        //    using (oversiiEntities db = new oversiiEntities())
        //    {
        //        user US = new user();
        //        US.Email = resident.Email;
        //        US.Password = resident.Password;
        //        US.FirstName = resident.FirstName;
        //        US.LastName = resident.LastName;
        //        US.Phone1 = resident.Phone1;
        //        US.Phone2 = resident.Phone2;
        //        US.CreateDate = DateTime.Now;

        //        db.users.Add(US);
        //        db.SaveChanges();

        //    }
        //}

        //public bool ISEmailExist(string email)
        //{
        //    using (oversiiEntities db = new oversiiEntities())
        //    {
        //        return db.users.Where(o => o.Email.Equals(email)).Any();
        //    }
        //}

        //public string GetUserPassword(string emailid)
        //{
        //    using (oversiiEntities db = new oversiiEntities())
        //    {
        //        var user = db.users.Where(o => o.Email.ToLower().Equals(emailid));
        //        if (user.Any())
        //            return user.FirstOrDefault().Password;
        //        else
        //            return string.Empty;
        //    }
        //}

        //public string GetParkingGL(int? propID)
        //{
        //    using (oversiiEntities db = new oversiiEntities())
        //    {
        //        var parkingGL = (from pr in db.properties
        //                         where pr.propID == propID
        //                         select pr.parkingGL).FirstOrDefault();
        //        if (parkingGL != null)
        //            return parkingGL.ToString();
        //        else
        //            return null;
        //    }
        //}

        //public List<Oversii.Models.DB.property> PropertyList(string zipcode)
        //{
        //    using (oversiiEntities db = new oversiiEntities())
        //    {

        //        var propmgmtid = (from pm in db.property_management
        //                          where pm.Zipcode.Equals(zipcode)
        //                          select pm.propertyMgmtID).ToList();

        //        var propertyList = (from pr in db.properties where propmgmtid.Contains(pr.propertyMgmtID)
        //                            select pr).ToList();

        //        return propertyList;
        //    }

        //}

        public List<Models.DB.VehicleMake> VehilceMakeList()
        {
            using (oversiiEntities db = new oversiiEntities())
            {
                List<Models.DB.VehicleMake> RS = new List<VehicleMake>();
                RS = db.VehicleMakes.ToList();
                return RS;


            }
        }

        public void CreatePermit(Models.ViewModel.VVehiclePermit VehiclePermit)
        {
            using (oversiiEntities db = new oversiiEntities())
            {
                db.ApplyPermit(VehiclePermit.Vehicle.VehicleMake.VehicleMakeID, VehiclePermit.Vehicle.VehicleColor.VehicleColorID, 1, VehiclePermit.Vehicle.MakeYear, VehiclePermit.Vehicle.LicPlateNum, VehiclePermit.Vehicle.LicPlateState);
            }
        }

        public List<Models.DB.VehicleColor> VehicleColorList()
        {
            using (oversiiEntities db = new oversiiEntities())
            {
                List<Models.DB.VehicleColor> RS = new List<VehicleColor>();
                RS = db.VehicleColors.ToList();
                return RS;


            }
        }

        public AuthenticateUser_Result  AuthenticateUser(string email,string password)
        {
         
            using (oversiiEntities db = new oversiiEntities())
            {

                List<AuthenticateUser_Result> RS = new List<AuthenticateUser_Result>();
              RS = db.AuthenticateUser(email, password).ToList();
                return RS.FirstOrDefault();
            }

            
        }

        public bool IsUserInRole(string emailid, string roleName)
        {
           // using (oversiiEntities db = new oversiiEntities())

                

                //{
                //    user SU = db.users.Where(o => o.Email.ToLower().Equals(emailid))?.FirstOrDefault();
                //    if (SU != null)
                //    {
                //        var roles =  from q in db.users
                //        join r in db.roles on q.RoleID equals r.RoleID
                //        where r.RoleName.Equals(roleName) && q.UserID.Equals(SU.UserID)
                //        select r.RoleName;

                //        if (roles != null)
                //        {
                //            return roles.Any();
                //        }
                //    }

                return false;
            }


        

        //public string GetRole(string emailid)
        //{
        //    using (oversiiEntities db = new oversiiEntities())
        //    {

        //        var roles = (from r in db.roles
        //                     where r.RoleID == ((from q in db.users
        //                                         where q.Email.Equals(emailid)
        //                                         select q.RoleID).FirstOrDefault())
        //                     select r.RoleName).FirstOrDefault();

        //                    return roles.ToString();
        //    }
        //}

        //public bool IsUserExist(string email,string Password)
        //{
        //    using (oversiiEntities db = new oversiiEntities())
        //    {
        //        return db.users.Where(o => o.Email.Equals(email) && o.Password.Equals(Password)).Any();
        //    }
        //}
    }


}
