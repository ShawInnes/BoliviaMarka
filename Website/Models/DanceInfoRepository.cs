using System.Collections.Generic;

namespace Website.Models
{
    public static class DanceInfoRepository
    {
        private static List<DanceInfo> dances;

        public static List<DanceInfo> Dances
        {
            get
            {
                if (dances == null)
                {
                    dances = new List<DanceInfo>
                    {
                        new DanceInfo
                        {
                            Name = "Caporales",
                            ShortDescription =
                                @"Caporales is a Bolivian dance that has its origins in the Afro-Andean dances of the Yungas region.  This dance represents the foremen who were in charge of the slaves in colonial times.",
                            LongDescriptionPath = "/assets/content/caporales.html",
                            WikiLink = "http://en.wikipedia.org/wiki/Caporales",
                            ImagePath = "/assets/img/dances/caporales_sq.jpg",
                            AudioDescription = "Jilguero Flores by Los Kjarkas",
                            AudioPath = "/assets/audio/Caporales-Kjarkas-JilgueroFlores.mp3",
                            YouTube = "1bL1UxTfgRg"
                        },
                        new DanceInfo
                        {
                            Name = "Morenada",
                            ShortDescription =
                                @"Morenada is a music and dance style from the Bolivian Andes possibly inspired by the sufferings of the African slaves brought to work in the silver mines of Potosi.",
                            LongDescriptionPath = "/assets/content/morenada.html",
                            WikiLink = "http://en.wikipedia.org/wiki/Morenada",
                            ImagePath = "/assets/img/dances/morenada_sq.jpg",
                            AudioDescription = "Idilio by Maria Juana",
                            AudioPath = "/assets/audio/Morenada-MariaJuana-Idilio.mp3",
                            YouTube = "exiQ6dY2zW0"
                        },
                        new DanceInfo
                        {
                            Name = "Diablada",
                            ShortDescription =
                                @"Diablada is a dance characterized by the mask and devil suit worn by the performers and is based on a mixture of Catholic and Andean religious ceremonies.",
                            LongDescriptionPath = "/assets/content/diablada.html",
                            WikiLink = "http://en.wikipedia.org/wiki/Diablada",
                            ImagePath = "/assets/img/dances/diablada_sq.jpg",
                            AudioDescription = "El Chiru Chiru by Llajtaymanta",
                            AudioPath = "/assets/audio/Diablada-Llajtaymanta-ElChiruChiru.mp3",
                            YouTube = "6is3LGLJ_68"
                        },
                        new DanceInfo
                        {
                            Name = "Tinku",
                            ShortDescription =
                                @"Tinku, a Bolivian Aymara tradition, began as a form of ritualistic combat.  In the Aymara language it means 'physical attack'.",
                            LongDescriptionPath = "/assets/content/tinku.html",
                            WikiLink = "http://en.wikipedia.org/wiki/Tinku",
                            ImagePath = "/assets/img/dances/tinku_sq.jpg",
                            AudioDescription = "Señora Chichera by Inti Illimani",
                            AudioPath = "/assets/audio/Tinku-IntiIllimani-SenoraChichera.mp3",
                            YouTube = "2kq0NjJy8XA"
                        },
                        new DanceInfo
                        {
                            Name = "Tobas",
                            ShortDescription =
                                @"The folkloric dance of the Tobas speaks of the ancient past of Bolivia.  Tobas is an athletic dance comprising agile steps accentuated with many jumps and bounds.",
                            LongDescriptionPath = "/assets/content/tobas.html",
                            WikiLink = "http://en.wikipedia.org/wiki/Tobas",
                            ImagePath = "/assets/img/dances/tobas_sq.jpg",
                            AudioDescription = "Es Asi by Kala Mara",
                            AudioPath = "/assets/audio/Tobas-KalaMarka-EsAsi.mp3",
                            YouTube = "a93AaISw8h0"
                        },
/*
                new DanceInfo
                {
                    Name = "Cueca",
                    ShortDescription =
                        @"Cueca is a courtship dance that reenacts the courting ritual of a rooster and hen.  It is said that Cueca has evolved from mostly Spanish influences.",
                    LongDescriptionPath ="/assets/content/cueca.html",
                    WikiLink = "http://en.wikipedia.org/wiki/Cueca",
                    ImagePath = "/assets/img/dances/cueca_sq.jpg",
                    AudioDescription = "El Regresso by Bonanza",
                    AudioPath = "/assets/audio/Cueca-Bonanza-ElRegresso.mp3",
                    YouTube = "Y82WS4lwh4I"
                },
*/
                    };
                }

                return dances;
            }
        }
    }
}