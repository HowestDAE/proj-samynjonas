using HypixelSkyblock.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HypixelSkyblock.Repository
{
    internal class ProfileRepository
    {
        private static List<Profile> lstProfiles = new List<Profile>();

        public static List<Profile> GetProfiles() //TODO convert to search with username
        {
            if(lstProfiles == null)
            {
                return lstProfiles;
            }

            using(var reader = new StreamReader("C:\\DAE\\Sem_4\\Tool_Dev\\github\\proj-samynjonas\\HypixelSkyblock\\Resources\\Data\\Profile_test.json"))
            {
                string json = reader.ReadToEnd();
                lstProfiles = JsonConvert.DeserializeObject<List<Profile>>(json);
            }

            return lstProfiles;
        }





    }
}
