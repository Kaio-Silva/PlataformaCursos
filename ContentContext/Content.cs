using PlataformaCursos.ShareContext;

namespace PlataformaCursos.ContentContext
{
    public abstract class Content : Base
    {
        protected Content(string title, string url)
        {
            this.Title = title;
            this.Url = url;
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}