using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigyaProfileStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            var profile = new GigyaProfileSdk();

            Console.WriteLine(profile.GetProfile());

            Console.ReadLine();
        }
    }
}
