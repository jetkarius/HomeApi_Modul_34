﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeApi.Contracts.Models.Validation
{
    /// <summary>
    /// Класс-хранилище допустимых значений для валидаторов
    /// </summary>
    public static class Values
    {
        public static string[] ValidRooms = new[]
        {
       "Кухня",
       "Ванная",
       "Гостиная",
       "Туалет",
       "Kitchen",
       "Bathroom",
        "livingroom"
   };
    }
}
