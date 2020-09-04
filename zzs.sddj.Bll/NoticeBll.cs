using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using zzs.sddj.Model;

namespace zzs.sddj.Bll
{
    public class NoticeBll
    {
        Dal.NoticeDal noticedal = new Dal.NoticeDal();
        public List<Notice> Getnoticelist()
        {
            return noticedal.GetNoticelist();
        }

        public Notice GetModel(int id)
        {
            return noticedal.GetEntityModel(id);
        }

        public int DeleteEntity(int id)
        {
            return noticedal.DeleteEntityModel(id);
        }

        public int InsertEntity(Notice notice)
        {
            return noticedal.InsertEntityModel(notice);
        }

        public int UpdataEntity(Notice notice)
        {
            return noticedal.UpdataEntityModel(notice);
        }
    }
}
