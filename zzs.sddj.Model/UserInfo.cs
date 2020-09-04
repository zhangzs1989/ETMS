using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zzs.sddj.Model
{
    public class UserInfo
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _username;

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        private string _userpass;

        public string Userpass
        {
            get { return _userpass; }
            set { _userpass = value; }
        }
        private string _userpartment;

        public string Userpartment
        {
            get { return _userpartment; }
            set { _userpartment = value; }
        }
    }
}
