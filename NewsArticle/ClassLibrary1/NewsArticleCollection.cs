using ClassLibrary1;

public class NewsArticleCollection
{
 private List<NewsArticle> articles = new List<NewsArticle>();

 // Define the events
 public event Action<NewsArticle> articleAddedHandler;
 public event Action<NewsArticle> articleRemovedHandler;
 public event Action<string> articleFilteredHandler;

 // Register an event handler for the articleFilteredHandler event
 public void RegisterArticleFilteredHandler(Action<string> handler)
 {
  articleFilteredHandler += handler;
 }

 // Unregister an event handler for the articleFilteredHandler event
 public void UnregisterArticleFilteredHandler(Action<string> handler)
 {
  articleFilteredHandler -= handler;
 }

 // Add a new article to the collection
 public void AddArticle(NewsArticle article)
 {
  articles.Add(article);

  // Raise the article added event
  articleAddedHandler?.Invoke(article);

  // Raise the article filtered event
  articleFilteredHandler?.Invoke(article.Category);
 }

 // Remove an article from the collection
 public void RemoveArticle(NewsArticle article)
 {
  if (articles.Contains(article))
  {
   articles.Remove(article);

   // Raise the article removed event
   articleRemovedHandler?.Invoke(article);

   // Raise the article filtered event
   articleFilteredHandler?.Invoke(article.Category);
  }
 }

 // Filter the articles by category
 public List<NewsArticle> FilterArticlesByCategory(string category)
 {
  List<NewsArticle> filteredArticles = new List<NewsArticle>();

  foreach (NewsArticle article in articles)
  {
   if (article.Category == category)
   {
    filteredArticles.Add(article);
   }
  }

  // Raise the article filtered event
  articleFilteredHandler?.Invoke(category);

  // Return the filtered articles
  return filteredArticles;
 }
}
