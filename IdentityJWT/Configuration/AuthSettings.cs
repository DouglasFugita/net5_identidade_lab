using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityJWT.Configuration
{
    public class AuthSettings
    {
        public string Segredo { get; set; }
        public int ExpiraEm { get; set; }
        public string Emissor { get; set; }
        public string ValidoEm { get; set; }
    }
}
