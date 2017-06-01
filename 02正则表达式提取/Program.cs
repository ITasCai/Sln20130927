using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

namespace _02正则表达式提取
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 提取数字符串中的所有的数字

            // string msg = "大家好呀，hello,2010年10月10日是个好日子。恩，9494.吼吼！886.";

            ////逐个提取
            ////字符串提取Match()和Matches()
            //////提取第一个匹配的字符串，只提取一个。
            ////Match match = Regex.Match(msg, @"\d+", RegexOptions.ECMAScript);
            ////Console.WriteLine(match.Value);
            ////Console.ReadLine();

            ////一般在调用IsMatch()的时候要判断完全匹配，所以要加^$
            ////但是一个在调用Match()或Matches()的时候，是要从一个大字符串中提取某一部分匹配的内容，所以这个时候是不能加^与$的，如果加了，则必须整个大字符串与给定正则表达式完全匹配
            ////创建一个对象实现逐个提取
            //Regex regex = new Regex(@"\d+", RegexOptions.ECMAScript);

            //Match match = regex.Match(msg);
            //while (match.Value.Length != 0)
            //{
            //    Console.WriteLine(match.Value);
            //    match = regex.Match(msg, match.Index + match.Value.Length);
            //}


            ////Console.WriteLine(match.Value);

            ////match = regex.Match(msg, match.Index + match.Value.Length);
            ////Console.WriteLine(match.Value);

            ////match = regex.Match(msg, match.Index + match.Value.Length);
            ////Console.WriteLine(match.Value);

            ////match = regex.Match(msg, match.Index + match.Value.Length);
            ////Console.WriteLine(match.Value);

            ////match = regex.Match(msg, match.Index + match.Value.Length);
            ////Console.WriteLine(match.Value);

            ////match = regex.Match(msg, match.Index + match.Value.Length);
            ////Console.WriteLine(match.Value);

            ////match = regex.Match(msg, match.Index + match.Value.Length);
            ////Console.WriteLine(match.Value);

            ////match = regex.Match(msg, match.Index + match.Value.Length);
            ////Console.WriteLine(match.Value);

            //Console.ReadLine();



            ////Match match1 = Regex.Match(msg, @"\d+", RegexOptions.ECMAScript);
            ////Console.WriteLine(match1.Value);


            ////Match match2 = Regex.Match(msg, @"\d+", RegexOptions.ECMAScript);
            ////Console.WriteLine(match2.Value);

            ////Match match3 = Regex.Match(msg, @"\d+", RegexOptions.ECMAScript);
            ////Console.WriteLine(match3.Value);

            //Console.ReadLine();


            //////提取所有的匹配的字符串
            ////MatchCollection matches = Regex.Matches(msg, @"\d+", RegexOptions.ECMAScript);
            ////for (int i = 0; i < matches.Count; i++)
            ////{
            ////    Console.WriteLine(matches[i].Value);
            ////}
            ////Console.ReadLine();


            ////判断是否匹配
            ////Regex.IsMatch();判断是否匹配
            #endregion


            #region 从文件中提取Email地址

            ////提取文件  提取Email.htm  中的所有Email地址
            ////1.读取文件中的内容到字符串
            //string html = File.ReadAllText("提取Email.htm");
            ////2.创建正则表达式
            //MatchCollection matches = Regex.Matches(html, @"[-a-zA-Z0-9_.]+@[-a-zA-Z0-9]+(\.[a-zA-Z0-9]+){1,}");

            ////3.进行提取


            ////4.输出
            //foreach (Match item in matches)
            //{
            //    Console.WriteLine(item.Value);
            //}
            //Console.WriteLine(matches.Count);
            //Console.ReadKey();

            #endregion


            #region MyRegion

            //string msg = "大夫，我咳嗽得很重。”     大夫：“你多大年记？”     患者：“七十五岁。”     大夫：“二十岁咳嗽吗”患者：“不咳嗽。”     大夫：“四十岁时咳嗽吗？”     患者：“也不咳嗽。”     大夫：“那现在不咳嗽，还要等到什么时咳嗽？";

            //MatchCollection matches = Regex.Matches(msg, "咳嗽");
            //foreach (Match item in matches)
            //{
            //    Console.WriteLine(item.Index);
            //}
            //Console.WriteLine("一共出现了{0}", matches.Count);
            //Console.ReadKey();

            #endregion

            #region 字符串提取

            //           //1.从一个大字符串中提取 某一部分子字符串


            //           //2.在提取到的字符串中，再提取其中的某部分
            //           //【提取组】


            //           ////提取文件  提取Email.htm  中的所有Email地址
            //           //1.读取文件中的内容到字符串
            //           string html = File.ReadAllText("提取Email.htm");
            //           //2.创建正则表达式
            //MatchCollection matches = Regex.Matches(html, @"[-a-zA-Z0-9_.]+@([-a-zA-Z0-9]+((\.[a-zA-Z0-9]+){1,}))");
            //           //()((()()))(()())()

            //           //(   ()()  )
            //           //3.进行提取


            //           //4.输出
            //           foreach (Match item in matches)
            //           {
            //               Console.WriteLine(item.Value + "===============" + item.Groups[1].Value + "=======" + item.Groups[2].Value);
            //           }
            //           Console.WriteLine(matches.Count);
            //           Console.ReadKey();


            #endregion


            #region 提取组2


            //Match match = Regex.Match("age=30", @"^(.+)=(.+)$");
            //Console.WriteLine(match.Groups[1].Value + "============" + match.Groups[2].Value);
            //Console.ReadKey();

            #endregion


            //普通的字符串提取：Match() Matches(),思路是从整个字符串中找出所有那些匹配指定正则表达式的字符串

            //提取组的思路：先写一个能满足整个字符串的正则表达式，然后在正则表达式中用括号将那些你想要提取的内容括起来，这样就可以提取你想要的组了。

            #region 从文件路径中提取出文件名(包含后缀) @“^.+\(.+)$”。比如从c:\windows\testb.txt中提取出testb.txt这个文件名出来。项目中用Path.GetFileName更好。贪婪模式。注意：\在c#中与在正则表达式中的转义符问题。

            //string path = @"C:\Documents and Settings\Administrator\桌面\资料\讲课素材\正则表达式工具\Regulator20Bin\The Regulator 2.0\_FusionLic.dll";
            ////提取组：1>编写一个能满足整个路径的正则表达式
            //Match match = Regex.Match(path, @".+\\(.+)");
            //Console.WriteLine(match.Groups[1].Value);
            //Console.ReadKey();
            #endregion


            #region 从“June         26       ,        1951    ”中提取出月份June、26、1951来。@"^([a-zA-Z]+)\s*(\d{1,2})\s*,\s*(\d{4})\s*$"进行匹配。月份和日之间是必须要有空格分割的，所以使用空白符号“\s”匹配所有的空白字符，此处的空格是必须有的，所以使用“+”标识为匹配1至多个空格。之后的“，”与年份之间的空格是可有可无的，所以使用“*”表示为匹配0至多个

            //string msg = "June26,1951    ";
            //Match match = Regex.Match(msg, @"^([a-zA-Z]+)\s*(\d{1,2})\s*,\s*(\d{4})\s*$");
            //Console.WriteLine(match.Groups[1].Value);
            //Console.WriteLine(match.Groups[2].Value);
            //Console.WriteLine(match.Groups[3].Value);
            //Console.ReadKey();



            #endregion


            #region 从Email中提取出用户名和域名，比如从test@163.com中提取出test和163.com。

            //string email = "test@163.com";
            //Match match = Regex.Match(email, @"(^\w+)@(\w+\.\w+)$");
            //Console.WriteLine(match.Groups[1].Value + "         " + match.Groups[2].Value);
            //Console.ReadKey();

            #endregion



            #region “192.168.10.5[port=21,type=ftp]”，这个字符串表示IP地址为192.168.10.5的服务器的21端口提供的是ftp服务，其中如果“,type=ftp”部分被省略，则默认为http服务。请用程序解析此字符串，然后打印出“IP地址为***的服务器的***端口提供的服务为***”

            string s1 = "192.168.10.5[port=21,type=ftp]";
            //string s1 = "192.168.10.5[port=21]";

            Match match = Regex.Match(s1, @"^((\d{1,3}\.){3}\d{1,3})\[port=(\d{1,2})(,type=([a-zA-Z0-9]+))?\]$", RegexOptions.ECMAScript);
            Console.WriteLine("ip:{0}", match.Groups[1].Value);
            Console.WriteLine("port:{0}", match.Groups[3]);
            Console.WriteLine("service:{0}", match.Groups[5].Value.Length == 0 ? "http" : match.Groups[5].Value);
            Console.ReadKey();




            #endregion




        }
    }
}
