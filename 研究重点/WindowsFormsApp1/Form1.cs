using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		static int i = 0;//定义一个静态变量i
		public String[,] datas;
		string[] keyArray;
		int[] valueArray;
		public Form1()
		{
			InitializeComponent();
			this.datas = new string[460, 5];
		}

		public void getdatas()
		{
			String path = "C:\\Users\\41015\\Desktop\\爬虫数据";
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
					for (int i = 3; i < cl.Length - 1; i++)
					{
						abstractt = abstractt + cl[i];
					}
					this.datas[num, 3] = abstractt;
					this.datas[num, 4] = cl[cl.Length - 1];

				}
				num++;
				//Console.WriteLine(file.FullName);
				//num++;
			}
			//Console.Write(this.datas[0, 0]);
			//Console.Write(this.datas[0, 1]);
			//Console.Write(this.datas[0, 2]);
			//Console.Write(num);
		}

		public static List<String> splittfortime(String ss)
		{
			String[] str = ss.Split('[', ']', ' ', '\'');
			List<String> list = new List<String>();
			foreach(String i in str)
			{
				list.Add(i);
			}
			return list;
		}
		public Hashtable valuesort(Hashtable ht)
		{
			Hashtable hts = new Hashtable();
			 keyArray = new string[ht.Count];
			 valueArray = new int[ht.Count];
			string k;
			int v;
			//将HashTable中的Key和Value分别赋给上面两个数组
			//注：有关CopyTo的用法请参考相关帮助文档
			ht.Keys.CopyTo(keyArray, 0);
			ht.Values.CopyTo(valueArray, 0);

			//下面就是对Value进行排序，当然需要按排序结果将Keys的值也作对应的排列
			//Sort默认是升序排序，如果想用降序排序请在Sort排序后使用Array.Reverse()进行反向排序
			for(int i = 0; i < ht.Count; i++)
			{
				for(int j = i + 1; j < ht.Count; j++)
				{
					if (valueArray[i] < valueArray[j])
					{
						k = keyArray[i];
						keyArray[i] = keyArray[j];
						keyArray[j] = k;
						v = valueArray[i];
						valueArray[i] = valueArray[j];
						valueArray[j] = v;
					}
					
				}
				
			}			
			for (int i = 0; i < ht.Count; i++)
			{
				hts.Add(keyArray[i], valueArray[i]);
			}
			return hts;
		}

		private void BXS_Click(object sender, EventArgs e)
		{
			getdatas();
			
			//i自加
			BXS.Text = "文件显示" ;//实现按钮的显示
			TXS.Text = datas[0, 4];//把文章显示在textbox中
			List<String> list = new List<String>();
			for(int i = 1; i < 460; i++)
			{
				list = splittfortime(datas[i, 1]);
				if (list.Contains("2020"))
					TXS.Text = TXS.Text + datas[i, 4];
			}
			

		}
		//按下按钮显示统计数据
		private void BIJ_Click(object sender, EventArgs e)
		{
			string strtext_low;
			strtext_low = TXS.Text;
			ArrayList strword = new ArrayList();
			strword = separateword(strtext_low);
			Hashtable hs = new Hashtable();
			Hashtable ht = new Hashtable();
			hs = hashcreate(strword);
			ht = valuesort(hs);
			TXS.Text = "";
			for(int i=0;i<ht.Count;i++)
			{
				string str = string.Format("{0,-15} {1,3}", keyArray[i], valueArray[i]);
				TXS.Text = TXS.Text + str + "\r\n";
			}
			
		}
		//往哈夫曼树中写入方法
		private Hashtable hashcreate(ArrayList strword)
		{

			Hashtable ht = new Hashtable();
			foreach (string i in strword)//遍历wtrword
				if (!ht.Contains(i))
					ht.Add(i, 1);
				else
				{
					ht[i] = (int)ht[i] + 1;
				}
			return ht;
		}


		//定义一个转化方法
		private ArrayList separateword(string strtext_low)
		{

			ArrayList sepword = new ArrayList();//定义一个动态数组用于传进已转换小写的数组
			string strtext = strtext_low;
			
			
			String[] word = strtext.Split('[', ']', ',', '\'','<','>','=','"');//使用Split（）方法分割单词
			foreach (string i in word)//遍历循环将其传入动态数组sepword
				sepword.Add(i);
			return sepword;
		} 





		//定义一个转化小写方法
		private string upperlower()
		{

			return TXS.Text.ToLower();//返回小写值
		}

		
	}
}