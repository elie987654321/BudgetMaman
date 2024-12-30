using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Dev
{
    public static class Langue {

        public enum LangueEnum
        {
            Francais,
            Anglais
        }

        public static class LangueSetting
        {
            public static LangueEnum langue = LangueEnum.Francais;

        }
        public static class FormPrincipal
        {
            public static string getBtnAjouterCategorie()
            {
                if (LangueSetting.langue == LangueEnum.Francais)
                {
                    return btnAjouterCategorieFrancais;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }

            public static string getBtnModifierCategorie()
            {
                if (LangueSetting.langue == LangueEnum.Francais)
                {
                    return btnModifierCategorieFrancais;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }

            public static string getBtnSupprimerCategorie()
            {
                if (LangueSetting.langue == LangueEnum.Francais)
                {
                    return btnSupprimerCategorieFrancais;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }


            public static string getBtnNouvellePeriode()
            {
                if (LangueSetting.langue == LangueEnum.Francais)
                {
                    return btnNouvellePeriodeFrancais;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }

            public static string getLblNomDepense()
            {
                if (LangueSetting.langue == LangueEnum.Francais)
                {
                    return lblNomDepenseFrancais;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }

            public static string getLblMontantDepense()
            {
                if (LangueSetting.langue == LangueEnum.Francais)
                {
                    return lblMontantDepenseFrancais;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }

            public static string getBtnAjouter()
            {
                if (LangueSetting.langue == LangueEnum.Francais)
                {
                    return btnAjouterFrancais;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }


            public static string getBtnAnnuler()
            {
                if (LangueSetting.langue == LangueEnum.Francais)
                {
                    return btnAnnulerFrancais;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }

            public static string getLblErreurVeuillerCreerCategorie()
            {
                if (LangueSetting.langue == LangueEnum.Francais)
                {
                    return lblErreurVeuillezCreerCategorieFrancais;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }

            public static string getLblErreurVeuillezEntrerInformationFrancais()
            {
                if (LangueSetting.langue == LangueEnum.Francais)
                {
                    return lblErreurVeuillezEntrerInformationFrancais;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }

            public static string getPopupDoitAvoirCategoriePourModifier()
            {
                if (LangueSetting.langue == LangueEnum.Francais)
                {
                    return popupDoitAvoirCategoriePourModifierFrancais;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }

            public static string getDebutLblDateDebutPeriode()
            {
                if (LangueSetting.langue == LangueEnum.Francais)
                {
                    return debutLblDateDebutPeriodeFrancais;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }

            public static string getColonneNom()
            {
                if (LangueSetting.langue == LangueEnum.Francais)
                {
                    return coloneNomFrancais;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }

            public static string getColonneBudget()
            {
                if (LangueSetting.langue == LangueEnum.Francais)
                {
                    return coloneBudgetFrancais;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }

            public static string getColonneMontantDepenser()
            {
                if (LangueSetting.langue == LangueEnum.Francais)
                {
                    return coloneMontantDepenserFrancais;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }

            public static string getColonneMontantRestant()
            {
                if (LangueSetting.langue == LangueEnum.Francais)
                {
                    return coloneMontantRestantFrancais;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }

            //Francais
            private static string btnAjouterCategorieFrancais = "Ajouter une categorie";
            private static string btnModifierCategorieFrancais = "Modifier une categorie";
            private static string btnSupprimerCategorieFrancais = "Supprimer une categorie";
            private static string btnNouvellePeriodeFrancais = "Nouvelle periode";
            private static string lblNomDepenseFrancais = "Nom";
            private static string lblMontantDepenseFrancais = "Montant";
            private static string btnAnnulerFrancais = "Annuler";
            private static string btnAjouterFrancais = "Ajouter";
            private static string lblErreurVeuillezCreerCategorieFrancais = "Veuillez créer une categorie";
            private static string lblErreurVeuillezEntrerInformationFrancais = "Veuillez entrer toutes les informations";
            private static string popupDoitAvoirCategoriePourModifierFrancais = "Vous devez avoir des catégories pour modifier une categorie";
            private static string debutLblDateDebutPeriodeFrancais = "Début de la periode";
            private static string coloneNomFrancais = "Nom";
            private static string coloneBudgetFrancais = "Budget";
            private static string coloneMontantDepenserFrancais = "Montant dépenser";
            private static string coloneMontantRestantFrancais = "Montant restant";

        }

        public static class FormAjouterCategorie
        {
            public static string getLblNom()
            {
                if (LangueSetting.langue == LangueEnum.Francais)
                {
                    return lblNomFrancais;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }

            public static string getBudget()
            {
                if (LangueSetting.langue == LangueEnum.Francais)
                {
                    return lblBudgetFrancais;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }

            public static string getBtnAjouter()
            {
                if (LangueSetting.langue == LangueEnum.Francais)
                {
                    return btnAjouterFrancais;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }


            public static string getBtnAnnuler()
            {
                if (LangueSetting.langue == LangueEnum.Francais)
                {
                    return btnAnnulerFrancais;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            //Francais
            public static string lblNomFrancais = "Nom";
            public static string lblBudgetFrancais = "Budget";
            public static string btnAjouterFrancais = "Ajouter";
            public static string btnAnnulerFrancais = "Annuler";
        }

        public static class FormModifierCategorie
        {
            public static string getLblNom()
            {
                if (LangueSetting.langue == LangueEnum.Francais)
                {
                    return lblNomFrancais;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }

            public static string getLblBudget()
            {
                if (LangueSetting.langue == LangueEnum.Francais)
                {
                    return lblBudgetFrancais;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }

            public static string getBtnModifier()
            {
                if (LangueSetting.langue == LangueEnum.Francais)
                {
                    return btnModifierFrancais;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }

            public static string getBtnAnnuler()
            {
                if (LangueSetting.langue == LangueEnum.Francais)
                {
                    return btnAnnulerFrancais;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }

            //Francais
            public static string lblNomFrancais = "Nom";
            public static string lblBudgetFrancais = "Budget";
            public static string btnModifierFrancais = "Modifier";
            public static string btnAnnulerFrancais = "Annuler";
        }
    } 
}