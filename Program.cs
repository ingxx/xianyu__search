using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace 闲鱼搜索
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入要搜索的内容:");
            string text = Console.ReadLine();
            Process.Start("https://s.2.taobao.com/list/list.htm?q=" + Uri.EscapeUriString(text) + "&search_type=item&_input_charset=utf8 ");
        }
    }
}
