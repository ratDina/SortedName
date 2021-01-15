using System;
using System.Collections.Generic;
using System.IO;
using System.Web;

namespace AppSortedName
{
    public class sortLib
    {
        private static string filePath = AppContext.BaseDirectory + "sorted-names-list.txt";
        public static string fileUnsortedList = "unsorted-names-list.txt";

        #region variable for UnitTest

        public  List<string> listUnsort;
        public  List<string> listGetName;
        public List<string> listSortedList;
        #endregion
        public List<string> unsortedList()
        {

            var data = new List<string>();
            StreamReader readFile = File.OpenText(AppContext.BaseDirectory + "\\" + fileUnsortedList);
            string content = readFile.ReadToEnd();

            var g = content.Replace("\r\n", "\n").Split('\n');
            for (int i = 0; i < g.Length; i++)
                data.Add(g[i]);

            data.Sort();
            listUnsort = data;

            return data;
        }

        public List<string> GetLastName(List<string> data)
        {
            var x = new List<string>();
            for (int i = 0; i < data.Count; i++)
            {
                var s = data[i].Split(' ');
                x.Add(s[s.Length - 1]);
            }
            x.Sort();

            listGetName = x;
            return x;
        }

        public List<string> CreateSortedList(List<string> lastName, List<string> fullName)
        {
            var sortedList = new List<string>();
            var data = string.Empty;

            for (int y = 0; y < lastName.Count; y++)
            {

                for (int h = 0; h < fullName.Count; h++)
                {
                    var z = fullName[h];
                    var zArray = z.Split(' ');
                    if (zArray[zArray.Length - 1].Equals(lastName[y]))
                    {

                        sortedList.Add(z);
                        data += z + "\n";
                        fullName.Remove(z);
                        break;
                    }
                }
            }

            listSortedList = sortedList;
            CreateFileSort(data);
            
            return sortedList;
        }

        private void CreateFileSort(string name)
        {
            StreamWriter w;
            w = File.CreateText(filePath);
            if (Directory.Exists(filePath))
                File.Delete(filePath);
            else
                w.WriteLine(name);
            w.Flush();
            w.Close();
        }

        public string InfoFileSort()
        {
            return filePath;
        }


    }


}