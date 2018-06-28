using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Delivery.SourseData;

namespace Delivery
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private int _SecondData;
        private int _FirstData;
        //public int FirstData { get; set; }
        //public int SecondData { get; set; }
        SourceClass sc = new SourceClass();

        public int FirstData
        {
            get
            {
                return _FirstData;
            }

            set
            {
                _FirstData = value;
            }
        }

        public int SecondData
        {
            get
            {
                return SecondData1;
            }

            set
            {
                SecondData1 = value;
            }
        }

        public int FirstData1
        {
            get
            {
                return _FirstData;
            }

            set
            {
                _FirstData = value;
            }
        }

        public int SecondData1
        {
            get
            {
                return _SecondData;
            }

            set
            {
                _SecondData = value;
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)//Save
        {
            sc.SaveDeliverTable(DeliverDataGrid);
        }
        private void button_Click(object sender, RoutedEventArgs e)//delete
        {
            sc.DeliteDeliver(DeliverDataGrid);
        }
        private void button1_Copy_Click(object sender, RoutedEventArgs e)//edit
        {
            sc.EditDeliver(DeliverDataGrid.SelectedIndex);
        }
        private void button3_Click(object sender, RoutedEventArgs e)//Отчёт по сумам в доставках
        {
            Delivery.Tool.SummaryInformation si = new Tool.SummaryInformation();
            si.GetSum(DeliverDataGrid);
        }
        private void button2_Click(object sender, RoutedEventArgs e)//фильтр по датам
        {
            Delivery.Tool.Filter si =  new Tool.Filter();
            si.GetFiltred(DeliverDataGrid, dataGrid, _FirstData, SecondData1);
        }
        private void button2_Copy_Click(object sender, RoutedEventArgs e)//костыльное снятие фильтра
        {
            sc.DeliverTableBiding(DeliverDataGrid);
        }
    }
}
