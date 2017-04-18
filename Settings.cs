using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
   public class Settings
    {
        private static Settings _Instance;
        public static Settings Instance()
        {
                if (_Instance == null)
                {
                    _Instance = new Settings();
                }
                return _Instance;
        }

        public String SampleVariable = string.Empty;
    }
}
