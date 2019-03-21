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
    public static class FamilleDAO
    {
        public static FAMILLE FindById(string code)
        {
            //A faire : rechercher une famille de médicaments par son nom
            FAMILLE fam = null;
            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from m in context.FAMILLE.Include("lesMedicaments")
                          where m.FAM_CODE == code
                          select m;
                fam = req.SingleOrDefault<FAMILLE>();

            }
            return fam;
        }

        public static List<FAMILLE> FindAll()
        {
            //A faire : charger toutes les familles de médicaments
            List<FAMILLE> fams = null;
            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from m in context.FAMILLE.Include("lesMedicaments")
                          select m;
                fams = req.ToList<FAMILLE>();

            }
            return fams;
            
        }

    }
}
