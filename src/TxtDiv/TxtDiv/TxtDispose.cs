using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TxtDiv
{
    class TxtDispose
    {
        public int MinLocation(int SepSize) //min En word location
        {
            return SepSize - 1;
        }

        public bool CHJuge(char c)//Chinese word juge
        {
            return (int)c >= 0x4E00 && (int)c <= 0x9FA5;
        }

        public int UpDateSep(long FileSize, int SepSize, int Tail)//tail dispose
        {
            if (FileSize % SepSize > Tail) return SepSize;
            else return SepSize + Tail / (int)(FileSize / SepSize + 1);
        }

        public int TxtLenght(string str)//string lenght
        {
          return System.Text.Encoding.Default.GetByteCount(str);
        }

        public bool SepEnd(string str,long SepSize) 
        {
            return (str.Length == SepSize) || (str.Length + 1 == SepSize) || (str.Length + 2 == SepSize);
        }

        public int DivNum(long FileSize, int SepSize)
        {
            if (FileSize % SepSize == 0) return (int)(FileSize / (long)SepSize);
            else return (int)(FileSize / (long)SepSize) + 1;
        }
    }
}
