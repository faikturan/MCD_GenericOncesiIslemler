﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MCD_GenericOncesiIslemler
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList liste = new ArrayList();
            //liste.Add();

            sanalDatabase sdatabase = new sanalDatabase();
            sdatabase.yeniKayit(1);
            sdatabase.yeniKayit(2);


        }
    }
}
