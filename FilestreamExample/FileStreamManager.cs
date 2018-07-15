using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace FilestreamExample
{
    class FileStreamManager
    {
        public string[] Params = new string[100];

        public void WriteFile(string path)
        {
            Stream  fs = new FileStream(path, FileMode.Open , FileAccess.Write);

            StreamWriter sw = new StreamWriter(fs);

            for (int x=0; x<100; x++)
            {
                sw.WriteLine(Params[x]);
            }
            sw.Close();
            fs.Close();
        }

        public void ReadFile(string path)
        {
            Stream fs = new FileStream(path, FileMode.Open, FileAccess.Read);

            StreamReader sr = new StreamReader(fs);

            for (int x = 0; x < 100; x++)
            {
                Params[x]=sr.ReadLine();
            }
            sr.Close();
            fs.Close();
        }

        public void InitParam()
        {
            for (int x = 0; x < 100; x++)
            {
                Params[x] = "test";
            }
        }
    }

    
}