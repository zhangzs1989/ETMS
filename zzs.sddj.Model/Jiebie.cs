using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zzs.sddj.Model
{
    public class Jiebie
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

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Jibiezhibiao
        {
            get
            {
                return jibiezhibiao;
            }

            set
            {
                jibiezhibiao = value;
            }
        }

        public int Wangluoxueshi
        {
            get
            {
                return wangluoxueshi;
            }

            set
            {
                wangluoxueshi = value;
            }
        }

        private string name;

        private int jibiezhibiao;

        private int wangluoxueshi;
    }
}
