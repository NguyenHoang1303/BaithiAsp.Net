using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FaicEcommerce.Util
{
    public class GenarateId
    {
        public static string Create()
        {
            return Guid.NewGuid().ToString();
        }
    }
}