using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZBK.TestProject.Common
{
   public class PageBar
    {
       /// <summary>
       /// 获取数字页码条
       /// </summary>
       /// <param name="pageIndex">当前页码值</param>
       /// <param name="pageCount">总的页数</param>
       /// <returns></returns>
       public static string GetPageBar(int pageIndex, int pageCount)
       {
           if (pageCount == 1)//如果只有1页，不用在显示页码条
           {
               return string.Empty;
           }
           //计算起始位置与终止位置。
           int start = pageIndex - 5;//页面上显示10个数字页码
           if (start < 1)
           {
               start = 1;
           }
           int end = start + 9;//终止位置.
           if(end>pageCount)//该条件成立，需要重新计算起始位置
           {
               end=pageCount;
               start = end - 9>1?end-9:1;
           }
           StringBuilder sb = new StringBuilder();
           if (pageIndex > 1)
           {
               sb.Append(string.Format("<a href='?pageIndex={0}'>上一页</a>",pageIndex-1));
           }
           for (int i = start; i <= end; i++)
           {
               if (i == pageIndex)//如果循环的数字与当前页码相等，那么不用超链接
               {
                   sb.Append(i);
               }
               else
               {
                   sb.Append(string.Format("<a href='?pageIndex={0}'>{0}</a>",i));
               }
           }
           if (pageIndex <pageCount)
           {
               sb.Append(string.Format("<a href='?pageIndex={0}'>下一页</a>", pageIndex +1));
           }
           return sb.ToString();
       }
    }
}
