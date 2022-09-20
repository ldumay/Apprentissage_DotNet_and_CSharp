//-Namespce du projet
namespace ApplicationConsole;

//-Importation des classes système
using System;

/**
 * Classe Article
 */
public class Article {

    //-Attribut de nom de l'article.
    public string nom;
    //-Attribut de prix de l'article.
    public double prix;
    //-Attribut de quantite de l'article.
    public int quantite;
    //-Attribut de type de l'article.
    public ArticleType type;

    //Getter et Setter de l'attribut de nom de l'article.
    public string Nom{ get { return nom; } set { nom = value;} }
    //Getter et Setter de l'attribut de prix de l'article
    public double Prix { get => prix; set => prix = value; }
    //Getter et Setter de l'attribut de quantite de l'article
    public int Quantite { get; set; }

    /**
     * Constructeur complet de la classe article.
     */
    public Article(string nom, double prix, int quantite, ArticleType type) {
        this.nom = nom;
        this.prix = prix;
        this.quantite = quantite;
        this.type = type;
    }

    /**
     * Acheter un article.
     */
    public void acheter(){}

    /**
    * Afficher dans la console les champs d'un article.
    */
    public void afficher(){
        Console.WriteLine(
            "[Article]"
            +"\n-nom: "+nom
            +"\n-prix: "+prix
            +"\n-quantite: "+quantite
            +"\n-type: "+type
            );
    }

    /**
    * Ajouter un nombre entier positif à la quantité disponible.
    */
    public void ajouter(int quantite){
        this.quantite += quantite;
        afficheNewQuantite();
    }

    /**
    * Retirer un nombre entier positif à la quantité disponible.
    */
    public void retirer(int quantite){
        this.quantite -= quantite;
        afficheNewQuantite();
    }
    
    /**
     * Retourne le prix total de l'article.
     */
    public void afficheNewQuantite(){
        Console.WriteLine(
            "[Article-Update]"
              +"\n-nom: "+nom
              +"\n-nouvelle quantité: "+quantite
              );
    }

}