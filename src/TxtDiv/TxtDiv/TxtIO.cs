using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TxtDiv
{
    class TxtIO
    {
        public string TxtRead(string FilePath)
        {
            string ReadStr;
            FileStream TxtFile = new FileStream(FilePath,FileMode.Open);
            StreamReader StrR = new StreamReader(TxtFile,UnicodeEncoding.GetEncoding("GB2312"));
            ReadStr = StrR.ReadToEnd();
            StrR.Close();
            TxtFile.Close();
            return ReadStr; 
        }

        public void TxtWrite(string FilePath,string WriteStr)
        {
            FileStream TxtFile = new FileStream(FilePath,FileMode.OpenOrCreate);
            StreamWriter StrR = new StreamWriter(TxtFile, UnicodeEncoding.GetEncoding("GB2312"));
            StrR.Write(WriteStr);
            StrR.Close();
            TxtFile.Close();
        }

        public long FileSize(string FilePath)
        {
            long FlSize = 0;
            FileStream Server = new FileStream(FilePath, FileMode.Open);
            FlSize = Server.Length;
            Server.Close();
            return FlSize;
        }
    }
}
