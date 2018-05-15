using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RemoteEducationalServicesWebApplication
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            var svc = new RemoteEducationalServicesWebServiceProxy.RemoteEducationalServicesWebServiceSoapClient();
            var loggedIn = svc.ValidateCredentials(txtUser.Text.ToString(), txtPass.Text.ToString());
          
            if (loggedIn)
            {
                Response.Redirect("~/Pages/Booking.aspx");
            } else
            {
                lblStatus.ForeColor = System.Drawing.Color.Red;
                lblStatus.Text = "Incorrect Detials";
            }
        }  
       

        protected void ctlLogin_Authenticate(object sender, AuthenticateEventArgs e)
        {
            //var svc = new RemoteEducationalServicesWebServiceProxy.RemoteEducationalServicesWebServiceSoapClient();
            //var loggedIn = svc.ValidateCredentials(ctlLogin.UserName, ctlLogin.Password);
            //e.Authenticated = loggedIn;
            //if (loggedIn)
            //{
            //    Response.Redirect("~/UserList.aspx");
            //}
        }

        protected void btncreate_Click(object sender, EventArgs e)
        {
            var svc = new RemoteEducationalServicesWebServiceProxy.RemoteEducationalServicesWebServiceSoapClient();
            var createUser = svc.CreateDeveloperAccount();
        }
    }
}