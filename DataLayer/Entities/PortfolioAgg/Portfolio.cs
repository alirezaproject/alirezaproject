namespace DataLayer.Entities.PortfolioAgg
{
    public class Portfolio
    {
        public int PortfolioId { get; private set; }
        public string Title { get; private set; }
        public string Tag { get; private set; }
        public string Url { get; private set; }
        public string Image { get; set; }
        public Portfolio(string title, string tag, string url,string image)
        {
            Title = title;
            Tag = tag;
            Url = url;
            Image = image;
        }

        public void Edit(string title, string tag, string url)
        {
            Title = title;
            Tag = tag;
            Url = url;
        }
    }
}