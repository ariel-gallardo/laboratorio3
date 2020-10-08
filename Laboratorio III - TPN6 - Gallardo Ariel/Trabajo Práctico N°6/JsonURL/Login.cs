using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Práctico_N_6.JsonURL
{
    public class Login
    {
        public string uuid { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string salt { get; set; }
        public string md5 { get; set; }
        public string sha1 { get; set; }
        public string sha256 { get; set; }

        public Login(string uuid, string username, string password, string salt, string md5, string sha1, string sha256)
        {
            this.uuid = uuid;
            this.username = username;
            this.password = password;
            this.salt = salt;
            this.md5 = md5;
            this.sha1 = sha1;
            this.sha256 = sha256;
        }
    }
}
