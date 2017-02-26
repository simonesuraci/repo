using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoClassi
{
    static class assets
    {
        
        #if DEBUG
            public static string assetsPath = @"..\..\assets\";
        #else
            public static string assetsPath = @".\assets\";
        #endif
            public static string imagesPath = assetsPath + @"images\";

            public static string getImagePath(string imageName)
            {
                return imagesPath + imageName.ToLower() + ".jpg";
            }
    }

    
}
