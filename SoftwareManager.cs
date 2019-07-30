using System;
using System.Collections.Generic;
public class Software
    {
        public string Name { get; set; }
        public string Version { get; set; }
    }

    namespace VersionGetter{
        public static class SoftwareManager
        {
            public static IEnumerable<Software> GetAllSoftware()
            {
                return new List<Software>
                {
                    new Software
                    {
                        Name = "MS Word",
                        Version = "13.2.1."
                    },
                    new Software
                    {
                        Name = "AngularJS",
                        Version = "1.7.1"
                    },
                    new Software
                    {
                        Name = "Angular",
                        Version = "8.1.13"
                    },
                    new Software
                    {
                        Name = "React",
                        Version = "0.0.5"
                    },
                    new Software
                    {
                        Name = "Vue.js",
                        Version = "2.6"
                    },
                    new Software
                    {
                        Name = "Visual Studio",
                        Version = "2017.0.1"
                    },
                    new Software
                    {
                        Name = "Visual Studio",
                        Version = "2019.1"
                    },
                    new Software
                    {
                        Name = "Visual Studio Code",
                        Version = "1.35"
                    },
                    new Software
                    {
                        Name = "Blazor",
                        Version = "0.7"
                    }
                };
            }

            public static List<Software> doVersionComparison(string versionToCheck){
                List<Software> matchingVersions = new List<Software>();
                // Version checkVersion = new Version(versionToCheck);
                int[] checkVersion = getVersionSplit(versionToCheck);

                foreach(Software s in GetAllSoftware()){
                    Console.Write("checking version for: " + s.Name + " version number: " + s.Version + " -- ");
                    int[] softwareVersion = getVersionSplit(s.Version);
                    if(checkVersions(checkVersion, softwareVersion)){
                        matchingVersions.Add(s);
                    }
                    
                }

                return matchingVersions;
            }

            public static int[] getVersionSplit(String versionString){
                int[] versionArray = new int[3];

                string[] splitVersion = versionString.Split('.',3,StringSplitOptions.RemoveEmptyEntries);
                if(splitVersion.Length > 3){
                    for(int i = splitVersion.Length; i < 3; i++){
                        splitVersion[i] = "0";
                    }
                }
                for(int i = 0; i < splitVersion.Length; i++){                
                    versionArray[i] = Convert.ToInt32(splitVersion[i]);
                }

                return versionArray;
            }

            public static bool checkVersions(int[] checkVersion, int[] softwareVersion){
                for(int i = 0; i < checkVersion.Length; i++){
                    if(checkVersion[i] > softwareVersion[i]){
                        return false;
                    }
                }
                return true;
            }
        }
        
    }
    