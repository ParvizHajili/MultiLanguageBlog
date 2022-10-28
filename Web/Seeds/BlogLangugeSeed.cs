using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Web.Models;

namespace Web.Seeds
{
    public class BlogLangugeSeed : IEntityTypeConfiguration<BlogLanguage>
    {
        public void Configure(EntityTypeBuilder<BlogLanguage> builder)
        {
            builder.HasData(
                new BlogLanguage()
                {
                    Id = 1,
                    BlogId = 1,
                    Title = "C# Programming Language",
                    Content = "The C# programming language was designed by Anders Hejlsberg from Microsoft in 2000 and was later approved as an international standard by Ecma (ECMA-334) in 2002 and ISO/IEC (ISO/IEC 23270) in 2003. Microsoft introduced C# along with .NET Framework and Visual Studio, both of which were closed-source. At the time, Microsoft had no open-source products. Four years later, in 2004, a free and open-source project called Mono began, providing a cross-platform compiler and runtime environment for the C# programming language. A decade later, Microsoft released Visual Studio Code (code editor), Roslyn (compiler), and the unified .NET platform (software framework), all of which support C# and are free, open-source, and cross-platform. Mono also joined Microsoft but was not merged into .NET",
                    Language = "En",
                    CreatedDate = DateTime.Now
                },
                new BlogLanguage()
                {
                    Id = 2,
                    BlogId = 1,
                    Title = "C# Proqramlaşdırma Dili",
                    Content = "C# proqramlaşdırma dili 2000-ci ildə Microsoft-dan Anders Hejlsberg tərəfindən hazırlanmış və daha sonra 2002-ci ildə Ecma (ECMA-334) və 2003-cü ildə ISO/IEC (ISO/IEC 23270) tərəfindən beynəlxalq standart kimi təsdiq edilmişdir. Microsoft .NET ilə birlikdə C# dilini təqdim etmişdir. Framework və Visual Studio, hər ikisi qapalı mənbə idi. O zaman Microsoft-un açıq mənbə məhsulları yox idi. Dörd il sonra, 2004-cü ildə Mono adlı pulsuz və açıq mənbəli layihə C# proqramlaşdırma dili üçün cross-platform kompilyatoru və iş vaxtı mühitini təmin etdi. On il sonra Microsoft Visual Studio Code (kod redaktoru), Roslyn (tərtibçi) və vahid .NET platformasını (proqram təminatı çərçivəsi) buraxdı, bunların hamısı C#-ı dəstəkləyir və pulsuz, açıq mənbəli və çarpaz platformadır. Mono da Microsoft-a qoşuldu, lakin .NET-ə birləşdirilmədi",
                    Language = "Az",
                    CreatedDate = DateTime.Now
                },
                new BlogLanguage()
                {
                    Id = 3,
                    BlogId = 1,
                    Title = "C# Язык программирования",
                    Content = "Язык программирования C# был разработан Андерсом Хейлсбергом из Microsoft в 2000 году и позже был утвержден в качестве международного стандарта Ecma (ECMA-334) в 2002 году и ISO/IEC (ISO/IEC 23270) в 2003 году. Microsoft представила C# вместе с .NET. Framework и Visual Studio, оба из которых были с закрытым исходным кодом. В то время у Microsoft не было продуктов с открытым исходным кодом. Четыре года спустя, в 2004 году, начался бесплатный проект с открытым исходным кодом под названием Mono, предоставляющий кроссплатформенный компилятор и среду выполнения для языка программирования C#. Десять лет спустя Microsoft выпустила Visual Studio Code (редактор кода), Roslyn (компилятор) и унифицированную платформу .NET (программный фреймворк). Все они поддерживают C# и являются бесплатными, открытыми и кроссплатформенными. Mono также присоединился к Microsoft, но не был объединен с .NET.",
                    Language = "Ru",
                    CreatedDate = DateTime.Now
                },
                new BlogLanguage()
                {
                    Id = 4,
                    BlogId = 2,
                    Title = "Java Programming Language",
                    Content = "Java is a programming language developed by James Gosling of Sun Microsystems and was released in 1995 as a core component of Sun Microsystems. Although this language derives many syntaxes from C and C++ , these derivations include a simpler object model and less low-level possibilities.",
                    Language = "En",
                    CreatedDate = DateTime.Now
                },
                new BlogLanguage()
                {
                    Id = 5,
                    BlogId = 2,
                    Title = "Java Proqramlaşdırma Dili",
                    Content = "Java Sun Microsystems-dən James Gosling tərəfindən hazırlanmış proqramlaşdırma dilidir və 1995-ci ildə Sun Microsystems-in əsas komponenti kimi buraxılmışdır. Bu dil C və C++ dillərindən bir çox sintaksis əldə etsə də , bu törəmələrə daha sadə obyekt modeli və daha az aşağı səviyyəli imkanlar daxildir. Java proqramları , kompüter arxitekturasından asılı olmayaraq istənilən Java Virtual Maşınında ( JVM ) işləyə bilən tipik bayt kodudur.",
                    Language = "Az",
                    CreatedDate = DateTime.Now
                },
                new BlogLanguage()
                {
                    Id = 6,
                    BlogId = 2,
                    Title = "Java Язык программирования",
                    Content = "Java — это язык программирования, разработанный Джеймсом Гослингом из Sun Microsystems и выпущенный в 1995 году в качестве основного компонента Sun Microsystems. Хотя этот язык является производным многих синтаксисов от C и C++ , эти производные включают более простую объектную модель и меньше низкоуровневых возможностей. Приложения Java представляют собой типичный байт -код (файл класса) , который может работать на любой виртуальной машине Java ( JVM ) независимо от.",
                    Language = "Ru",
                    CreatedDate = DateTime.Now
                });
        }
    }
}
