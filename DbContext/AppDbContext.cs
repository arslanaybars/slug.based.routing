using slug.based.routing.Domains;
using System.Collections.Generic;

namespace slug.based.routing.DbContext
{
    public class AppDbContext
    {
        public AppDbContext()
        {
            Data = new List<Vehicle>
            {
                new Car
                {
                    Id = 1,
                    Model = "Mazda LaPuta",
                    Year = 1999,
                    Color = "Yellow",
                    Translations = new List<Translation>
                    {
                        new Translation
                        {
                            Id = 1,
                            Culture = "en",
                            Description = "The Mazda Laputa is a smart little car, just great for driving about town and small enough for easy parking. Introduced in 1999 and retired in 2006, it is only available now on the second hand car market. It's name is inspired by the book Gulliver's Travels by Jonathon Swift, and LaPuta (two words la puta) means prostitute in Spanish. So maybe not so good for driving around town after all.A bit dangerous for a lone female on her own when stopped at traffic lights, I should imagine.",
                            Slug = "mazda-laputa",
                        },
                        new Translation
                        {
                            Id = 2,
                            Culture = "tr",
                            Description = "Mazda Laputa | Teknik özellikler, Yakıt tüketimi, Boyutlar, Güç , Maksimum sürat, Tork, Hızlanma 0 - 100 km/saat, Motor hacmi, Çekiş, Lastik boyutu, Gövde tipi",
                            Slug = "mazda-laputa",
                        }
                    }
                },
                new Car
                {
                    Id = 2,
                    Model = "Skoda Laura",
                    Year = 2006,
                    Color = "White",
                    Translations = new List<Translation>
                    {
                        new Translation
                        {
                            Id = 3,
                            Culture = "en",
                            Description = "Skoda Laura is only named that in India. Elsewhere it is known as the Skoda Octavia Mk2, and was only brought out in 2006 and is still in production today. What a handsome car it is too! If anyone remembers the old jokes about Skodas, they must be smiling on the other sides of their faces now, however that is done. Anyway, it would seem that the word Laura may not be eminently suitable in India. In Hindi, which is one of India's many local languages, Laura mean 'penis'. Can you imagine the lady of the house ordering the butler in Hindi to take the car out for a ride?",
                            Slug = "skoda-laura",
                        },
                        new Translation
                        {
                            Id = 4,
                            Culture = "tr",
                            Description = "SKODA web sitesini optimize etmek ve geliştirmek için tanımlama bilgilerinizi (cookie) kullanıyor. Bu uygulama sayesinde, sizlere daha iyi hizmet vermeyi ...",
                            Slug = "turkce-skoda-laura-slug",
                        }
                    }
                },
                new Car
                {
                    Id = 3,
                    Model = "Nissan Moco",
                    Year = 2002,
                    Color = "Green",
                    Translations = new List<Translation>
                    {
                        new Translation
                        {
                            Id = 5,
                            Culture = "en",
                            Description = "Nissan Moco would only be mildly embarrassing in Spain if this car had been released there. Fortunately this wonderful looking little about town car was only ever released in Japan itself.No doubt Spanish visitors to Japan would have been tickled pink!Moco in Spanish mean booger or snot.A lot of the vehicles here have model names that translate badly in Spanish, but when you consider that Spanish is spoken by a massive 300 million people in the world, and is in fact the third most widely spoken language, then this is a pretty massive mistake.",
                            Slug = "nissan-moco",
                        },
                        new Translation
                        {
                            Id = 6,
                            Culture = "tr",
                            Description = "Nissan Skyline (Japonca: 日産・スカイライン, Nissan Sukairain), Prince Motor Company ... Nissan tarafından üretilen alt orta sınıf, spor ve orta sınıf otomobiller serisidir.",
                            Slug = "nissan-moco",
                        }
                    }
                },
                new Motorcycle
                {
                    Id = 4,
                    Model = "Harley-Davidson Iron 1200",
                    Year = 2019,
                    Translations = new List<Translation>
                    {
                        new Translation
                        {
                            Id = 7,
                            Culture = "en",
                            Description = "The evergreen Harley-Davidson Sportster has been in continuous production since 1957. The classic style and easy riding nature of these bikes makes them favorites for newbies and experienced riders alike. The best deal for 2019 has to be the Iron 1200 model.At just under 10K, this is the least - expensive way to get the larger of the two Sportster engines.The 1200cc twin provides a nearly 20 lb - ft boost in torque over the standard 883cc twin, and that’s a difference that can be felt.The new Iron 1200 looks tough thanks to its bobbed rear fender and completely blacked -out appearance. Of course we dig that ‘70s inspired tank graphic, café racer - style seat as well as those comfortable “mini - ape” handlebars, too.",
                            Slug = "harley-davidson-iron",
                        },
                        new Translation
                        {
                            Id = 8,
                            Culture = "tr",
                            Description = "Harley-Davidson Iron 1200",
                            Slug = "harley-davidson-iron",
                        }
                    }
                },
                new Motorcycle
                {
                    Id = 5,
                    Model = "Yamaha YZF-R3",
                    Year = 2018,
                    Translations = new List<Translation>
                    {
                        new Translation
                        {
                            Id = 9,
                            Culture = "en",
                            Description = "The evergreen Harley-Davidson Sportster has been in continuous production since 1957. The classic style and easy riding nature of these bikes makes them favorites for newbies and experienced riders alike. The best deal for 2019 has to be the Iron 1200 model.At just under 10K, this is the least - expensive way to get the larger of the two Sportster engines.The 1200cc twin provides a nearly 20 lb - ft boost in torque over the standard 883cc twin, and that’s a difference that can be felt.The new Iron 1200 looks tough thanks to its bobbed rear fender and completely blacked -out appearance. Of course we dig that ‘70s inspired tank graphic, café racer - style seat as well as those comfortable “mini - ape” handlebars, too.",
                            Slug = "yamaha-yzf-r3",
                        },
                        new Translation
                        {
                            Id = 10,
                            Culture = "tr",
                            Description = "Turkce yamaha yzf aciklamasi",
                            Slug = "tr-yamaha-yzf-r3",
                        }
                    }
                },
                new Ship
                {
                    Id = 6,
                    Model = "HMS PANDORA",
                    Year = 2019,
                    Translations = new List<Translation>
                    {
                        new Translation
                        {
                            Id = 11,
                            Culture = "en",
                            Description = "HMS PANDORA",
                            Slug = "hms-pandora",
                        },
                        new Translation
                        {
                            Id = 12,
                            Culture = "tr",
                            Description = "HMS PANDORA",
                            Slug = "hms-pandora",
                        }
                    }
                },
                new Ship
                {
                    Id = 7,
                    Model = "DERFFLINGER",
                    Year = 1700,
                    Translations = new List<Translation>
                    {
                        new Translation
                        {
                            Id = 13,
                            Culture = "en",
                            Description = "DERFFLINGER",
                            Slug = "dergglinger",

                        },
                        new Translation
                        {
                            Id = 14,
                            Culture = "tr",
                            Description = "TRTR TR TR DERFFLINGER",
                            Slug = "dergglinger",
                        }
                    }

                },
                new Tractor
                {
                    Id = 8,
                    Model = "Champion Elan",
                    Year = 2000,
                    Translations = new List<Translation>
                    {
                        new Translation
                        {
                            Id = 15,
                            Culture = "en",
                            Description = "Champion Elan Tractor. Made by Universal Hobbies. This model features steerable ",
                            Slug = "champion-elan",
                        },
                        new Translation
                        {
                            Id = 16,
                            Culture = "tr",
                            Description = "TR Champion Elan Tractor. Made by Universal Hobbies. This model features steerable ",
                            Slug = "champion-elan",
                        }
                    }
                },
                new Tractor
                {
                    Id = 9,
                    Model = "Someca SOM 40H",
                    Year = 1961,
                    Translations = new List<Translation>
                    {
                        new Translation
                        {
                            Id = 17,
                            Culture = "en",
                            Description = "Someca SOM 40H Tractor 1961. Made by Universal Hobbies. Features steerable",
                            Slug = "someca-som",
                        },
                        new Translation
                        {
                            Id = 18,
                            Culture = "tr",
                            Description = "TR Someca SOM 40H Tractor 1961. Made by Universal Hobbies. Features steerable",
                            Slug = "someca-som",
                        }
                    }
                },
                new Tractor
                {
                    Id = 10,
                    Model = "Hanomag R28",
                    Year = 1953,
                    Translations = new List<Translation>
                    {
                        new Translation
                        {
                            Id = 19,
                            Culture = "en",
                            Description = " Hanomag R28 Tractor 1953. Made by Minichamps. Features steerable front wheels ",
                            Slug = "hanomag",
                        },
                        new Translation
                        {
                            Id = 20,
                            Culture = "tr",
                            Description = "tr tr tr tr tr tr tr tr tr tr tr tr Hanomag R28 Tractor 1953. Made by Minichamps. Features steerable front wheels",
                            Slug = "hanomag",
                        }
                    }
                },

            };
        }

        public List<Vehicle> Data { get; set; }

        //public virtual List<Car> Cars { get; set; }

        //public virtual List<Motorcycle> Motorcycles { get; set; }

        //public virtual List<Ship> Ships { get; set; }

        //public virtual List<Tractor> Tractors { get; set; }
    }
}
