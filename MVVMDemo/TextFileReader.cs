using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MVVMDemo
{
    class TextFileReader
    {
        public string[] ReadLines()
        {

            FileStream fs = new FileStream("C:/Users/srohithr/Downloads/MVVMDemo/MVVMDemo/inputfile.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            ArrayList lines = new ArrayList();
            string str = sr.ReadLine();
            while (str != null)
            {
                lines.Add(str);
                str = sr.ReadLine();
            }

            sr.Close();
            fs.Close();
            //converting arrayList to string array
            return (string[])lines.ToArray(typeof(string)); ;
        }
    }
}
