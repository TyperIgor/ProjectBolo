using System;
using System.Collections.Generic;

namespace Project.BoloSemanal.Core.DataUtility
{
    public class FindDates
    {
        //ToDo ser melhorado a logica das datas
        public static List<object> GetDatas()
        {
            DateTime dateIni = new DateTime(2021, 4, 1);
            DateTime dateFin = new DateTime(2021, 12, 24);

            var datas = new List<object>();

            while (dateIni < dateFin)
            {
                if (dateIni.DayOfWeek == DayOfWeek.Thursday)
                    datas.Add(dateIni.ToString("dd/MM"));

                dateIni = dateIni.AddDays(7);
            }

            return datas;
        }
    }
}
