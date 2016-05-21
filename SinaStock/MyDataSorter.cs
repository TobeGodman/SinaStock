using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;

namespace SinaStock
{
    public class MyDateSorter : IComparer
    {
        #region IComparer Members
        public int Compare(object x, object y)
        {
            if (x == null && y == null)
            {
                return 0;
            }
            if (x == null)
            {
                return -1;
            }
            if (y == null)
            {
                return 1;
            }
            FileInfo xInfo = (FileInfo)x;
            FileInfo yInfo = (FileInfo)y;


            //依名稱排序    
            //return xInfo.FullName.CompareTo(yInfo.FullName);//遞增    
            return yInfo.FullName.CompareTo(xInfo.FullName);//遞減    

            //依修改日期排序    
            //return xInfo.LastWriteTime.CompareTo(yInfo.LastWriteTime);//遞增    
            //return yInfo.LastWriteTime.CompareTo(xInfo.LastWriteTime);//遞減    
        }
        #endregion
    }
}
