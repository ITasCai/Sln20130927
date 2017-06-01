using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Text.RegularExpressions;
using System.IO;

namespace _05通过WebClient类来发起请求并下载html
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 抓取网页email
            //string url = "http://192.168.1.100:8080/提取Email.htm";
            ////1.根据网址下载对应html字符串
            //WebClient wc = new WebClient();
            //wc.Encoding = Encoding.UTF8;
            //string html = wc.DownloadString("http://192.168.1.100:8080/提取Email.htm");
            ////2.从下载到字符串中提取Email,并把提取到的Email写入到文本文件中
            //MatchCollection matches = Regex.Matches(html, @"[-a-zA-Z0-9_.]+@[-a-zA-Z0-9]+(\.[a-zA-Z0-9]+){1,}");

            //using (StreamWriter writer = new StreamWriter("email.txt"))
            //{
            //    //遍历提取到的email
            //    foreach (Match item in matches)
            //    {
            //        //Console.WriteLine(item.Value);
            //        writer.WriteLine(item.Value);
            //    }
            //}


            //Console.ReadKey();
            #endregion



            #region 抓取网页图片
            //WebClient wc = new WebClient();


            ////1.下载网页源代码
            //string html = wc.DownloadString("http://192.168.1.100:8080/美女图片/美女们.htm");
            ////2.提取网页中的图片，其实就是<img>标签
            ////<img alt="" src="hotgirls/00_00.jpg" />
            //MatchCollection matches = Regex.Matches(html, @"<img\s+alt="""" src=""(.+)""\s*/>");
            //foreach (Match item in matches)
            //{
            //    string imgPath = "http://192.168.1.100:8080/美女图片/" + item.Groups[1].Value;
            //    //下载图片
            //    wc.DownloadFile(imgPath, @"c:\mv\" + Path.GetFileName(imgPath));
            //}
            //Console.WriteLine("ok");
            //Console.ReadKey();

            #endregion

            #region 抓取职位信息
            WebClient webClient = new WebClient();
            string html = webClient.DownloadString("http://192.168.1.100:8080/【上海,IT-管理,计算机软件招聘，求职】-前程无忧.htm");

            //<a href="http://search.51job.com/job/46621778,c.html" onclick="zzSearch.acStatRecJob( 1 );" class="jobname" target="_blank">ERP项目经理</a>
            MatchCollection matches = Regex.Matches(html, @"<a\s+href=""http://search.51job.com/job/[0-9]{8},c.html"".+>(.+)</a>");
            foreach (Match item in matches)
            {
                Console.WriteLine(item.Groups[1].Value);
            }
            Console.WriteLine("共{0}个职位信息。", matches.Count);
            Console.ReadKey();

            #endregion






        }
    }
}
