using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zzs.sddj.Model
{
    public class Notice
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

        private DateTime Regtime;

        public DateTime Regtime1
        {
            get { return Regtime; }
            set { Regtime = value; }
        }

        private string issuer;

        public string Issuer
        {
            get { return issuer; }
            set { issuer = value; }
        }

        private string content;

        public string Content
        {
            get { return content; }
            set { content = value; }
        }
        
        
    }
}
