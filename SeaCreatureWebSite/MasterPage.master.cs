using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            
            DateLabel.Text = DateTime.Now.ToString("d");

            string dayOfWeek = DateTime.Now.DayOfWeek.ToString();
            string imagePath = GetImagePathForDay(dayOfWeek);

            DayImage.ImageUrl = imagePath;
            DayImage.AlternateText = "Image for dayOfWeek" + dayOfWeek;
        }

    }

    private string GetImagePathForDay(string dayOfWeek)
    {
        string path = "images/week/";
        
        switch (dayOfWeek)
        {
            case "Sunday":
                return path + "sunday.png";
            case "Monday":
                return path + "monday.png";
            case "Tuesday":
                return path + "tuesday.png";
            case "Wednesday":
                return path + "wednesday.png";
            case "Thursday":
                return path + "thursday.png";
            case "Friday":
                return path + "friday.png";
            case "Saturday":
                return path + "saturday.png";
            default:
                return path + "default.png";
        }
    }

}
