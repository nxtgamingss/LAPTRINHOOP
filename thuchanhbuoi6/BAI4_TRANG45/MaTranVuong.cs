using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI4_TRANG45
{
    public class MaTranVuong : MaTran
    {
        public MaTranVuong(int soDong) : base(soDong, soDong) { }

        public double GetDeterminant()
        {

            if (soDong == 1) return maTran[0, 0];
            if (soDong == 2) return maTran[0, 0] * maTran[1, 1] - maTran[0, 1] * maTran[1, 0];

            double det = 0;
            for (int i = 0; i < soDong; i++)
            {
                double[,] subMaTran = new double[soDong - 1, soDong - 1];
                for (int j = 1; j < soDong; j++)
                {
                    for (int k = 0; k < soDong; k++)
                    {
                        if (k < i) subMaTran[j - 1, k] = maTran[j, k];
                        else if (k > i) subMaTran[j - 1, k - 1] = maTran[j, k];
                    }
                }
                MaTranVuong subMaTranVuong = new MaTranVuong(soDong - 1);
                subMaTranVuong.maTran = subMaTran;
                det += (i % 2 == 0 ? 1 : -1) * maTran[0, i] * subMaTranVuong.GetDeterminant();
            }
            return det;
        }

        public double DuongCheoChinh()
        {
            double tong = 0;
            for (int i = 0; i < soDong; i++)
            {
                tong += maTran[i, i];
            }
            return tong;
        }
    }

}
