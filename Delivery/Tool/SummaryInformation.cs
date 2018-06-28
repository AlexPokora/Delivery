using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;


namespace Delivery.Tool
{
    class SummaryInformation
    {
        private int _sum;
        public void GetSum(DataGrid dg)//ого считалка
        {
            Sum = 0;
            List<Deliver> deliverList = GetDgItem(dg).ToList();
            foreach (var item in deliverList)
            {
                Sum = int.Parse(item.Sumary);
            }
        }

        public IEnumerable<Deliver> GetDgItem(DataGrid dg)//попытка вытягивать даные из дата грида
        {
            return dg.Items.Cast<Deliver>();
        }
        public int Sum
        {
            get
            {
                return _sum;
            }

            set
            {
                _sum += value;
            }
        }


    }
}
