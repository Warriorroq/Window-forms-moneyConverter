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
        private string _url = "https://kurs.com.ua/";
        private string CallUrl()
        {
            HttpClient client = new HttpClient();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls13;
            client.DefaultRequestHeaders.Accept.Clear();
            try {
                var response = client.GetStringAsync(_url);
                return response.Result;
            }
            catch(AggregateException) {
                return string.Empty;
            }
        }
        public List<(string, string)> Parce()
        {
            HtmlDocument htmlDoc = new HtmlDocument();
            var url = CallUrl();
            if (url != string.Empty) {
                htmlDoc.LoadHtml(CallUrl());
            }
            else {
                return null;
            }

            List<HtmlNode> notesCourse = null;
            List<HtmlNode> notesName = null;
            List<(string, string)> moneys = new List<(string, string)>();
            try {

                notesCourse = htmlDoc.DocumentNode.Descendants("div")
                     .Where(node => node.HasClass("course")).ToList();
                notesName = htmlDoc.DocumentNode.Descendants("a")
                    .Where(node => node.HasClass("dotted")).ToList();

                for (int i = 0; i < notesName.Count; i++)
                    moneys.Add((notesCourse[i * 4].InnerText.Split()[0], notesName[i].InnerText));
            }
            catch {

            }
            return moneys;
        }
    }
}
