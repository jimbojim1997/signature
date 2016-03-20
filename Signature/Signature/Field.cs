using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signature
{
    class Field
    {
        public string name;
        public string field;
        public string data;

        public Field(string name, string field)
        {
            this.name = name;
            this.field = field;
        }

        public Field(string name, string field, string data)
        {
            this.name = name;
            this.field = field;
            this.data = data;
        }
    }
}
