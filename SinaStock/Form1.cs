using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading;

namespace SinaStock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            txtSavePath.Text = folderBrowserDialog1.SelectedPath;
            DownLoadData("sh600030", "2004-10-08", txtSavePath.Text);
            DownLoadStock("sh600030", txtSavePath.Text);
        }

        public static void DownLoadStock(string code, string path)
        {
            DateTime d = new DateTime(2004, 10, 8);
            path = path + "\\" + code;
            DirectoryInfo dir = new DirectoryInfo(path);
            if (dir.Exists == false)
            {
                dir.Create();
            }
            FileInfo[] sortList = dir.GetFiles();
            if (sortList.Length > 0)
            {
                Array.Sort(sortList, new MyDateSorter());
                d = Convert.ToDateTime(sortList[0].Name.Substring(0, sortList[0].Name.IndexOf(".")));
                d = d.AddDays(1);
            }
            while (d.Date < DateTime.Now.AddDays(1).Date)
            {
                if (d.DayOfWeek != DayOfWeek.Saturday && d.DayOfWeek != DayOfWeek.Sunday)
                {
                    if (DownLoadData(code, d.ToString("yyyy-MM-dd"), path))
                    {
                        d = d.AddDays(1);
                    }
                }
                else
                {
                    d = d.AddDays(1);
                }
            }
        }

        /// <summary>
        /// 下载指定股票数据
        /// </summary>
        /// <param name="code">股票代码</param>
        /// <param name="date">日期</param>
        /// <param name="path">保存路径</param>
        /// <returns></returns>
        public static bool DownLoadData(string code, string date, string path)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    string URLAddress = @"http://market.finance.sina.com.cn/downxls.php?date=" + date + "&symbol=" + code;
                    string receivePath = path;
                    DirectoryInfo dir = new DirectoryInfo(receivePath);
                    if (dir.Exists == false)
                    {
                        dir.Create();
                    }
                    string savePath = receivePath + "\\" + date + ".xls";
                    client.DownloadFile(URLAddress, savePath);
                }
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static string visit(string url)
        {
            using (WebClient myclient = new WebClient())
            {
                try
                {
                    Byte[] pagedate = myclient.DownloadData(url);
                    string text = Encoding.Default.GetString(pagedate);
                    return text;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        /// <summary>
        /// 获取股票列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetList_Click(object sender, EventArgs e)
        {
            int page = 1;
            StringBuilder sb = new StringBuilder();
            while (true)
            {
                string tempJson = visit("http://money.finance.sina.com.cn/d/api/openapi_proxy.php/?__s=[[%22hq%22,%22hs_a%22,%22%22,0," + page + ",500]]");
                JArray javascript = (JArray)JsonConvert.DeserializeObject(tempJson);
                if (!javascript[0]["items"].HasValues)
                {
                    break;
                }
                int i = 0;
                while (javascript[0]["items"][i] != javascript[0]["items"].Last)
                {
                    sb.Append(javascript[0]["items"][i][0].ToString() + "\r\n");
                    i++;
                } 
                sb.Append(javascript[0]["items"].Last[0].ToString() + "\r\n");
                page++;
            }
            textBox2.Text = sb.ToString();
        }
    }
}
