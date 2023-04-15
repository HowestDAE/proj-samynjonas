using HypixelSkyblock.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HypixelSkyblock.Repository
{
    internal class ProfileRepository
    {
        private static Profile profile              = new Profile();
        private static MojangProfile mojangProfile  = new MojangProfile();
        public static async Task<MojangProfile> GetUserAsync(string username)
        {
            string endpoint = "https://api.mojang.com/users/profiles/minecraft/" + username;

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var response = await client.GetAsync(endpoint);

                    if (!response.IsSuccessStatusCode)
                    {
                        throw new HttpRequestException(response.ReasonPhrase);
                    }

                    //read the result json string async
                    string json = await response.Content.ReadAsStringAsync();

                    mojangProfile = JsonConvert.DeserializeObject<MojangProfile>(json);

                    //deserialize json object
                    return mojangProfile;
                }
                catch (Exception)
                {

                }
            }

            return mojangProfile;

        }

        public static async Task<Profile> GetProfileAsync(string uuid) 
        {
            if (profile == null)
            {
                return profile;
            }

            //Actual API endpoint based on base url
            //-- string endpoint = "https://api.hypixel.net/skyblock/profiles?uuid=" + uuid;
            string endpoint = "https://sky.shiiyu.moe/api/v2/profile/" + uuid;


            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Add("API-Key", "386cc3c6-2057-4b2b-b54d-38875b4c86bc");

                    //Send a POST to the API + catch the result
                    var response = await client.GetAsync(endpoint);

                    if (!response.IsSuccessStatusCode)
                    {
                        throw new HttpRequestException(response.ReasonPhrase);
                    }

                    //read the result json string async
                    string json = await response.Content.ReadAsStringAsync();

                    profile = JsonConvert.DeserializeObject<Profile>(json);

                    //deserialize json object
                    return profile;
                }
                catch(Exception)
                {
                    
                }
            }

            return profile;
        }

        public static async Task<List<Profiles>> GetProfilesAsync(string username)
        {
            List<Profiles> lstProfiles = new List<Profiles>();

            await GetUserAsync(username);

            await GetProfileAsync(mojangProfile.uuid);

            if (profile.Profiles.Values != null)
            {
                foreach (var profile in profile.Profiles)
                {
                    lstProfiles.Add(profile.Value);
                }
            }
            return lstProfiles;
        }
        public static async Task<MojangProfile> GetMojangProfile(string username)
        {
            await GetUserAsync(username);
            return mojangProfile;
        }

    }
}
