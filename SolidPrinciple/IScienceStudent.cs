using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple
{
    public interface IScienceStudent : IStudent
    {
        bool SLT { get; set; }
        bool BIO { get; set; }
    }
}
