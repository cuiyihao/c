using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.IO;
    class Program
    {
        private String[,] datas;//datas数组第一列为标题，第二列为时间，第三列为文章简介
        private int[,] ArticleNumsForMonth;
        Program()
        {
            this.datas = new string[460,4];
            this.ArticleNumsForMonth = new int[11, 12];
            for(int i = 0; i < 11; i++)
            {
                for(int j = 0; j < 12; j++)
                {
                    this.ArticleNumsForMonth[i, j] = 0;
                }
            }
        }
        public static String[] splittfortime(String ss)
        {
            String[] str = ss.Split('[',']',' ','-',',','\'');
            //for (int i= 0;i < str.Length; i++){
            //    if (str[i] != null)
            //    {
            //        Console.Write(str[i]);
            //    }
            //}
            return str;
        }//该函数用于分割字符串
        public void distribute(String[] dates)
        {
            List<String> datee = new List<String>();
            for(int i = 0; i < dates.Length; i++)
            {
                datee.Add(dates[i]);
            }
            if (datee.Contains("2020"))
            {
                if (datee.Contains("JAN"))
                {
                    this.ArticleNumsForMonth[0, 0]++;
                }
                if (datee.Contains("FEB"))
                {
                    this.ArticleNumsForMonth[0, 1]++;
                }
                if (datee.Contains("MAR"))
                {
                    this.ArticleNumsForMonth[0, 2]++;
                }
                if (datee.Contains("APR"))
                {
                    this.ArticleNumsForMonth[0, 3]++;
                }
                if (datee.Contains("MAY"))
                {
                    this.ArticleNumsForMonth[0, 4]++;
                }
                if (datee.Contains("JUN"))
                {
                    this.ArticleNumsForMonth[0, 5]++;
                }
                if (datee.Contains("JUL"))
                {
                    this.ArticleNumsForMonth[0, 6]++;
                }
                if (datee.Contains("AUG"))
                {
                    this.ArticleNumsForMonth[0, 7]++;
                }
                if (datee.Contains("SEP"))
                {
                    this.ArticleNumsForMonth[0, 8]++;
                }
                if (datee.Contains("OCT"))
                {
                    this.ArticleNumsForMonth[0, 9]++;
                }
                if (datee.Contains("NOV"))
                {
                    this.ArticleNumsForMonth[0, 10]++;
                }
                if (datee.Contains("DEC"))
                {
                    this.ArticleNumsForMonth[0, 11]++;
                }
            }
            if (datee.Contains("2019"))
            {
                if (datee.Contains("JAN"))
                {
                    this.ArticleNumsForMonth[1, 0]++;
                }
                if (datee.Contains("FEB"))
                {
                    this.ArticleNumsForMonth[1, 1]++;
                }
                if (datee.Contains("MAR"))
                {
                    this.ArticleNumsForMonth[1, 2]++;
                }
                if (datee.Contains("APR"))
                {
                    this.ArticleNumsForMonth[1, 3]++;
                }
                if (datee.Contains("MAY"))
                {
                    this.ArticleNumsForMonth[1, 4]++;
                }
                if (datee.Contains("JUN"))
                {
                    this.ArticleNumsForMonth[1, 5]++;
                }
                if (datee.Contains("JUL"))
                {
                    this.ArticleNumsForMonth[1, 6]++;
                }
                if (datee.Contains("AUG"))
                {
                    this.ArticleNumsForMonth[1, 7]++;
                }
                if (datee.Contains("SEP"))
                {
                    this.ArticleNumsForMonth[1, 8]++;
                }
                if (datee.Contains("OCT"))
                {
                    this.ArticleNumsForMonth[1, 9]++;
                }
                if (datee.Contains("NOV"))
                {
                    this.ArticleNumsForMonth[1, 10]++;
                }
                if (datee.Contains("DEC"))
                {
                    this.ArticleNumsForMonth[1, 11]++;
                }
            }
            if (datee.Contains("2018"))
            {
                if (datee.Contains("JAN"))
                {
                    this.ArticleNumsForMonth[2, 0]++;
                }
                if (datee.Contains("FEB"))
                {
                    this.ArticleNumsForMonth[2, 1]++;
                }
                if (datee.Contains("MAR"))
                {
                    this.ArticleNumsForMonth[2, 2]++;
                }
                if (datee.Contains("APR"))
                {
                    this.ArticleNumsForMonth[2, 3]++;
                }
                if (datee.Contains("MAY"))
                {
                    this.ArticleNumsForMonth[2, 4]++;
                }
                if (datee.Contains("JUN"))
                {
                    this.ArticleNumsForMonth[2, 5]++;
                }
                if (datee.Contains("JUL"))
                {
                    this.ArticleNumsForMonth[2, 6]++;
                }
                if (datee.Contains("AUG"))
                {
                    this.ArticleNumsForMonth[2, 7]++;
                }
                if (datee.Contains("SEP"))
                {
                    this.ArticleNumsForMonth[2, 8]++;
                }
                if (datee.Contains("OCT"))
                {
                    this.ArticleNumsForMonth[2, 9]++;
                }
                if (datee.Contains("NOV"))
                {
                    this.ArticleNumsForMonth[2, 10]++;
                }
                if (datee.Contains("DEC"))
                {
                    this.ArticleNumsForMonth[2, 11]++;
                }
            }
            if (datee.Contains("2017"))
            {
                if (datee.Contains("JAN"))
                {
                    this.ArticleNumsForMonth[3, 0]++;
                }
                if (datee.Contains("FEB"))
                {
                    this.ArticleNumsForMonth[3, 1]++;
                }
                if (datee.Contains("MAR"))
                {
                    this.ArticleNumsForMonth[3, 2]++;
                }
                if (datee.Contains("APR"))
                {
                    this.ArticleNumsForMonth[3, 3]++;
                }
                if (datee.Contains("MAY"))
                {
                    this.ArticleNumsForMonth[3, 4]++;
                }
                if (datee.Contains("JUN"))
                {
                    this.ArticleNumsForMonth[3, 5]++;
                }
                if (datee.Contains("JUL"))
                {
                    this.ArticleNumsForMonth[3, 6]++;
                }
                if (datee.Contains("AUG"))
                {
                    this.ArticleNumsForMonth[3, 7]++;
                }
                if (datee.Contains("SEP"))
                {
                    this.ArticleNumsForMonth[3, 8]++;
                }
                if (datee.Contains("OCT"))
                {
                    this.ArticleNumsForMonth[3, 9]++;
                }
                if (datee.Contains("NOV"))
                {
                    this.ArticleNumsForMonth[3, 10]++;
                }
                if (datee.Contains("DEC"))
                {
                    this.ArticleNumsForMonth[3, 11]++;
                }
            }
            if (datee.Contains("2016"))
            {
                if (datee.Contains("JAN"))
                {
                    this.ArticleNumsForMonth[4, 0]++;
                }
                if (datee.Contains("FEB"))
                {
                    this.ArticleNumsForMonth[4, 1]++;
                }
                if (datee.Contains("MAR"))
                {
                    this.ArticleNumsForMonth[4, 2]++;
                }
                if (datee.Contains("APR"))
                {
                    this.ArticleNumsForMonth[4, 3]++;
                }
                if (datee.Contains("MAY"))
                {
                    this.ArticleNumsForMonth[4, 4]++;
                }
                if (datee.Contains("JUN"))
                {
                    this.ArticleNumsForMonth[4, 5]++;
                }
                if (datee.Contains("JUL"))
                {
                    this.ArticleNumsForMonth[4, 6]++;
                }
                if (datee.Contains("AUG"))
                {
                    this.ArticleNumsForMonth[4, 7]++;
                }
                if (datee.Contains("SEP"))
                {
                    this.ArticleNumsForMonth[4, 8]++;
                }
                if (datee.Contains("OCT"))
                {
                    this.ArticleNumsForMonth[4, 9]++;
                }
                if (datee.Contains("NOV"))
                {
                    this.ArticleNumsForMonth[4, 10]++;
                }
                if (datee.Contains("DEC"))
                {
                    this.ArticleNumsForMonth[4, 11]++;
                }
            }
            if (datee.Contains("2015"))
            {
                if (datee.Contains("JAN"))
                {
                    this.ArticleNumsForMonth[5, 0]++;
                }
                if (datee.Contains("FEB"))
                {
                    this.ArticleNumsForMonth[5, 1]++;
                }
                if (datee.Contains("MAR"))
                {
                    this.ArticleNumsForMonth[5, 2]++;
                }
                if (datee.Contains("APR"))
                {
                    this.ArticleNumsForMonth[5, 3]++;
                }
                if (datee.Contains("MAY"))
                {
                    this.ArticleNumsForMonth[5, 4]++;
                }
                if (datee.Contains("JUN"))
                {
                    this.ArticleNumsForMonth[5, 5]++;
                }
                if (datee.Contains("JUL"))
                {
                    this.ArticleNumsForMonth[5, 6]++;
                }
                if (datee.Contains("AUG"))
                {
                    this.ArticleNumsForMonth[5, 7]++;
                }
                if (datee.Contains("SEP"))
                {
                    this.ArticleNumsForMonth[5, 8]++;
                }
                if (datee.Contains("OCT"))
                {
                    this.ArticleNumsForMonth[5, 9]++;
                }
                if (datee.Contains("NOV"))
                {
                    this.ArticleNumsForMonth[5, 10]++;
                }
                if (datee.Contains("DEC"))
                {
                    this.ArticleNumsForMonth[5
, 11]++;
                }
            }
            if (datee.Contains("2014"))
            {
                if (datee.Contains("JAN"))
                {
                    this.ArticleNumsForMonth[6, 0]++;
                }
                if (datee.Contains("FEB"))
                {
                    this.ArticleNumsForMonth[6, 1]++;
                }
                if (datee.Contains("MAR"))
                {
                    this.ArticleNumsForMonth[6, 2]++;
                }
                if (datee.Contains("APR"))
                {
                    this.ArticleNumsForMonth[6, 3]++;
                }
                if (datee.Contains("MAY"))
                {
                    this.ArticleNumsForMonth[6, 4]++;
                }
                if (datee.Contains("JUN"))
                {
                    this.ArticleNumsForMonth[6, 5]++;
                }
                if (datee.Contains("JUL"))
                {
                    this.ArticleNumsForMonth[6, 6]++;
                }
                if (datee.Contains("AUG"))
                {
                    this.ArticleNumsForMonth[6, 7]++;
                }
                if (datee.Contains("SEP"))
                {
                    this.ArticleNumsForMonth[6, 8]++;
                }
                if (datee.Contains("OCT"))
                {
                    this.ArticleNumsForMonth[6, 9]++;
                }
                if (datee.Contains("NOV"))
                {
                    this.ArticleNumsForMonth[6, 10]++;
                }
                if (datee.Contains("DEC"))
                {
                    this.ArticleNumsForMonth[6, 11]++;
                }
            }
            if (datee.Contains("2013"))
            {
                if (datee.Contains("JAN"))
                {
                    this.ArticleNumsForMonth[7, 0]++;
                }
                if (datee.Contains("FEB"))
                {
                    this.ArticleNumsForMonth[7, 1]++;
                }
                if (datee.Contains("MAR"))
                {
                    this.ArticleNumsForMonth[7, 2]++;
                }
                if (datee.Contains("APR"))
                {
                    this.ArticleNumsForMonth[7, 3]++;
                }
                if (datee.Contains("MAY"))
                {
                    this.ArticleNumsForMonth[7, 4]++;
                }
                if (datee.Contains("JUN"))
                {
                    this.ArticleNumsForMonth[7, 5]++;
                }
                if (datee.Contains("JUL"))
                {
                    this.ArticleNumsForMonth[7, 6]++;
                }
                if (datee.Contains("AUG"))
                {
                    this.ArticleNumsForMonth[7, 7]++;
                }
                if (datee.Contains("SEP"))
                {
                    this.ArticleNumsForMonth[7, 8]++;
                }
                if (datee.Contains("OCT"))
                {
                    this.ArticleNumsForMonth[7, 9]++;
                }
                if (datee.Contains("NOV"))
                {
                    this.ArticleNumsForMonth[7, 10]++;
                }
                if (datee.Contains("DEC"))
                {
                    this.ArticleNumsForMonth[7, 11]++;
                }
            }
            if (datee.Contains("2012"))
            {
                if (datee.Contains("JAN"))
                {
                    this.ArticleNumsForMonth[8, 0]++;
                }
                if (datee.Contains("FEB"))
                {
                    this.ArticleNumsForMonth[8, 1]++;
                }
                if (datee.Contains("MAR"))
                {
                    this.ArticleNumsForMonth[8, 2]++;
                }
                if (datee.Contains("APR"))
                {
                    this.ArticleNumsForMonth[8, 3]++;
                }
                if (datee.Contains("MAY"))
                {
                    this.ArticleNumsForMonth[8, 4]++;
                }
                if (datee.Contains("JUN"))
                {
                    this.ArticleNumsForMonth[8, 5]++;
                }
                if (datee.Contains("JUL"))
                {
                    this.ArticleNumsForMonth[8, 6]++;
                }
                if (datee.Contains("AUG"))
                {
                    this.ArticleNumsForMonth[8, 7]++;
                }
                if (datee.Contains("SEP"))
                {
                    this.ArticleNumsForMonth[8, 8]++;
                }
                if (datee.Contains("OCT"))
                {
                    this.ArticleNumsForMonth[8, 9]++;
                }
                if (datee.Contains("NOV"))
                {
                    this.ArticleNumsForMonth[8, 10]++;
                }
                if (datee.Contains("DEC"))
                {
                    this.ArticleNumsForMonth[8
, 11]++;
                }
            }
            if (datee.Contains("2011"))
            {
                if (datee.Contains("JAN"))
                {
                    this.ArticleNumsForMonth[9, 0]++;
                }
                if (datee.Contains("FEB"))
                {
                    this.ArticleNumsForMonth[9, 1]++;
                }
                if (datee.Contains("MAR"))
                {
                    this.ArticleNumsForMonth[9, 2]++;
                }
                if (datee.Contains("APR"))
                {
                    this.ArticleNumsForMonth[9, 3]++;
                }
                if (datee.Contains("MAY"))
                {
                    this.ArticleNumsForMonth[9, 4]++;
                }
                if (datee.Contains("JUN"))
                {
                    this.ArticleNumsForMonth[9, 5]++;
                }
                if (datee.Contains("JUL"))
                {
                    this.ArticleNumsForMonth[9, 6]++;
                }
                if (datee.Contains("AUG"))
                {
                    this.ArticleNumsForMonth[9, 7]++;
                }
                if (datee.Contains("SEP"))
                {
                    this.ArticleNumsForMonth[9, 8]++;
                }
                if (datee.Contains("OCT"))
                {
                    this.ArticleNumsForMonth[9, 9]++;
                }
                if (datee.Contains("NOV"))
                {
                    this.ArticleNumsForMonth[9, 10]++;
                }
                if (datee.Contains("DEC"))
                {
                    this.ArticleNumsForMonth[9, 11]++;
                }
            }
            if (datee.Contains("2010"))
            {
                if (datee.Contains("JAN"))
                {
                    this.ArticleNumsForMonth[10, 0]++;
                }
                if (datee.Contains("FEB"))
                {
                    this.ArticleNumsForMonth[10, 1]++;
                }
                if (datee.Contains("MAR"))
                {
                    this.ArticleNumsForMonth[10, 2]++;
                }
                if (datee.Contains("APR"))
                {
                    this.ArticleNumsForMonth[10, 3]++;
                }
                if (datee.Contains("MAY"))
                {
                    this.ArticleNumsForMonth[10, 4]++;
                }
                if (datee.Contains("JUN"))
                {
                    this.ArticleNumsForMonth[10, 5]++;
                }
                if (datee.Contains("JUL"))
                {
                    this.ArticleNumsForMonth[10, 6]++;
                }
                if (datee.Contains("AUG"))
                {
                    this.ArticleNumsForMonth[10, 7]++;
                }
                if (datee.Contains("SEP"))
                {
                    this.ArticleNumsForMonth[10, 8]++;
                }
                if (datee.Contains("OCT"))
                {
                    this.ArticleNumsForMonth[10, 9]++;
                }
                if (datee.Contains("NOV"))
                {
                    this.ArticleNumsForMonth[10, 10]++;
                }
                if (datee.Contains("DEC"))
                {
                    this.ArticleNumsForMonth[10, 11]++;
                }
            }
        }//DEC十二月 JAN一月 SEP九月
        public void FocusOnTime()
        {
            for(int i = 0; i < 460; i++)
            {
                String[] dates = splittfortime(this.datas[i, 1]);
                distribute(dates);
            }
            for (int i = 0; i < 11; i++)
            {
                for(int j = 0; j < 12; j++)
                {
                    Console.Write(this.ArticleNumsForMonth[i, j]+" ");
                }
                Console.Write("\n");
            }
        }
        public void getdatas()
        {
            String path = "C://Users//lenovo//Desktop//jg";
            int num = 0;
            DirectoryInfo folder = new DirectoryInfo(path);
            foreach (FileInfo file in folder.GetFiles("*.txt"))
            {
                String pathh = file.FullName;
                String[] cl = File.ReadAllLines(pathh);
                if (cl.Length >= 4)
                {
                    this.datas[num, 0] = cl[0];
                    this.datas[num, 1] = cl[1];
                    this.datas[num, 2] = cl[2];
                    String abstractt = null;
                    for (int i = 3; i < cl.Length; i++)
                    {
                        abstractt = abstractt + cl[i];
                    }
                    this.datas[num, 3] = abstractt;
                }
                num++;
                //Console.WriteLine(file.FullName);
                //num++;
            }
            //Console.Write(this.datas[0, 0]);
            //Console.Write(this.datas[0, 1]);
            //Console.Write(this.datas[0, 2]);
            //Console.Write(num);
        }//该函数用于将txt文档读书datas数组中
        public void TimeConsequence()
        {
            for (int year = 10; year > -1; year--)
            {
                Console.Write((year+2010)+"年文章数量(月份)：" + "\n");
                for (int i = 0; i < 12; i++)
                {
                    Console.Write((i+1) + "月" + this.ArticleNumsForMonth[year, i]+"篇 ");
                    if ((i + 1) % 6 == 0)
                    {
                        Console.Write("\n");
                    }
                }
            }//按月计算
            Console.Write("\n");
            for (int year = 10; year > -1; year--)
            {
                Console.Write((year + 2010) + "年文章数量(季度)：" + "\n");
                for (int i = 0; i < 12; i=i+3)
                {
                    int total_num = this.ArticleNumsForMonth[year, i] + this.ArticleNumsForMonth[year, i+1] + this.ArticleNumsForMonth[year, i+2];
                    Console.Write((i/3 + 1) + "季度" + total_num + "篇 ");                   
                }
                Console.Write("\n");
            }//按季度计算
            Console.Write("\n");
            for (int year = 10; year > -1; year--)
            {
                Console.Write((year + 2010) + "年文章数量(年度度)：" + "\n");
                int num = 0;
                for(int i = 0; i < 12; i++)
                {
                    num += this.ArticleNumsForMonth[year, i];
                }
                Console.Write((year+2010)+"年" + num + "篇 ");                
                Console.Write("\n");
            }
        }
        public void tt()
        {
            for(int i = 0; i < 442; i++)
            {
                Console.Write(this.datas[i, 1]+"\n");
            }
        }
        static void Main(string[] args)
        {
            Program pro = new Program();
            pro.getdatas();
            pro.FocusOnTime();
            pro.TimeConsequence();
            Console.Read();
        }
    }
}
