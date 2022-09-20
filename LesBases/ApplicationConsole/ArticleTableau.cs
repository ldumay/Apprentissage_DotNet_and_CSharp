//-Namespce du projet
namespace ApplicationConsole;

/**
 * Classe ArticleTableau
 */
public class ArticleTableau {

    //-Attribut de tableau d'articles.
    private Article[] articleTableau;

    /**
     * Constructeur.
     * Création d'un tableau de 6 cases
     */
    public ArticleTableau() {
        articleTableau = new Article[6];
    }
    
    /**
     * Ajoute un article au tableau
     * @param article
     * @return null
     */
    public void ajouterArticle(Article article) {
        // Ajout d'un article dans le tableau
        articleTableau[0] = article;
    }

    /**
     * Affiche le tableau d'articles.
     * @return the articleTableau
     */
    public void afficheArticles() {
        Console.WriteLine("---[ArticleTableau - Liste des articles]---");
        //-
        foreach (var article in articleTableau) {
            if (article != null){
                article.afficher();
            }
        }
        //-
        Console.WriteLine("---[ArticleTableau - Liste des articles ) ]---");
    }

}