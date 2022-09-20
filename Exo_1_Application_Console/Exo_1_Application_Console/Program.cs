//-Namespce du projet
namespace Exo_1_Application_Console;

//-Importation des classes système
using System;

//-Importation des classes du projet

//-Projet
class LesBases{

    static void Main(string[] args){

        Console.WriteLine("---[Start]---");  

        //-Création d'articles
        Article article1 = new Article("MacBook Pro 13 2022", 999.99, 10, ArticleType.Multimédia);
        Article article2 = new Article("MacBook Pro 14 2022", 1999.99, 10, ArticleType.Multimédia);
        Article article3 = new Article("MacBook Pro 16 2022", 2999.99, 10, ArticleType.Multimédia);
        
        //-Ajouts
        article1.ajouter(10);
        
        //-Retirer
        article1.retirer(5);
        
        //-Affichage
        article1.afficher();
        article2.afficher();
        article3.afficher();
        
        //-Un utilisateur créer un article
        Console.WriteLine("[Création d'un article par un utilisateur]");
        Console.WriteLine("- Nom de l'article: ");
        string nomArticle = Console.ReadLine();
        Console.WriteLine("- Prix de l'article: ");
        double prixArticle = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("- Quantité de l'article: ");
        int quantiteArticle = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("- Type de l'article [1-32]: ");
        ArticleType typeArticle = (ArticleType)Convert.ToInt32(Console.ReadLine());
        Article article4 = new Article(nomArticle, prixArticle, quantiteArticle, typeArticle);
        article4.afficher();
        

        Console.WriteLine("---[Stop]---");
    }

}