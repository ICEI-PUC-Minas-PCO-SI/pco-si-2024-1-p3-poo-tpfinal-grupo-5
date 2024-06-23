﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrnaEletronica.Data.Configs
{
    public class Consts
    {
        private const string _connectionString = "Server=localhost;port=3306;Database=urna;Uid=root;Pwd=;";

        public static string ConnectionString
        {
            get
            {
                return _connectionString;
            }
        }
    }
}
