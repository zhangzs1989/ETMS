using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zzs.sddj.Model
{
    public class JuneiTrain
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

        public string Trainname
        {
            get
            {
                return trainname;
            }

            set
            {
                trainname = value;
            }
        }

        public string Traindidian
        {
            get
            {
                return traindidian;
            }

            set
            {
                traindidian = value;
            }
        }

        public int Trainxueshi
        {
            get
            {
                return trainxueshi;
            }

            set
            {
                trainxueshi = value;
            }
        }

        public string Traintime
        {
            get
            {
                return traintime;
            }

            set
            {
                traintime = value;
            }
        }

        public string Trainrenyuan
        {
            get
            {
                return trainrenyuan;
            }

            set
            {
                trainrenyuan = value;
            }
        }

        public string Trainzhuban
        {
            get
            {
                return trainzhuban;
            }

            set
            {
                trainzhuban = value;
            }
        }

        public string Trainbeizhu
        {
            get
            {
                return trainbeizhu;
            }

            set
            {
                trainbeizhu = value;
            }
        }

        public string Qitarenyuan
        {
            get
            {
                return qitarenyuan;
            }

            set
            {
                qitarenyuan = value;
            }
        }

        public int Trainniandu
        {
            get
            {
                return trainniandu;
            }

            set
            {
                trainniandu = value;
            }
        }

        private string trainzhuban;
        private string trainname;
        private string traindidian;
        private int trainxueshi;
        public string trainjianjie;
        private string traintime;
        private string trainrenyuan;
        private string trainbeizhu;
        private string qitarenyuan;
        private int trainniandu;
    }
}
