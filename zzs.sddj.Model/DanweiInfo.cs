using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zzs.sddj.Model
{
    public class DanweiInfo
    {
        private int id;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Danwei
        {
            get
            {
                return danwei;
            }

            set
            {
                danwei = value;
            }
        }

        public string Danweiid
        {
            get
            {
                return danweiid;
            }

            set
            {
                danweiid = value;
            }
        }

        private string danwei;

        private string danweiid;
        
    }
}
