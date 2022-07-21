using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Insertion_Sort
{
    class Siralama
    {
        public static int[] siralama(int[] dizi)
        {
            for (int i = 0; i < dizi.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (dizi[j - 1] > dizi[j])
                    {
                        int temp = dizi[j - 1];
                        dizi[j - 1] = dizi[j];
                        dizi[j] = temp;
                    }
                }
            }
            return dizi;                           
        }

        public static void Yazdirma(int[] dizi, ListBox listbox)
        {
            for (int sayac2 = 0; sayac2 < 5; sayac2++)
            {
                listbox.Items.Add(Convert.ToString(dizi[sayac2]));
            }
        }
    }
}
