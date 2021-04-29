using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleCrawler {
  class SimpleCrawler {
    private bool succeed;
    public Hashtable urls = new Hashtable();
    private int count = 0;
    public List<homework.Urls> u = new List<homework.Urls>();
    public void Crawl() {
      Console.WriteLine("开始爬行了.... ");
      while (true) {
        string current = null;
        foreach (string url in urls.Keys) {
          if ((bool)urls[url]) continue;
          current = url;
        }

        if (current == null || count > 10) break;
        Console.WriteLine("爬行" + current + "页面!");
        string html = DownLoad(current); // 下载
        urls[current] = true;
        homework.Urls ref1 = new homework.Urls();
        ref1.OK = true;
        ref1.Url = current;
        Console.WriteLine(u.Count);
        count++;
        if (Judge(html))
            Parse(html,current);//解析,并加入新的链接
        else if(!succeed) ref1.message = html;
        u.Add(ref1);
        Console.WriteLine("爬行结束");
      }
    }
    private bool Judge(string url)
    {
            if (Regex.IsMatch(url, @"^(ht|f)tp(s?)\:\/\/[0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*(:(0-9)*)*(\/?)([a-zA-Z0-9\-\.\?\,\'\/\\\+&%\$#_]*)?html$")
                || Regex.IsMatch(url, @"^(ht|f)tp(s?)\:\/\/[0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*(:(0-9)*)*(\/?)([a-zA-Z0-9\-\.\?\,\'\/\\\+&%\$#_]*)?jsp$") ||
                 Regex.IsMatch(url, @"^(ht|f)tp(s?)\:\/\/[0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*(:(0-9)*)*(\/?)([a-zA-Z0-9\-\.\?\,\'\/\\\+&%\$#_]*)?aspx"))
            { 
                return true;
            }
            return false;
    }
    public string DownLoad(string url) {
      try {
        WebClient webClient = new WebClient();
        webClient.Encoding = Encoding.UTF8;
        string html = webClient.DownloadString(url);
        string fileName = count.ToString();
        File.WriteAllText(fileName, html, Encoding.UTF8);
        succeed = true;
        return html;
      }
      catch (Exception ex) {
        Console.WriteLine(ex.Message);
        succeed = false;
        return ex.Message;
      }
    }

    public void Parse(string html,string url) {
      string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
      MatchCollection matches = new Regex(strRef).Matches(html);
      foreach (Match match in matches) {
        strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                  .Trim('"', '\"', '#', '>');
        if (!Regex.IsMatch(strRef, @"^(ht|f)tp(s?)\:\/\/[0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*(:(0-9)*)*(\/?)([a-zA-Z0-9\-\.\?\,\'\/\\\+&%\$#_]*)?$"))
        {
                    try
                    {
                        Uri uri = new Uri(url);
                        Uri Abs_uri = new Uri(uri, strRef);
                        strRef = Abs_uri.ToString();
                        Console.WriteLine(strRef);
                    }catch (Exception error)
                    {
                        Console.WriteLine(error.Message);
                    }
        }
        if (strRef.Length == 0) continue;
        if (urls[strRef] == null) urls[strRef] = false;
      }
    }
  }
}
