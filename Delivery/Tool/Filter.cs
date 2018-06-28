using Delivery.SourseData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;


namespace Delivery.Tool
{
    class Filter
    {
        //public int FirstData { get; set; }
       // public int SecondData { get; set; }
        SourceClass sc = new SourceClass();



        public void GetFiltred(DataGrid dg, DataGrid dg2, int FirstData, int SecondData)
        {
            List<Deliver> FiltredDeliverList =new List<Deliver>();
            List<Deliver> deliverList = sc.GetDeliver().ToList();
            dg2.DataContext = deliverList;
            foreach (var item in deliverList)
            {
                if (int.Parse(item.OrderDate) >= FirstData && int.Parse(item.OrderDate) <= SecondData)
                {
                    FiltredDeliverList.Add(item);
                }
            }
                dg.DataContext = FiltredDeliverList;
        }

        public IEnumerable<Deliver> GetDgItem(DataGrid dg)
        {
            return dg.Items.Cast<Deliver>();
        }

        }
    }

