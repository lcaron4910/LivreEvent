# LivreEvent
Le but du Tp est de créer un événement sur une classe.Cet événement sera alors disponible pour être utilisé dans un environnement graphique par exemple ou dans tout autre développement lié à l'application qui utilise notre objet métier.

Les outils mis en oeuvre:
* Git
* Visual Studio

Ici, nous voulons écrire nos propres événements et les proposer à d'autre développeurs qui pourront les utiliser. Nous nous plaçons en temps que producteur d'un service pour d'autre développeurs:

Le travail est le suivant:
Crée 3 Form (Main,Livre et Historique des Prix)

![Main.png](http://image.noelshack.com/fichiers/2019/14/6/1554571360-capture20.png)

Cette fenêtre permet: 
* D'instancier un livre.
* D'instancier la fenêtre Livre et l'Afficher.
* D'instancier la fenêtre Historique et l'Afficher.

![Livre.png](http://image.noelshack.com/fichiers/2019/14/6/1554571367-capture21.png)

Cette fenêtre permet: 
* Le constructeur permet de s'abonner aux variations de prix du livre.
* Toute action dans l'interface graphique se répercute sur l'objet livre.

![Historique.png](http://image.noelshack.com/fichiers/2019/14/6/1554571372-capture22.png)

Cette fenêtre permet:
* Le constructeur permet de s'abonner aux variations de prix du livre.
* Lorsque la fenêtre détecte par événement une variation du prix, elle ajoute le nouveau prix dans la ListBox.

## Cas d'utilisation

![Diagramme.png](http://image.noelshack.com/fichiers/2019/14/6/1554575331-capture50.png)

## Récapitulatif des actions menées dans les classes
![Resumer.png](http://image.noelshack.com/fichiers/2019/14/6/1554575340-capture51.png)

Exemple d'utilisation de delegue avec la classe Livre:
```cs
 public delegate void ChangementPrixPrototype(object o, ChangementPrixEventArgs e);
    public class Livre
    {
        private string titre;
        private decimal prixHt, tauxTva;
        public event ChangementPrixPrototype ChangementPrix;

        public Livre(string titre, decimal prixHt, decimal tauxTva)
        {
            this.titre = titre;
            this.prixHt = prixHt;
            this.tauxTva = tauxTva;
        }

        public decimal PrixHt
        {
            set
            {
                decimal ancienPrix = this.prixHt;
                prixHt = value;
                decimal hausse = ((prixHt - ancienPrix) / ancienPrix) * 100;
                onChangementPrix(ancienPrix, value, this.PrixTTC, hausse);
            }
            get
            {
                return prixHt;
            }
        }

        public void HausseAnnuelle()
        {
            decimal ancienPrix = this.prixHt;
            prixHt = prixHt * (decimal)1.1;
            onChangementPrix(ancienPrix, this.prixHt, this.PrixTTC, (decimal)10);
        }

        private void onChangementPrix(decimal ancienPrix, decimal nouveauPrix, decimal nouveauPrixTTC, decimal hausse)
        {
            if (ChangementPrix != null)
            {
                ChangementPrix(this, new ChangementPrixEventArgs(ancienPrix, nouveauPrix, nouveauPrixTTC, hausse));
            }
        }

        public decimal PrixTTC
        {
            get
            {
                return (1 + this.tauxTva / 100) * this.prixHt;
            }
        }

        public override string ToString()
        {
            return this.titre;
        }
    }
```
## On fait évoluer L'Application
On ajoute une nouvelle fenetre qui permet de calculer le pourcentage de hausse de la derniere augmentation.
![Hausse.png](http://image.noelshack.com/fichiers/2019/14/6/1554576347-capture60.png)

## Resultat final
![Tous.png](http://image.noelshack.com/fichiers/2019/14/6/1554576504-capturfin.png)
