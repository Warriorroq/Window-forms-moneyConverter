using System.Linq;
using System;
using HtmlAgilityPack;
using System.Collections.Generic;
using System.Net.Http;
using System.Net;

namespace WinFormsApp1
{
    public class BankParcer
    {
        private string url = "https://kurs.com.ua/";
        private string CallUrl
        {
            get
            {
                HttpClient client = new HttpClient();
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls13;
                client.DefaultRequestHeaders.Accept.Clear();
                var response = client.GetStringAsync(url);
                return response.Result;
            }
        }
        public List<(string, string)> Parce()
        {
            HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(CallUrl);
            List<HtmlNode> notesCourse = null;
            List<HtmlNode> notesName = null;
            List<(string, string)> moneys = new List<(string, string)>();
            try
            {

                notesCourse = htmlDoc.DocumentNode.Descendants("div")
                     .Where(node => node.HasClass("course")).ToList();

                notesName = htmlDoc.DocumentNode.Descendants("a")
                    .Where(node => node.HasClass("dotted")).ToList();

                for (int i = 0; i < notesCourse.Count; i++)
                    moneys.Add((notesCourse[i].InnerText.Split()[0], notesName[i].InnerText));
            }
            catch
            {

            }


            return moneys;
        }
    }
}
