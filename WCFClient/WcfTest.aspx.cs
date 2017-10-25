using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using WCFClient.WCFService;
using WCFClient.WCF_Host;
using WCFClient.WCFHost_WAS;


namespace WCFClient
{
    public partial class WcfTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnClick(object sender, EventArgs e)
        {
            WCFHost_WAS.UserClient user = new WCFHost_WAS.UserClient();
            string result = user.ShowName(this.txtName.Text);
            Response.Write(result);
        }
    }
}