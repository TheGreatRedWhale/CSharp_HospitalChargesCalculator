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
        public int RxFee { get; set; } = 0;
        public int SurgFee { get; set; } = 0;
        public int LabFee { get; set; } = 0;
        public int RehabFee { get; set; } = 0;

        public int CalcStayCharges()
        {
            return this.Days * 350;
        }

        public int CalcMiscCharges()
        {
            return (RxFee + SurgFee + LabFee + RehabFee);
        }

    }
}
