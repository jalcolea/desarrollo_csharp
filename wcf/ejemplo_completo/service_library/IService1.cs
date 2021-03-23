using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
          
namespace ejemplo_wcf_completo
{
    [ServiceContract]
    public interface ICalendarService
    {
        [OperationContract]
        string GetDayFronNumber(int daynumber);

        [OperationContract]
        int GetDayFromName(string daystring);

        [OperationContract]
        string GetDayFromDate(DateTime date);
    }
}
