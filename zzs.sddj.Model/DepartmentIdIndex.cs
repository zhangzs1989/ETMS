using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zzs.sddj.Model
{
    public class DepartmentIdIndex
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int departmentid;

        public int Departmentid
        {
            get { return departmentid; }
            set { departmentid = value; }
        }

        private string departmentloginname;

        public string Departmentloginname
        {
            get { return departmentloginname; }
            set { departmentloginname = value; }
        }
    }
}
