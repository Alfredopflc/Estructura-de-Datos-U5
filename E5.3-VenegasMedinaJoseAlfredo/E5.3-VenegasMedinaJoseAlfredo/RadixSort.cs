using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E5._3_VenegasMedinaJoseAlfredo
{
    class RadixSort
    {
        public void Sort(int[] arr)
        {
            int i, j;
            int[] tmp = new int[arr.Length];

            for (int shift = 31; shift >= 0; --shift)
            {
                j = 0;
                for (i = 0; i < arr.Length; ++i)
                {
                    bool move = (arr[i] << shift) >= 0;
                    if (shift == 0 ? !move : move)
                        arr[i - j] = arr[i];
                    else
                        tmp[j++] = arr[i];
                }
                Array.Copy(tmp, 0, arr, arr.Length - j, j);
            }
        }
    }
}
