using System;
using System.Collections.Generic;
using System.Linq;


namespace SimpleLinq
{
    class Profile
    {
        public string Name { get; set; }
        public int Height
        {
            get; set;
        }

        class MainApp
        {
            static void Main(string[] args)
            {
                Profile[] arrProfiles = new Profile[]
                {
                    new Profile() { Name = "김난다", Height = 180 },
                    new Profile() { Name = "이름표", Height = 170 },
                    new Profile() { Name = "박아지", Height = 160 },
                    new Profile() { Name = "최고다", Height = 150 },
                    new Profile() { Name = "정말로", Height = 140 }
                };

                var listProfile = from profile in arrProfiles
                                  orderby profile.Height
                                  group profile by profile.Height < 165 into g
                                  select new { Groupkey = g.Key, Profile = g };

                foreach (var Group in listProfile)
                {
                    Console.WriteLine("165 미만 ? {0}", Group.Groupkey);

                    foreach(var profile in Group.Profile)
                    {
                        Console.WriteLine($">>> {profile.Name},{profile.Height}");
                    }
                }
            }
        }
    }
}