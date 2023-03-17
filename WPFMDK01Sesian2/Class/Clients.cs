using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMDK01Sesian2
{
    public partial class Clients
    {
        public string ForNamme
        {
            get
            {
                return Surname + " " + Name + " " + Patronymic;
            }
        }
        public string Service
        {
            get
            {
                string service = "";
                foreach (var item in BaseClass.ep.MainService.Where(x => x.SubscriberID==SubscriberID))
                {
                    service += item.Servise.Services + ", ";
                }
                return service.Substring(0, service.Length);
            }
        }
    }
}
