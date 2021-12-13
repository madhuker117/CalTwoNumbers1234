using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationCalTwoNum
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddBtn_Click(object sender, EventArgs e)
        {

            int a = Convert.ToInt32(NumberOnetxt.Text);
            int b = Convert.ToInt32(NumberTwotxt.Text);

            Ans.Text = Convert.ToString(a + b);
            NumberOnetxt.Text = "";
            NumberTwotxt.Text = "";
        }

        protected void SubBtn_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(NumberOnetxt.Text);
            int b = Convert.ToInt32(NumberTwotxt.Text);

            Ans.Text = Convert.ToString(a - b);
            NumberOnetxt.Text = "";
            NumberTwotxt.Text = "";
        }

        protected void MulBtn_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(NumberOnetxt.Text);
            int b = Convert.ToInt32(NumberTwotxt.Text);

            Ans.Text = Convert.ToString(a * b);
            NumberOnetxt.Text = "";
            NumberTwotxt.Text = "";
        }
    }
}