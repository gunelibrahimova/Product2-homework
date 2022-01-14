using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product3.Methods
{
    public class SeoLink
    {
        public string Seo(string name)
        {

            var seo = name.ToLower().Replace(" ", "-")
                  .Replace("ə", "e")
                  .Replace("ç", "ch")
                  .Replace("ğ", "g")
                  .Replace("ç", "c");

            return seo;
        }
    }
}
