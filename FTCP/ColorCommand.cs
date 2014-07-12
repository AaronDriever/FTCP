using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTCP
{

    public class ColorCommand
    {   

        const string COMMAND_PREFIX = "rgb";
        public byte Red;
        public byte Green;
        public byte Blue;
        public byte Mode;
        public sbyte ID;
        public override string ToString()
        {
            return COMMAND_PREFIX + " " + ID.ToString() + " " + Red.ToString() + " " + Green.ToString() + " " + Blue.ToString() + " " + Mode.ToString() + "\r";
        
        }
    }
}
