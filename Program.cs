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


                var profiles = from profile in arrProfiles
                               where profile.Height < 175
                               orderby profile.Height descending
                               select new
                               {
                                   Name = profile.Name,
                                   InchHeight = profile.Height * 0.393
                               };


                foreach (var profile in profiles)
                {
                    Console.WriteLine($"{profile.Name} : {profile.InchHeight}");
                }
            }
        }
    }
}