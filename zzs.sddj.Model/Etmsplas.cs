using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zzs.sddj.Model
{
    public class Etmsplas
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

        public string Bumen
        {
            get
            {
                return bumen;
            }

            set
            {
                bumen = value;
            }
        }

        private int niandu;

        private string filepath;

        private string bumen;
    }
}
