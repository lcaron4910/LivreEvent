# LivreEvent
Le but du Tp est de créer un événement sur une classe.Cet événement sera alors disponible pour être utilisé dans un environnement graphique par exemple ou dans tout autre développement lié à l'application qui utilise notre objet métier.

Les outils mis en oeuvre:
* Git
* Visual Studio

Ici, nous voulons écrire nos propres événements et les proposer à d'autre développeurs qui pourront les utiliser. Nous nous plaçons en temps que producteur d'un service pour d'autre développeurs:

Le travail est le suivant:
Crée 3 Form (Main,Livre et Historique des Prix)

(http://image.noelshack.com/fichiers/2019/14/6/1554571360-capture20.png)

(http://image.noelshack.com/fichiers/2019/14/6/1554571367-capture21.png)

(http://image.noelshack.com/fichiers/2019/14/6/1554571372-capture22.png)
Dans un premier temps il fut nécessaire de créer la classe Mammifère dont les autres classes vont hériter.
Intéressons-nous au consctucteur de Mammifère:
public Mammifere(string nom, string lieuHabitation, string nomCrie, bool jeSuisDomestique)
{
  this.nom = nom;
  this.lieuHabitation = lieuHabitation;
  this.nomCrie = nomCrie;
  this.jeSuisDomestique = jeSuisDomestique;
}

En effet celui-ci va nous permettre de compléter le constructeur des classes Félin et Cétacé.
Afin de déclarer un héritage il est nécessaire de déclarer la ligne suivante:
class Cetace : Mammifere


Le constructeur est le suivant:
public Cetace(string nom, string lieuHabitation, string nomCrie, bool jeSuisDomestique, int dureeApnee, int profondeurPlonge)
  : base(nom, lieuHabitation, nomCrie, jeSuisDomestique)
{
  this.dureeApnee = dureeApnee;
  this.profondeurPlonge = profondeurPlonge;
}


De cette manière la classe Cétacé hérite des méthodes de la classe Mammifère.
On peut donc dire, selon le constructeur, qu'un Cétacé est un Mammifère.
