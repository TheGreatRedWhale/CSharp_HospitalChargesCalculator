using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalFormsApp
{
    class HospitalCharges
    {
        public int Days { get; set; } = 0;
        public int StayFee { get; private set; } = 0;
        public int RxFee { get; set; } = 0;
        public int SurgFee { get; set; } = 0;
        public int LabFee { get; set; } = 0;
        public int RehabFee { get; set; } = 0;

        public void CalcStayCharges()
        {
            this.StayFee = this.Days * 350;
        }

    }
}
