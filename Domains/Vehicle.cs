using System.Collections.Generic;

namespace slug.based.routing.Domains
{
    public abstract class Vehicle
    {
        public int Id { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        // View property normally should not be here :/
        public Translation ViewTranslations { get; set; }

        public List<Translation> Translations { get; set; }
    }
}
