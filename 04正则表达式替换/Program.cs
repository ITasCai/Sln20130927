using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04正则表达式替换
{
    class Program
    {
        static void Main(string[] args)
        {
            //string msg = "你aaa好aa哈哈a你";
            ////msg = msg.Replace("a", "A");
            //msg = Regex.Replace(msg, "a+", "A");
            //Console.WriteLine(msg);
            //Console.ReadKey();


            #region 练习1：将一段文本中的MM/DD/YYYY格式的日期转换为YYYY-MM-DD格式 ，比如“我的生日是05/21/2010耶”转换为“我的生日是2010-05-21耶”。

            //string msg = "我的生日是05/21/2010耶我的生日是03/11/2000耶我的生日是05/21/2010耶我的生日是05/21/2010耶";

            ////在替换的方法中，使用提取组。 注意在引用分组的时候是使用  $1、$2、.....
            //msg = Regex.Replace(msg, @"(\d{2})/(\d{2})/(\d{4})", "$3-$1-$2");
            //Console.WriteLine(msg);
            //Console.ReadKey();

            #endregion


            #region  将hello ‘welcome’ to ‘China’   替换成 hello 【welcome】 to 【China】
            ////hello 【welcome】 to 【China】
            //string s = " hello 'welcome' to  be'aut'iful 'China' fdsfds jfklds'jfdsk'lfjskl ";

            ////如果就像表示一个普通的$1，则需要$$1
            //s = Regex.Replace(s, "'(.+?)'", "【$1】");
            //Console.WriteLine(s);
            //Console.ReadKey();



            #endregion


            #region 替换手机号的掩码

            //string msg = "我的手机号码是13888888888苏坤的手机号是18999165365。长15210998254的觉得是浪费";

            //msg = Regex.Replace(msg, @"(\d{3})\d{4}(\d{4})", "$1****$2");
            //Console.WriteLine(msg);
            //Console.ReadKey();

            //string msg = "嘎哈发的睡觉了zxh@itcast.cn范德萨abcdef@yahoo.com范德萨nihaomahaha@sina.com.cn范德萨";
            ////嘎哈发的睡觉了***@itcast.cn范德萨******@yahoo.com范德萨************@sina.com.cn范德萨
            #endregion



            #region 练习2：给一段文本中匹配到的url添加超链接，比如把http://www.test.com替换为<a href="http://www.test.com"> http://www.test.com</a>。参考代码见备注。因为这个是整体做为一个组，比较特殊，难以理解，先把日期转换的理解了就好理解了。

            //string msg = "新浪的网址是：http://www.sina.com.cn搜狐的网址是：http://www.sohu.com还有网易的网址：http://www.163.com";

            ////msg = Regex.Replace(msg, "([a-zA-Z0-9]+://[0-9a-zA-Z.&=\\?%]+)", "<a href=\"$1\">$1</a>");

            //msg = Regex.Replace(msg, "([a-zA-Z0-9]+://[0-9a-zA-Z.&=\\?%]+)", @"<a href=""$1"">$1</a>");
            //Console.WriteLine(msg);
            //Console.ReadKey();





            //新浪的网址是：<a href="http://www.sina.com.cn">http://www.sina.com.cn</a>搜狐的网址是：<a href="http://www.sohu.com">http://www.sohu.com<a>还有网易的网址：<a href="http://www.163.com">http://www.163.com</a>


            #endregion
        }
    }
}
