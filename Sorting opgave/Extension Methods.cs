using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_opgave
{
    public static class Extension_Methods
    {

        //{ 6, 2, 8, 4, 1, 9, };
        //Bliver brugt til at kunne skrive sorting direkte på listen. (list.Sorting(start,slut))
        public static List<int> Sorting(this List<int> list, int start, int slut)
        {

            StartSort(list, start, slut);
            
            return list;
        }
        //Her bliver sorteringen kørt igennem rekursivt så den kommer igennem hele listen og sortere det hele. Der bliver startet forfra og splittes ved midten hvor hver side bliver sorteret for sig selv. Dette fortsættes med at splittes til at der er kommet en løsning på sorteringen.
        private static void StartSort(List<int> list, int start, int slut)
        {
            if (start < slut)
            {
                int mid = Splitting(list, start, slut);

                if (mid > 1)
                {
                    list.Sorting(start, mid-1);
                }
                if (mid + 1 < slut)
                {
                    list.Sorting(mid + 1, slut);
                }
            }
        }
        //Her bliver den endelige sortering gjort hvor den bytter rundt på tallene fra starten og slutningen. Dette kommer tættere og tættere på midten hvilket bliver gjort ved at fjerne en fra end og tilføje en til start.
        private static int Splitting(List<int> list, int start, int end)
        {
            int mid = list[start];
            while (true)
            {
                if(list[start] < mid)
                {
                    start++;
                }
                if(list[end] > mid)
                {
                    end--;
                }

                if(start < end)
                {
                    int temp = list[start];
                    list[start] = list[end];
                    list[end] = temp;
                    if (list[start] == list[end])
                    {
                        start++;
                    }
                }
                else
                {
                    return end;
                }
            }
        }
        
        
        
        
    }
}
