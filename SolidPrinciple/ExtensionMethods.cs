using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple
{
    public static class ExtensionMethods
    {
        public static bool IsRegistered(this IStudent student)
        {
            return student.Maths;
        }
    }
}
