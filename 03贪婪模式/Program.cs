using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03贪婪模式
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 贪婪模式介绍

            //string msg = "1111。11。111。111111。";

            ////正则表达式会尽可能多的找到匹配，这就是正则表达式的贪婪模式。
            ////Match match = Regex.Match(msg, ".+");

            ////终止贪婪模式：  ? 具有终止贪婪模式的功能。
            ////当?出现在了另外一个限定符后的时候，表示终止贪婪模式。
            ////终止贪婪模式，表示，尽可能少的去匹配，则只匹配一个。
            //Match match = Regex.Match(msg, ".+?");  //.??
            //Console.WriteLine(match.Value);//????
            //Console.ReadKey();
            #endregion


            #region 案例1

            //string msg = "1111。11。111。111111。";

            //Match match = Regex.Match(msg, "(.+)(。)");
            //Console.WriteLine(match.Value);
            //Console.WriteLine(match.Groups[1].Value+"       "+match.Groups[2].Value);
            //Console.ReadKey();





            //string msg = "1111。11。111。111111。";

            ////终止贪婪模式后的结果：1111。
            //Match match = Regex.Match(msg, ".+?。");
            //Console.WriteLine(match.Value);
            //Console.ReadKey();

            #endregion

            #region 案例2

            //string msg = "大家好。我们是S.H.E。我是S。我是H。我是E。我是杨中科。我是苏坤。我是杨洪波。我是牛亮亮。我是N.L.L。我是★蒋坤★。呜呜。fffff";

            ////正确结果： S    H   E    杨中科   苏坤   杨洪波   牛亮亮  N.L.L   ★蒋坤★

            ////当我们希望找到多个匹配的时候，结果却只找到了一个很大的匹配值，这个时候一般都是贪婪模式的问题，尝试终结贪婪模式。
            //MatchCollection matches = Regex.Matches(msg, "我是(.+?)。");
            //foreach (Match item in matches)
            //{
            //    Console.WriteLine(item.Groups[1].Value);
            //}
            //Console.ReadKey();

            #endregion


        }
    }
}
