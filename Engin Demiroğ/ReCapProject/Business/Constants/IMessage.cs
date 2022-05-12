using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public  interface IMessage
    {
        static string Added {  get; set; }
        static string Deleted {  get; set; }
        static string MaintenanceTime { get; set; }
        static string Listed { get; set; }
        static string Updated { get; set; }
        static string NameAlreadyExists { get; set; }
    }
}
