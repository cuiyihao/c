# -*- coding = utf-8 -*-
# @Time :2020/12/24 14:11
# @Author :55181022崔益昊
# @File : main.py
# @Software: PyCharm
from bs4 import BeautifulSoup
import re
import urllib.request, urllib.error
import xlwt


def main():
    baseurl = "http://apps.webofknowledge.com/full_record.do?product=UA&search_mode=AdvancedSearch&qid=472&SID=7Ct8pADGmJulJgDoC9Z&page=0&doc="
    datalist = getData(baseurl)
    savepath = ".\\ziyuan.txt"
    # saveData(savepath)
    # askURl("http://apps.webofknowledge.com/summary.do?product=UA&parentProduct=UA&search_mode=AdvancedSearch&parentQid=1&qid=2&SID=6AUyesCdihROI3jqHyl&&update_back2search_link_param=yes&page=")

findtitle=re.compile(r'<value>(.*?)</value>',re.S)
findtime=re.compile(r'<span class="FR_label">Published:</span><span class="hitHilite">(.*?)</span>')
findzy=re.compile(r'<p class="FR_field">(.*?)</p>',re.S)
findkey=re.compile(r'title="Find more records by this author keywords">(.*?)</a>',re.S)
# 爬取网页
def getData(baseurl):
    datalist = []
    for i in range(0, 2):
        url = baseurl + str(i+1)
        html = askURl(url)
        soup = BeautifulSoup(html, "html.parser")
        item1 = soup.find_all('div', class_="title")
        data = []
        item1 = str(item1)
        title = re.findall(findtitle, item1)
        #print(title)
        item = soup.find_all('div', class_="block-record-info block-record-info-source")[0]
        data = []
        item = str(item)
        time = re.findall(findtime,item)
        #print(item)
        item0 = soup.find_all('a', class_="snowplow-author-keyword-link")
        data = []
        #print(item0)
        item0 = str(item0)
        key = re.findall(findkey, item0)
        item2 = soup.find_all('div', class_="block-record-info")[2]
        data = []
        item2 = str(item2)
        zy = re.findall(findzy, item2)
        #print(zy)
        f = open(r"D:\爬虫数据\ll"+str(i+1)+".txt", "w")
        f.write(str(title)+"\n")
        f.write(str(time)+"\n")
        f.write(str(key) + "\n")
        f.write(str(zy)+"\n")
        f.close()



    return datalist


# 得到一个网页的内容
def askURl(url):
    head = {
        "User-Agent": "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/86.0.4240.111 Safari/537.36"}
    request = urllib.request.Request(url, headers=head)
    html = ""
    try:
        response = urllib.request.urlopen(request)
        html = response.read().decode("utf-8")
        # print(html)
    except urllib.error.URLError as e:
        if hasattr(e, "code"):
            print(e.code)
        if hasattr(e, "reason"):
            print(e.reason)
    return html


# 保存数据
def saveData(savepath):
    print("save....")


if __name__ == '__main__':
    main()