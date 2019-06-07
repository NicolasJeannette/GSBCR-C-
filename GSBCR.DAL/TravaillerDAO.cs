using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GSBCR.modele;
using System.Threading.Tasks;

namespace GSBCR.DAL
{
    public static class TravaillerDAO
    {
        public static void insert(TRAVAILLER t)
        {
            using (var context = new GSB_VisiteEntities())
            {
                context.TRAVAILLER.Add(t);
                context.SaveChanges();
            }

        }
    }
}
