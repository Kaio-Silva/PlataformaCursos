namespace PlataformaCursos.ContentContext
{
    public class Career : Content
    {
        public Career(): base("", "")
        {
            Items = new List<CareerItem>();
        }

        public Career(string title, string url) : base(title, url)
        {
            Items = new List<CareerItem>();
            Title = title;
            Url = url;
        }

        public IList<CareerItem> Items { get; set; }
        public int TotalCourses => Items.Count;

    }
}