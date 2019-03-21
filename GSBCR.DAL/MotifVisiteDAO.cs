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
    public static class MotifVisiteDAO
    {
        public static MOTIF_VISITE FindById(string code)
        {
            MOTIF_VISITE motif = null;
            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from m in context.MOTIF_VISITE.Include("LesRapports")
                          where m.MOT_CODE == code
                          select m;
                motif= req.SingleOrDefault<MOTIF_VISITE>();

            }
            return motif;
        }

        public static List<MOTIF_VISITE> FindAll()
        {
            List<MOTIF_VISITE> motifs = null;
            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from m in context.MOTIF_VISITE.Include("LesRapports")
                          select m;
                motifs = req.ToList<MOTIF_VISITE>();

            }
            return motifs;
            //A faire : charger tous les motifs visite
            
        }
    }
}
