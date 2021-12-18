using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfString
{
    public class Box<T>
    {
        public T Info { get; set; }

        public Box(T info)
        {
            this.Info = info;
        }

        public override string ToString() => $"{Info.GetType()}: {Info}";
        
       public bool Compare<T>(T element) where T : IComparable
        {
            bool isBigger = false;
            if (element.CompareTo(Info) < 0)
            {
                isBigger = true;
            }
            return isBigger;
        }
    }
}
