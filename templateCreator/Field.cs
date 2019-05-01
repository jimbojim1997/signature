using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateCreator
{
    public class Field
    {
        public string key;
        public string value;

        public Field()
        {

        }

        public Field(string key, string value)
        {
            this.key = key;
            this.value = value;
        }
    }
}
