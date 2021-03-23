using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RemoteServiceReference;
public partial class _Default : System.Web.UI.Page
{
    CalendarServiceClient client = new CalendarServiceClient();
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        try
        {
            DateTime date = this.Calendar1.SelectedDate;
            String result = client.GetDayFromDate(date);
            TextBox.Text = result;
        }
        catch (Exception ex)
        {
          TextBox.Text = ex.Message;
        }
    }
}