//Fucntion one:
//filesize division

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TxtDiv
{
    class TxtDivFunc1
    {
        public string str { get; set; }
        public int SepSize { get; set; }
        public long FileSize { get; set; }

        public TxtDivFunc1(string FilePath, int DivSize)
        {
            TxtIO TxtIO = new TxtIO();
            str = TxtIO.TxtRead(FilePath);
            FileSize = TxtIO.FileSize(FilePath);
            SepSize = DivSize;
        }

        public void func1(int tail)
        {
            int Minloc = 0;
            int start = 0 ,end,SepNum;
            string EndStr = "";
            TxtIO TxtW = new TxtIO();
            TxtDispose TxtDp = new TxtDispose();
            SepSize = TxtDp.UpDateSep(FileSize, SepSize, tail);
            Minloc = TxtDp.MinLocation(SepSize);
            end = Minloc;
            SepNum = TxtDp.DivNum(FileSize, SepSize);
            for (int i = 1; i <= SepNum; i++)
            {
                while (!TxtDp.SepEnd(EndStr, SepSize))
                {
                    EndStr = str.Substring(start, end);
                    end++;
                }
                TxtW.TxtWrite("Div"+i+".txt", EndStr);
                EndStr = "";
                start = start + end + 1;
                end = Minloc;
                if (str.Substring(start, str.Length-start).Length < SepSize)
                {
                    TxtW.TxtWrite("Div" + (i+1) + ".txt", str.Substring(start, str.Length - start));
                    break;
                }
            }

        }
    }
}
