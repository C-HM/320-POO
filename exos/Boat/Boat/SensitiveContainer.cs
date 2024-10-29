using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boat
{
    internal class SensitiveContainer : Container
    {
        public SensitiveContainer(int id, float weight, bool isRefrigerated, List<string> merchandise, string color) : base(id, weight, isRefrigerated, merchandise, color)
        {
            this.Id = id;
            this.Weight = weight;
            this.IsRefrigerated = isRefrigerated;
            this.Merchandise = merchandise;
            this.Color = color;
        }

    }
}
