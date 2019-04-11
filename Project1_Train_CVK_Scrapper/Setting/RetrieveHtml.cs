using ClassLibrary1_CVK.Model;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_Train_CVK_Scrapper.Setting
{
    class RetrieveHtml
    {
        public static List<Region> getHtmlHref()
        {
            var url = "https://www.cvk.gov.ua/pls/vp2019/wp335pt001f01=719.html";

            List<Region> regions = new List<Region>();

            var web = new HtmlWeb();
            web.OverrideEncoding = Encoding.GetEncoding(1251);
            var htmlDocument = web.Load(url);

            HtmlNode nodeTBody = htmlDocument.DocumentNode.SelectSingleNode("//table");

            var i = -1;

            List<TerretoryOkrug> okrugs = new List<TerretoryOkrug>();
            Region region = null;

            foreach (var nodeTr in nodeTBody.Descendants("tr"))
            {
                var nodeTds = nodeTr.Descendants("td");
                if (nodeTds.Count() == 1)
                {
                    if(i != -1)
                    {
                        regions.Add(new Region(region.RegionName, region.Count, okrugs));
                        okrugs = new List<TerretoryOkrug>();
                        region = null;

                        //Console.WriteLine(region.RegionName + regions.ElementAt(i).okrugs.Count());
                        //foreach (TerretoryOkrug ok in regions.ElementAt(i).okrugs)
                        //{
                        //    Console.WriteLine(ok.Id);
                        //}                        
                        //Console.WriteLine("-------------------------------");
                    }
                    i++;
                    string temp = nodeTds.ElementAt(0).InnerText;

                    if (temp != "\n")
                    {
                        string[] regionAndCount = temp.Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries);
                        region = new Region(regionAndCount[0], Convert.ToInt32(regionAndCount[1]));

                    }else
                    {
                        region = new Region("Закордонний вибочий округ", 1);
                    }
                }

                if (nodeTds.Count() > 1)
                {
                    TerretoryOkrug terretoryOkrug = new TerretoryOkrug(
                        nodeTds.ElementAt(0).InnerText.Replace("\n", string.Empty),
                        Convert.ToInt32(nodeTds.ElementAt(1).SelectSingleNode("a").InnerText),
                        Convert.ToInt32(nodeTds.ElementAt(2).InnerText),
                        nodeTds.ElementAt(3).InnerText.Replace("\n", string.Empty)
                        );
                    okrugs.Add(getChildDepartments(nodeTds.ElementAt(1).SelectSingleNode("a").GetAttributeValue("href", ""), terretoryOkrug));

                }

            }

            regions.Add(new Region(region.RegionName, region.Count, okrugs));
            //Console.WriteLine(region.RegionName + regions.ElementAt(i).okrugs.Count());

            return regions;
        }


        public static TerretoryOkrug getChildDepartments(string url, TerretoryOkrug t)
        {
            List<Department> dep = new List<Department>();
            var u = "https://www.cvk.gov.ua/pls/vp2019/" + url;

            var web = new HtmlWeb();

            var htmlDocument = web.Load(u);
            HtmlNode nodeTBody = htmlDocument.DocumentNode.SelectSingleNode("//table");

            foreach (var nodeTr in nodeTBody.Descendants("tr"))
            {
                var nodeTds = nodeTr.Descendants("td");
                if (nodeTds.Count() > 0)
                {
                    dep.Add(new Department(
                        nodeTds.ElementAt(0).SelectSingleNode("b").InnerText,
                        Convert.ToInt32(nodeTds.ElementAt(1).InnerText),
                        Convert.ToInt32(nodeTds.ElementAt(2).InnerText),
                        Convert.ToInt32(nodeTds.ElementAt(3).InnerText),
                        Convert.ToInt32(nodeTds.ElementAt(4).InnerText),
                        Convert.ToInt32(nodeTds.ElementAt(5).InnerText),
                        Convert.ToInt32(nodeTds.ElementAt(6).InnerText),
                        Convert.ToInt32(nodeTds.ElementAt(7).InnerText),
                        Convert.ToInt32(nodeTds.ElementAt(8).InnerText),
                        Convert.ToInt32(nodeTds.ElementAt(9).InnerText),
                        Convert.ToInt32(nodeTds.ElementAt(10).InnerText),
                        Convert.ToInt32(nodeTds.ElementAt(11).InnerText),
                        Convert.ToInt32(nodeTds.ElementAt(12).InnerText),
                        Convert.ToInt32(nodeTds.ElementAt(13).InnerText),
                        Convert.ToInt32(nodeTds.ElementAt(14).InnerText),
                        Convert.ToInt32(nodeTds.ElementAt(15).InnerText),
                        Convert.ToInt32(nodeTds.ElementAt(16).InnerText),
                        Convert.ToInt32(nodeTds.ElementAt(17).InnerText),
                        Convert.ToInt32(nodeTds.ElementAt(18).InnerText),
                        Convert.ToInt32(nodeTds.ElementAt(19).InnerText),
                        Convert.ToInt32(nodeTds.ElementAt(20).InnerText),
                        Convert.ToInt32(nodeTds.ElementAt(21).InnerText),
                        Convert.ToInt32(nodeTds.ElementAt(22).InnerText),
                        Convert.ToInt32(nodeTds.ElementAt(23).InnerText),
                        Convert.ToInt32(nodeTds.ElementAt(24).InnerText),
                        Convert.ToInt32(nodeTds.ElementAt(25).InnerText),
                        Convert.ToInt32(nodeTds.ElementAt(26).InnerText),
                        Convert.ToInt32(nodeTds.ElementAt(27).InnerText),
                        Convert.ToInt32(nodeTds.ElementAt(28).InnerText),
                        Convert.ToInt32(nodeTds.ElementAt(29).InnerText),
                        Convert.ToInt32(nodeTds.ElementAt(30).InnerText),
                        Convert.ToInt32(nodeTds.ElementAt(31).InnerText),
                        Convert.ToInt32(nodeTds.ElementAt(32).InnerText),
                        Convert.ToInt32(nodeTds.ElementAt(33).InnerText),
                        Convert.ToInt32(nodeTds.ElementAt(34).InnerText),
                        Convert.ToInt32(nodeTds.ElementAt(35).InnerText),
                        Convert.ToInt32(nodeTds.ElementAt(36).InnerText),
                        Convert.ToInt32(nodeTds.ElementAt(37).InnerText),
                        Convert.ToInt32(nodeTds.ElementAt(38).InnerText),
                        Convert.ToInt32(nodeTds.ElementAt(39).InnerText),
                        Convert.ToInt32(nodeTds.ElementAt(40).InnerText),
                        Convert.ToInt32(nodeTds.ElementAt(41).InnerText),
                        Convert.ToInt32(nodeTds.ElementAt(42).InnerText),
                        Convert.ToInt32(nodeTds.ElementAt(43).InnerText),
                        Convert.ToInt32(nodeTds.ElementAt(44).InnerText),
                        Convert.ToInt32(nodeTds.ElementAt(45).InnerText),
                        Convert.ToInt32(nodeTds.ElementAt(46).InnerText),
                        Convert.ToInt32(nodeTds.ElementAt(47).InnerText),
                        Convert.ToInt32(nodeTds.ElementAt(48).InnerText),
                        Convert.ToInt32(nodeTds.ElementAt(49).InnerText),
                        nodeTds.ElementAt(50).InnerText.Replace("\n", string.Empty)
                        ));
                }
            }
            return new TerretoryOkrug(t.Id, t.Total, t.Processed, t.Description, dep);

        }
    }
}
