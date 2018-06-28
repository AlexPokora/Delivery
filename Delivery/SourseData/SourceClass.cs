using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;


namespace Delivery.SourseData
{
    class SourceClass
    {
        Delivery.DrliveryDBModelContainer DataBase = new DrliveryDBModelContainer();

        public void DeliteDeliver(DataGrid dg)//удаление записи
        {
            DataBase.DeliverSet.Local.Remove((Deliver)dg.SelectedItem);
            DataBase.SaveChanges();
        }
        public List<Deliver> DeliverList()//Привязываем любой дата грид к таблице в бд
        {
            return GetDeliver().ToList();
        }
        public void SaveDeliverTable(DataGrid dg)//Сохранение записей
        {
            if (dg.SelectedItems != null)
            {
            DataBase.DeliverSet.Add((Deliver)dg.SelectedItem);
            DataBase.SaveChanges();
            dg.DataContext = GetDeliver().ToList();
            }
        }
        public void EditDeliver(int? discID)// редактирование записи
        {
            Deliver deliver = DataBase.DeliverSet.Where(c => c.Id == c.Id).FirstOrDefault();//узнать что это за строка
            if (deliver != null)
            {
                DataBase.Entry<Deliver>(deliver).State = System.Data.Entity.EntityState.Modified;
                DataBase.SaveChanges();
            }
        }
        public IQueryable<Deliver> GetDeliver()//Запрос или около того
        {
            return DataBase.DeliverSet.AsQueryable<Deliver>();
        }
    }
}
