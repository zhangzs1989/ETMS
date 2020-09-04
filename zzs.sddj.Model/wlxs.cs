using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zzs.sddj.Model
{
    public class wlxs
    {
        int id;
        string filepath;
        int niandu;
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

        public string Filepath
        {
            get
            {
                return filepath;
            }

            set
            {
                filepath = value;
            }
        }

        public int Niandu
        {
            get
            {
                return niandu;
            }

            set
            {
                niandu = value;
            }
        }
    }
}
