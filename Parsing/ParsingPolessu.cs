using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Text.RegularExpressions;
using GalaSoft.MvvmLight;

namespace Parsing
{
    class ParsingPolessu : ObservableObject
    {
        WebClient Client = new WebClient();
        public void Pars()
        {
            try
            {
                string html = Client.DownloadString("http://www.polessu.by/ruz/term2/");
                int start = html.IndexOf("13БД-1");
                int end = html.IndexOf("ПН-1601");
                string group = html.Substring(start, end - start); //string group

                string[] arrayGroup = group.Split(new char[] { ',' });  //array group

                for (int i = 0; i < arrayGroup.Length; i++ )
                {
                    arrayGroup[i] = arrayGroup[i].Trim(new char[] { '\'', '\'' });
                    //Console.WriteLine(arrayGroup[i]);
                }

            }       
            catch
            {
               MessageBox.Show("Error");
            }
        }
    }
}
