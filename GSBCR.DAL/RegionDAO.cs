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
    public static class RegionDAO
    {
        public static REGION FindById(string code)
        {
            //A faire : rechercher une région par son nom
            REGION reg = null;
            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from m in context.REGION.Include("LeSecteur")
                          where m.REG_CODE == code
                          select m;
                reg = req.SingleOrDefault<REGION>();

            }
            return reg;
            
        }

        public static List<REGION> FindAll()
        {
            //A faire : charger toutes les régions
            List<REGION> regions = null;
            

            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from m in context.REGION.Include("LeSecteur")
                          select m;
                regions = req.ToList<REGION>();

            }

            return regions;
        }
    }
}
