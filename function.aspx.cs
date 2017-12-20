using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class function : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //ss(TextBox2.Text.Trim(),TextBox1.Text.Trim());
        int n1 = s1(TextBox2.Text.Trim(), TextBox1.Text.Trim());
        int n2 = s2(TextBox3.Text.Trim());
        int n3 = n1 + n2;
        Lbl_result.Text = n3.ToString().Trim();
    }
    public int s1(string h,string w)
    {
        //Lbl_result.Text = (Convert.ToInt16(h) * Convert.ToInt16(w) / 2).ToString().Trim();
        return (Convert.ToInt16(h) * Convert.ToInt16(w) / 2);
    }
    public int s2(string w)
    {
        //Lbl_result.Text = (Convert.ToInt16(h) * Convert.ToInt16(w) / 2).ToString().Trim();
        return Convert.ToInt16(w) * Convert.ToInt16(w);
    }
}
