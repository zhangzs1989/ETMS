using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zzs.sddj.Model
{
    public class ZhiduInfo
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private DateTime regtime;

        public DateTime Regtime
        {
            get { return regtime; }
            set { regtime = value; }
        }

        
        private string shangchuanzhe;

        public string Shangchuanzhe
        {
            get { return shangchuanzhe; }
            set { shangchuanzhe = value; }
        }

        private string zhiducailiao;

        public string Zhiducailiao
        {
            get { return zhiducailiao; }
            set { zhiducailiao = value; }
        }

        
    }
}
