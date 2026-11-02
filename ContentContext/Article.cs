namespace PlataformaCursos.ContentContext
{
    public class Article : Content
    {
        public Article(string title, string url) : base(title, url)
        {
            Title = title;
            Url = url;
        }
    }
}