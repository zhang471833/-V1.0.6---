using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TcpDemo
{
    class Env
    {
        public static DIL.DILDB DB = new DIL.DILDB("localhost:3306", "purete", "root", "root1234");
    }
}
