﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace notebook
{
    class NewClass
    {
        public void Newclass()
        {
            Console.WriteLine("请输入新的科目");
            String type = Console.ReadLine();
            StreamWriter sw = new StreamWriter(@"H:\notebook\leixing.txt");
            sw.WriteLine(type);
            Console.WriteLine("该类型已保存成功");
            sw.Close();
            Console.ReadKey();
        }


    }
}
