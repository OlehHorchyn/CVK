using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1_CVK.Model;
using Newtonsoft.Json;

namespace ClassLibrary1_CVK
{
    public class JsonStorage : DAOSetting
    {

        public CVK retrieveFromFile(){
            CVK existCVK = null;

            string stringJson = "";

            using (StreamReader sr = new StreamReader(@"D:\C# Projects\cvk.json"))
            {
                stringJson = sr.ReadToEnd();
            }

            existCVK = JsonConvert.DeserializeObject<CVK>(stringJson);

            return existCVK;
        }

        public void upsert(CVK cvk)
        {
            CVK existCVK = retrieveFromFile();
            if (existCVK != null)
            {
                Console.WriteLine("Exist : " + existCVK.CVKHashCode);
                Console.WriteLine("New : " + cvk.CVKHashCode);

                if (cvk.CVKHashCode != existCVK.CVKHashCode)
                {
                    for (int i = 0; i < cvk.Regions.Count(); i++)
                    {
                        if (cvk.Regions.ElementAt(i).RegionHashCode != existCVK.Regions.ElementAt(i).RegionHashCode)
                        {
                            for (int j = 0; j < cvk.Regions.ElementAt(i).okrugs.Count(); j++)
                            {
                                if (cvk.Regions.ElementAt(i).okrugs.ElementAt(j).OkrugHashCode !=
                                    existCVK.Regions.ElementAt(i).okrugs.ElementAt(j).OkrugHashCode)
                                {
                                    existCVK.Regions.ElementAt(i).okrugs.ElementAt(j).Processed = cvk.Regions.ElementAt(i).okrugs.ElementAt(j).Processed;

                                    for (int k = 0; k < cvk.Regions.ElementAt(i).okrugs.ElementAt(j).departments.Count(); k++)
                                    {
                                        int index = existCVK.Regions.ElementAt(i).okrugs.ElementAt(j).departments.IndexOf(
                                                cvk.Regions.ElementAt(i).okrugs.ElementAt(j).departments[k]);
                                        if (index != -1)
                                        {
                                            if (cvk.Regions.ElementAt(i).okrugs.ElementAt(j).departments.ElementAt(k).DepHashCode !=
                                                existCVK.Regions.ElementAt(i).okrugs.ElementAt(j).departments.ElementAt(index).DepHashCode)
                                            {
                                                Console.WriteLine("Dep Change - " + index);
                                                existCVK.Regions.ElementAt(i).okrugs.ElementAt(j).departments[index] = cvk.Regions.ElementAt(i).okrugs.ElementAt(j).departments.ElementAt(k);
                                            }
                                        }
                                        else
                                        {
                                            existCVK.Regions.ElementAt(i).okrugs.ElementAt(j).departments.Add(
                                                cvk.Regions.ElementAt(i).okrugs.ElementAt(j).departments.ElementAt(k));
                                            Console.WriteLine("Dep Add - ", cvk.Regions.ElementAt(i).okrugs.ElementAt(j).departments.ElementAt(k).Id);
                                        }
                                    }
                                    existCVK.Regions.ElementAt(i).okrugs.ElementAt(j).OkrugHashCode = cvk.Regions.ElementAt(i).okrugs.ElementAt(j).OkrugHashCode;
                                }
                            }
                            existCVK.Regions.ElementAt(i).RegionHashCode = cvk.Regions.ElementAt(i).RegionHashCode;
                        }
                    }
                    existCVK.CVKHashCode = cvk.CVKHashCode;

                    Console.WriteLine("Final : " + existCVK.CVKHashCode);
                    saveFile(existCVK);
                }
            }
            else
            {
                saveFile(cvk);
            }
            Console.WriteLine("Upsert End");
        }

        public void saveFile(CVK cvk)
        {
            string jsonList = JsonConvert.SerializeObject(cvk, Formatting.Indented);

            using (StreamWriter sw = new StreamWriter(@"D:\C# Projects\cvk.json", false, System.Text.Encoding.UTF8))
            {
                sw.WriteLine(jsonList);
            }
        }

    }
}
