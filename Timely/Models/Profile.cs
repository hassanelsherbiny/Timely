using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timely.Models
{
    public class Profile : BaseModel
    {
        static string ProfilesPath = "Profiles/";
        public string Name { get; set; }

        public List<WorkTask> WorkTasks { get; set; }
        public Profile()
        {
            WorkTasks = new List<WorkTask>();
        }
        public void Save()
        {
            var SavePath = ProfilesPath + Name + ".json";
            if (!Directory.Exists(ProfilesPath))
                Directory.CreateDirectory(ProfilesPath);
            var settingsStr = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(SavePath, settingsStr);
        }



        public static Profile Load(string Name)
        {
            Profile profile = null;
            var SavePath = ProfilesPath + Name + ".json";
            if (File.Exists(SavePath))
            {
                try
                {
                    var profileFile = File.ReadAllText(SavePath);
                    profile = JsonConvert.DeserializeObject<Profile>(profileFile);
                }
                catch (Exception ex)
                {
                }
            }
            if (profile == null)
            {
                profile = new Profile(); 
            }
            return profile;
        }
    }
}
