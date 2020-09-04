using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zzs.sddj.Model
{
    public class DepartmentInfo
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string departmentloginname;

        public string Departmentloginname
        {
            get { return departmentloginname; }
            set { departmentloginname = value; }
        }



        private string departmentpwd;

        public string Departmentpwd
        {
            get { return departmentpwd; }
            set { departmentpwd = value; }
        }
    }
}
