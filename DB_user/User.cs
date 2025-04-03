using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_user
{
    public class User
    {
        public int id_user {  get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string number { get; set; }
        public DateTime birthday { get; set; }

        public User(int id)
        {
            id_user = id;
        }
    }
}
