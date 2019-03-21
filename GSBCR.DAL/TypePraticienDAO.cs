using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSBCR.modele;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


namespace GSBCR.DAL
{
    public static class TypePraticienDAO
    {
        public static TYPE_PRATICIEN FindById(string code)
        {
            //A faire : rechercher un type praticien par son code
           TYPE_PRATICIEN type = null;
            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from p in context.TYPE_PRATICIEN.Include("LesPraticiens")
                          where p.TYP_CODE == code
                          select p;
                type = req.SingleOrDefault<TYPE_PRATICIEN>();

            }
            return type;
            
        }

        public static List<TYPE_PRATICIEN> FindAll()
        {
            //A faire : charger tous les types praticiens
            List<TYPE_PRATICIEN> types = null;
            

            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from m in context.TYPE_PRATICIEN.Include("LesPraticiens")
                          select m;
                types = req.ToList<TYPE_PRATICIEN>();

            }

            return types;
            
        }

    }
}
