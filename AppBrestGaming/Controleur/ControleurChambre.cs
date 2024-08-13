using AppBrestGaming.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBrestGaming.Controleur
{
    public class ControleurChambre
    {
        private ChambreDAO daoChambre;

        public ControleurChambre()
        {
            daoChambre = new ChambreDAO();
        }

        public List<Chambre> GetListeChambres()
        {
            return daoChambre.GetListe();
        }

    }
}
