using System;
using System.Collections.Generic;
using System.Text;

namespace KeThua_DaHinh
{
    class Cha
    {
        int data;
     
        public int Data { get => data; set => data = value; }

        public Cha()
        {

        }
        public Cha(int data)
        {x
            data = Data;
        }
        public void Xuat()
        {
            Console.WriteLine("data cua cha la"+data);
        }
        public override string ToString()
        {
            return Data.ToString();
        }
    }
    public class Con : Cha
    { 
        public int y;

 c       public Con()
        {

        }
        public Con(int data, int y1):base(data)
        {
            Data = data;
            y = y1;
        }
        public void Xuat ()
        {
            Console.WriteLine("data cua con la data ={0} va y {1}",Data, y);
        }
}
