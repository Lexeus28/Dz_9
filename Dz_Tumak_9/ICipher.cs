using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_Tumak_9
{
    public interface ICipher
    {
        public string decode(string input);
        public string encode(string input);
    }
}
