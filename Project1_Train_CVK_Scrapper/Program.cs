using HtmlAgilityPack;
using Project1_Train_CVK_Scrapper.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Project1_Train_CVK_Scrapper
{
    class Program
    {
        static List<Region> regions = new List<Region>();
        static List<TerretoryOkrug> terretoryOkrugs = new List<TerretoryOkrug>();
        static List<Department> departments = new List<Department>();


        static List<string> urlsFromSite = new List<string>();
        static HttpClient httpClient = new HttpClient();

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            GetHtmlAsyncHref();
            
            Console.ReadLine();
        }

        private static async void GetHtmlAsyncHref()
        {
            var url = "https://www.cvk.gov.ua/pls/vp2019/wp335pt001f01=719.html";

            // дістаємо по нашій url html page
            var html = await httpClient.GetStringAsync(url);

            var htmlDocument = new HtmlDocument();

            htmlDocument.LoadHtml(html);

            var nodeTrs = htmlDocument.DocumentNode.SelectNodes("tr");

            foreach (var node in nodeTrs) {
                HtmlNodeCollection nodes = node.ChildNodes;

                Console.WriteLine(nodes[0].OuterHtml);
            }


            //var node = htmlDocument.DocumentNode.SelectSingleNode("//table");


            //foreach (var nNode in node.Descendants())
            //{
            //    if (nNode.NodeType == HtmlNodeType.Element)
            //    {

            //        Console.WriteLine(nNode.ChildNodes[0].OuterHtml);
            //        //urlsFromSite.Add(nNode.GetAttributeValue("href", ""));
            //    }
            //}

        }

    }
}
