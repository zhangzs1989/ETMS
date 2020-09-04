using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zzs.sddj.Model
{
    public class TrainZhibiao
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

        public string Jibie
        {
            get
            {
                return jibie;
            }

            set
            {
                jibie = value;
            }
        }

        public int Zhibiao
        {
            get
            {
                return zhibiao;
            }

            set
            {
                zhibiao = value;
            }
        }

        public int Wlxs
        {
            get
            {
                return wlxs;
            }

            set
            {
                wlxs = value;
            }
        }

        private string jibie;

        private int zhibiao;
        private int wlxs;
    }
}
