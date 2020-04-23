using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timely.Models
{
    public static class Session
    {
        public static WorkTask ActiveWorkTask { get; set; }
        public static Profile ActiveProfile { get; set; }

        public static List<Profile> Profiles
        {
            get
            {
                return Directory.GetFiles("Profiles/").Select(x => new Profile() { Name = Path.GetFileNameWithoutExtension(x) }).ToList();
            }
        }


    }
}
