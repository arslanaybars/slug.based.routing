namespace slug.based.routing.Domains
{
    // Generate slug base class depends on your slug strategy
    public class Translation
    {
        public int Id { get; set; }

        public string Slug { get; set; }

        public string Culture { get; set; }

        public string Description { get; set; }

        // depends on your great strategy, you can add props...
        public string MetaTitle { get; set; }

        public string MetaDescription { get; set; }

        public string MetaKeywords { get; set; }

        // Even you may retrieve related controller and action from slug base class
    }
}
