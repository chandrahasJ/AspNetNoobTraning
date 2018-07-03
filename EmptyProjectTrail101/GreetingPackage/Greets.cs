using System;

namespace GreetingPackage
{
    // To Create Nuget Package
    // Right Click on Class Libary Project -> Click Pack 

    // nuget packages can also be extracted if you rename the filename extension into zip

    // We can change the nuget package installation from nuget.org to local 
    // By Click on the setting icon on the nuget package manager tool 

    // If only class libary needs to be added in the project 
    // Right Click on the Dependencies -> Add References -> Click Project 
    // -> Select the name of the Class Libary 
    // -> OK
    public class Greets
    {
        /// <summary>
        /// Greet People By Name
        /// </summary>
        /// <param name="peopleName">Name</param>
        /// <returns></returns>
        public static string GreetPeopleByName(string peopleName)
        {
            return $"Hello {peopleName} from Greets Libary";
        }
    }
}
