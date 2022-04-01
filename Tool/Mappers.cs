using CvAsp2.Models;
using DAL = Model_Data_Acces_Layer.Model;
using ASP = CvAsp2.Models;

namespace CvAsp2.Tool
{
    public static class Mappers
    {
        public static ASP.InfoPerso ToASP(this DAL.InfoPerso p)
        {
            return new InfoPerso
            {
                Id = p.Id,
                Name = p.Name,
                FirstName = p.FirstName,
                Adress = p.Adress,
                Téléphone =p.Téléphone,
                Email = p.Email,
                Etablissement = p.Etablissement,
                Default1 = p.Default1,
                Default2 = p.Default2,
                Default3 = p.Default3,
                Qualité1 = p.Qualité1,
                Qualité2 = p.Qualité2,
                Qualité3 = p.Qualité3,
                Diplome = p.Diplome,




            };
        }

        public static DAL.InfoPerso FormToDAL(this InfoPersoForm p)
        {
            return new DAL.InfoPerso
            {
                Id = p.Id,
                Name = p.Name,
                FirstName = p.FirstName,
                Adress = p.Adress,
                Téléphone =p.Téléphone,
                Email =p.Email,
                Etablissement = p.Etablissement,
                Default1 = p.Default1,
                Default2 = p.Default2,
                Default3 = p.Default3,
                Qualité1 = p.Qualité1,
                Qualité2 = p.Qualité2,
                Qualité3 = p.Qualité3,
                Diplome = p.Diplome,

            };
        }

        public static InfoPersoForm ToFormView(this DAL.InfoPerso p)
        {
            return new InfoPersoForm
            {
                Id = p.Id,
                Name = p.Name,
                FirstName = p.FirstName,
                Adress = p.Adress,
                Email = p.Email,
                Téléphone =p.Téléphone,
                Etablissement = p.Etablissement,
                Default1 = p.Default1,
                Default2 = p.Default2,
                Default3 = p.Default3,
                Qualité1 = p.Qualité1,
                Qualité2 = p.Qualité2,
                Qualité3 = p.Qualité3,
                Diplome = p.Diplome,

            };
        }
        public static ExpérienceForm ToFormView(this DAL.Expérience p)
        {
            return new ExpérienceForm
            {
                Id = p.Id,
                AnnéeDébut= p.AnnéeDébut,
                AnnéeFin = p.AnnéeFin,
                Employeur = p.Employeur,
                Fonction = p.Fonction

            };
        }
        public static CompétenceForm ToFormView(this DAL.Compétences p)
        {
            return new CompétenceForm
            {
                Id = p.Id,
                Name = p.Name

            };
        }

        public static ASP.AppUser ToASP(this DAL.AppUser user)
        {
            return new ASP.AppUser
            {
                Id = user.Id,
                Email = user.Email,
                
            };
        }
        public static DAL.Expérience FormToDAL(this ExpérienceForm p)
        {
            return new DAL.Expérience
            {
                Id = p.Id,
               AnnéeDébut = p.AnnéeDébut,
               AnnéeFin = p.AnnéeFin,
               Fonction = p.Fonction,
               Employeur = p.Employeur,
            };
        }
        public static DAL.Compétences FormToDAL(this CompétenceForm p)
        {
            return new DAL.Compétences
            {
                Id = p.Id,
                Name=p.Name,
            };
        }
    }
}