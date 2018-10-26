using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfsTools.Attributes
{
    public class NvItemIdAttribute : Attribute
    {
        public NvItemIdAttribute(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
