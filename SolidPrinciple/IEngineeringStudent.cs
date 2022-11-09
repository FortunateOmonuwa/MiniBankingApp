using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple
{
    public interface IEngineeringStudent : IStudent
    {
        bool ENG { get; set; }
        bool MEE { get; set; }

    }
}
