using ejemplo_wcf_completo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ejemplo_wcf_completo
{
    public class CalendarService : ICalendarService
    {
        string ICalendarService.GetDayFromDate(DateTime date)
        {
            string result = date.DayOfWeek.ToString();
            return result;
        }

        int ICalendarService.GetDayFromName(string daystring)
        {
            List <string> daynames = new List<string> { "MONDAY" , "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY", "SUNDAY" };
            return daynames.IndexOf(daystring.ToUpper());
            
        }

        string ICalendarService.GetDayFronNumber(int daynumber)
        {
            List<string> daynames = new List<string> { "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY", "SUNDAY" };
            return daynames[daynumber];

            throw new NotImplementedException();
        }
    }


}
