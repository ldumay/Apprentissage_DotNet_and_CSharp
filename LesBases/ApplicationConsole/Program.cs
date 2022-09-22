//-Namespce du projet
namespace ApplicationConsole;

//-Importation des classes système
using System;

//-Importation des classes du projet

//-Projet
class LesBases{

    static void Main(string[] args){

        Console.WriteLine("---[Start]---");  

        //-Création d'articles
        Article article1 = new Article("MacBook Pro 13 2022", 999.99, 10, ArticleType.Multimedia);
        Article article2 = new Article("MacBook Pro 14 2022", 1999.99, 10, ArticleType.Multimedia);
        Article article3 = new Article("MacBook Pro 16 2022", 2999.99, 10, ArticleType.Multimedia);
        
        //-Ajouts
        article1.ajouter(10);
        
        //-Retirer
        article1.retirer(5);

        //-Modifier
        article2.Quantite = 20;
        
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
        int i = 1;
        foreach (var nameArticleType in ArticleType.GetValues(typeof(ArticleType))){
            Console.WriteLine(i+" - "+nameArticleType);
            i++;
        }
        ArticleType typeArticle = (ArticleType)Convert.ToInt32(Console.ReadLine());
        Article article4 = new Article(nomArticle, prixArticle, quantiteArticle, typeArticle);
        article4.afficher();
        
        //-Création et manipulation d'un tableau d'articles
        ArticleTableau articleTableau = new ArticleTableau();
        articleTableau.afficheArticles();
        Article article5 = new Article("Mac Pro 2022", 6999.99, 10, ArticleType.Multimedia);
        articleTableau.ajouterArticle(article5);
        articleTableau.afficheArticles();
        
        Console.WriteLine("---[Stop]---");
    }

}