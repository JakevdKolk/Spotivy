using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Spotivy
{
    class Friends
    {
        List<User> friends { get; set; }
        public Friends() {
        }

        public List<User> addFriend(User user) {
        
             friends.Add(user);
            return friends;
        }


    }
}
