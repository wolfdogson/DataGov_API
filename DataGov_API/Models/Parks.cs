using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataGov_API.Models
{

    public class Parks
    {
    public Park[] data { get; set; }
    }

    public class Park
    {
    public string parkCode { get; set; }
    }
}

