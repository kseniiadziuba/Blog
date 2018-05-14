using System.Data.Entity;
using Blog.Domain.Core;

namespace Blog.Infrastructure.Data
{
    public class BlogDbInitializer : //DropCreateDatabaseIfModelChanges<BlogDbContext>
    DropCreateDatabaseAlways<BlogDbContext>
    {
        /// <summary>
        /// Creates the database data.
        /// </summary>
        /// <param name="db">DbContext</param>
        protected override void Seed(BlogDbContext db)
        {
            db.Articles.Add(new Article("Азазель", "01/02/07", "Действие начинается 13 мая 1876 года в @Москве." +
                                                               " @Эрасту_Фандорину всего 20 лет," +
                                                               " но он удачлив, бесстрашен, благороден и привлекателен. Но самое главное — он прирождённый @сыщик. Он служит в полицейском управлении письмоводителем," +
                                                               " но по долгу службы сталкивается с запутанным делом. Он принимается за @расследование."));

            db.Articles.Add(new Article("Смерть Ахиллеса", "25/04/09", "@Эраст_Фандорин в @Москве " +
                                                                       "у @генерал-губернатора @Долгорукого. В отеле " +
                                                                       "происходит трагедия — умирает " +
                                                                       "@Михаил_Соболев. @Офицеры нашли в номере; очевидно, " +
                                                                       "@генерал умер от сердечного приступа. @Фандорин проводит тщательное @расследование."));

            base.Seed(db);
        }
    }
}