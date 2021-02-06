using System;
using System.Collections.Generic;
namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Collections,list kullanmadan diziye bir eleman ekleme
            string[] isimler1 = new string[] { "Rana", "Meryem", "Asli", "Zehra" };
            string[] temp = new string[] { "Rana", "Meryem", "Asli", "Zehra" };
            //Esas dizimiz olan isimleri gecici olarak atayacagimiz bir temp dizisi olusturdum.
            

            string[] birlesim = new string[isimler1.Length + temp.Length];
            //Sonradan ekleyecegimiz elemanlarla basta tanimladigimiz diziyi birlestirecek dizi.
           
            isimler1 = new string[6];
            //Yeni elemanlar ekleyecegim icin diziyi newledim. 
            isimler1[4] = "Munire";
            isimler1[5] = "Fatma";
          
            for (int i = 0; i < isimler1.Length; i++)
            {
                birlesim[i] = isimler1[i];
            }
            for (int i = 0; i < temp.Length; i++)
            {
                birlesim[i] = temp[i];
            }
            foreach (var dizi in birlesim)
            {
                Console.WriteLine(dizi);
            }







        }
        


    }
}
