using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamProjectTracker
{
    static class Validation
    {
        public static String casingWords( String word )
        {
            word = char.ToUpper(word[0]) + word.Substring(1).ToLower();

            return word;
        }
    }
}
