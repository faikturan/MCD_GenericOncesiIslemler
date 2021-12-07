using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MCD_GenericOncesiIslemler
{
    public class sanalDatabase
    {
        private ArrayList listem;

        public sanalDatabase()
        {
            listem = new ArrayList();
        }

       public void yeniKayit(int data)
        {
            listem.Add(data);
        }
    }
}
