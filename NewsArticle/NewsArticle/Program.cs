using ClassLibrary1;

class Program
{
 static void Main(string[] args)
 {
  // Create a new NewsArticleCollection instance
  NewsArticleCollection newsArticles = new NewsArticleCollection();

  // Register an event handler for the articleFilteredHandler event
  newsArticles.RegisterArticleFilteredHandler(category =>
  {
   Console.WriteLine($"Articles filtered by category '{category}'");
  });

  // Register an event handler for the articleAddedHandler event
  newsArticles.articleAddedHandler += article =>
  {
   Console.WriteLine($"Article added: {article.Title} ({article.Category})");
  };

  // Register an event handler for the articleRemovedHandler event
  newsArticles.articleRemovedHandler += article =>
  {
   Console.WriteLine($"Article removed: {article.Title} ({article.Category})");
  };

  // Add some news articles
  NewsArticle article1 = new NewsArticle("New iPhone release", "Technology");
  NewsArticle article2 = new NewsArticle("Record profits for Apple", "Business");
  NewsArticle article3 = new NewsArticle("New study shows benefits of exercise", "Health");
  newsArticles.AddArticle(article1);
  newsArticles.AddArticle(article2);
  newsArticles.AddArticle(article3);

  // Filter the articles by category
  List<NewsArticle> filteredArticles = newsArticles.FilterArticlesByCategory("Technology");

  // Remove an article
  newsArticles.RemoveArticle(article2);

  Console.ReadKey();
 }
}