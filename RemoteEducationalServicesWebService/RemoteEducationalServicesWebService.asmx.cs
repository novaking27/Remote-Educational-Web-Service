using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace RemoteEducationalServicesWebService
{
    /// <summary>
    /// Summary description for RemoteEducationalServicesWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class RemoteEducationalServicesWebService : System.Web.Services.WebService
    {

        #region users
        private string Encrypt(string data)
        {
            byte[] bytes = System.Text.Encoding.ASCII.GetBytes(data);
            bytes = new System.Security.Cryptography.SHA256Managed().ComputeHash(bytes);
            string hashed = System.Text.Encoding.ASCII.GetString(bytes);
            return hashed;
        }
        
        [WebMethod]
        public bool CreateUser(string user, 
            string pass, 
            string firstName, 
            string lastName, 
            string email, 
            string dateOfBirth, 
            int phoneNumber, 
            string streetName, 
            int houseNumber, 
            int unitNumber, 
            string suburb, 
            string state, 
            int postCode)
        {
            // to create a user:
            //  encrypt the password
            //  insert into users (user, pass)
            //  return true on success, false on failure
            var query = "INSERT INTO users (userName, userPass, firstName, lastName, email, dateOfBirth, phoneNumber, streetName, houseNumber, unitNumber, suburb, state, postCode) " +
                "VALUES (@un, @up, @fn, @ln, @em, @dob, @ph, @sn, @hn, @unum, @sb, @st, @pc);";
            var param = new {   un = user,
                                up = Encrypt(pass),
                                fn = firstName,
                                ln = lastName,
                                em = email,
                                dob = dateOfBirth,
                                ph = phoneNumber,
                                sn = streetName,
                                hn = houseNumber,
                                unum = unitNumber,
                                sb = suburb,
                                st = state,
                                pc = postCode  };

            using (var db = Model.Database.GetConnection().OpenAndReturn())
            using (var transaction = db.BeginTransaction())
            {
                try
                {
                    db.Execute(query, param, transaction);
                    transaction.Commit();
                    return true;
                }
                catch
                {
                    // would probably be wise to log the error
                    transaction.Rollback();
                    return false;
                }
            }
        }
        //13
        /*
          string pass, 
            string firstName, 
            string lastName, 
            string email, 
            string dateOfBirth, 
            int phoneNumber, 
            string streetName, 
            int houseNumber, 
            int unitNumber, 
            string suburb, 
            string state, 
            int postCode 
         * */
        [WebMethod]
        public bool CreateDeveloperAccount()
        {
            if (CreateUser("student1", "admin", "eli", "anderson", "eli@eli.com", "02-11-1988", 0429379599, "cambridge", 40, 0, "fitzgibbon", "admin", 4018))
            {
                var userIdQuery = "(SELECT userId FROM users WHERE userName = 'student1')";
                var query = $"INSERT INTO user_roles (user, role) VALUES ({userIdQuery}, 2)";
                Model.Database.GetConnection().Execute(query);
                return true;
            }
            else
            {
                return false;
            }
        }

        [WebMethod]
        public bool ValidateCredentials(string user, string pass)
        {
            try
            {
                var query = "SELECT COUNT(*) FROM users WHERE userName = @un AND userPass = @up";
                var param = new { un = user, up = Encrypt(pass) };
                var results = (long)Model.Database.GetConnection().ExecuteScalar(query, param);
                return results == 1;
            }
            catch
            {
                return false;
            }
        }
        /*
        [WebMethod]
        public bool ValidateCredentials(string user, string pass)
        {
            try
            {
                var query = "SELECT COUNT(*) FROM users WHERE userName = @un AND userPass = @up";
                var param = new { un = user, up = Encrypt(pass) };
                var results = (long)Model.Database.GetConnection().ExecuteScalar(query, param);
                return results == 1;
            }
            catch
            {
                return false;
            }
        }
        */

        #endregion users

        #region DDL

        #endregion DDL
    }
}
