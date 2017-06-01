using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace _01作业问题
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 正则

            ////创建了一个正则表达式对象
            //Regex regex = new Regex(@"^\d{6}$", RegexOptions.ECMAScript);

            //while (true)
            //{

            //    Console.WriteLine("请输入一个字符串");
            //    string postcode = Console.ReadLine();
            //    bool b = regex.IsMatch(postcode);
            //    Console.WriteLine(b);
            //}
            #endregion

            #region 二进制序列化的步骤

            ////1.创建二进制序列器
            //BinaryFormatter bf = new BinaryFormatter();

            //using (FileStream fsWrite = File.OpenWrite("data"))
            //{
            //    //2. 执行序列化或者反序列化
            //    //调用序列化方法的时候,需要传递两个参数，一个是流，另一个是需要序列化的对象
            //    bf.Serialize(fsWrite, new MyClass());
            //}
            //Console.WriteLine("ok");


            //bf.Deserialize(

            #endregion



            #region 二进制反序列化

            ////1.创建序列化器
            //BinaryFormatter bf = new BinaryFormatter();

            //using (FileStream fsRead = File.OpenRead("data"))
            //{
            //    //2.执行反序列化
            //    object obj = bf.Deserialize(fsRead);
            //    MyClass mc = obj as MyClass;
            //}

            //Console.WriteLine("ok");



            #endregion


            #region MyRegion

            //while (true)
            //{
            //    Console.WriteLine("请输入");
            //    string input = Console.ReadLine();

            //    //表示只有用户输入一个数字字符的时候才会返回true
            //    //bool b = Regex.IsMatch(input, "^\\d$");

            //    //"\\d"   \\d    \.

            //    //    \d    \\d
            //    //    \\d    \\\\d
            //    //当用户输入\d的时候返回true,否则输入其他任何内容都返回false
            //   // bool b = Regex.IsMatch(input, "^\\\\d$");

            //    //"\\\d"

            //    //    \

            //    bool b = Regex.IsMatch(input, @"^\\d$");
            //    Console.WriteLine(b);
            //}
            #endregion


            #region MyRegion


            //\d     "\\d"
            //\\d    "\\\\d"


            // \d      \\d

            //     @"\\d"


            #endregion


            #region MyRegion
            //while (true)
            //{
            //    Console.WriteLine("请输入");
            //    string msg = Console.ReadLine();
            //    Console.WriteLine(Regex.IsMatch(msg,@"^\.$"));
            //}

            //while (true)
            //{
            //    Console.WriteLine("请输入");
            //    string msg = Console.ReadLine();
            //    Console.WriteLine(Regex.IsMatch(msg, @"^\[\]$"));
            //}

            //string msg = Regex.Escape(File.ReadAllText("1.txt"));
            //Console.WriteLine(msg);
            //Console.ReadLine();

            //while (true)
            //{
            //    Console.WriteLine("请输入");
            //    string msg = Console.ReadLine();

            //最终这里只能出现一个\以及一个点字符才能匹配该正则表达式
            //    bool b = Regex.IsMatch(msg, @"^\\\.$");
            //    Console.WriteLine(b);
            //}
            #endregion



            #region 1、匹配IP地址，4段用.分割的最多三位数字。 192.168.54.77、333.333.333.333假设都是正确的。

            //while (true)
            //{
            //    //999.999.999.999
            //    Console.WriteLine("请输入");
            //    string ip = Console.ReadLine();
            //    bool b = Regex.IsMatch(ip, @"^(\d{1,3}\.){3}\d{1,3}$", RegexOptions.ECMAScript);
            //    Console.WriteLine(b);
            //}



            #endregion



            #region 2、判断是否是合法的日期格式“2008-08-08”。四位数字-两位数字-两位数字。

            //while (true)
            //{
            //    Console.WriteLine("输入日期");
            //    string date = Console.ReadLine();
            //    //bool b = Regex.IsMatch(date, @"^\d{4}-\d{2}-\d{2}$", RegexOptions.ECMAScript);
            //    //bool b = Regex.IsMatch(date, @"^\d{4}-\d{2}-\d{2}$", RegexOptions.ECMAScript);
            //    bool b = Regex.IsMatch(date, @"^\d{4}-(0[1-9]|1[0-2])-\d{2}$", RegexOptions.ECMAScript);
            //    Console.WriteLine(b);
            //}

            #endregion




            #region 3、判断是否是合法的url地址，http://www.test.com/a.htm？id=3&name=aaa、ftp://127.0.0.1/1.txt。字符串序列://字符串序列。http、https、ftp、file、thunder、ed2k

            //while (true)
            //{
            //    Console.WriteLine("请输入");
            //    string url = Console.ReadLine();
            //    bool b = Regex.IsMatch(url, "^[a-zA-Z0-9]+://.+$");
            //    Console.WriteLine(b);
            //}



            #endregion




        }
    }
    [Serializable]
    class MyClass
    {

    }
}
