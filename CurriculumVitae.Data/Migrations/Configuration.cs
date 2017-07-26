namespace CurriculumVitae.Data.Migrations
{
    using CurriculumVitae.Domain.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CurriculumVitae.Data.Context.CurriculumVitaeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CurriculumVitae.Data.Context.CurriculumVitaeContext context)
        {
            //This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.E.g.

            Profile p = new Profile();
            p.Name = "Aisamaque Santos";
            p.Tagline = "Analista Desenvolvedor .NET";
            p.ProfileURL = "https://media.licdn.com/mpr/mpr/shrinknp_400_400/AAEAAQAAAAAAAAvoAAAAJDg5YmMxZjBkLTQxYWUtNDViYy04YTE2LWE1MjM4NTBlNzVhMQ.jpg";

            p.Address.Add(new Address { State = "S�o Paulo" });

            p.Contacts.Add(new Contact { Name = "contato@aisamaque.com.br", Type = "email", Icon = "fa fa-envelope", Value = "mailto: contato@aisamaque.com.br" });
            p.Contacts.Add(new Contact { Name = "linkedin.com/in/aisamaque", Type = "linkedin", Icon = "fa fa-linkedin", Value = "http://www.linkedin.com/in/aisamaque" });
            p.Contacts.Add(new Contact { Name = "aisamaque.santos", Type = "skype", Icon = "fa fa-skype", Value = "" });

            p.Educations.Add(new Education { Name = "Tecg. An�lise e Desenvolvimento de Sistemas", University = "Universidade Cruzeiro do Sul", StartYear = 2014, EndYear = 2015 });
            p.Educations.Add(new Education { Name = "Bacharelado An�lise e Desenvolvimento de Sistemas", University = "Escola Superior de Engenharia e Gest�o - ESEG", StartYear = 2010, EndYear = 2012 });

            p.Languages.Add(new Language { Name = "Portugu�s", Level = "Nativo" });
            p.Languages.Add(new Language { Name = "Ingl�s", Level = "Intermedi�rio" });

            p.Interest.Add(new Interest { Name = "Inova��es Tecnol�gicas" });
            p.Interest.Add(new Interest { Name = "Jogos & Series" });

            Career c = new Career();

            c.Summary = "Experi�ncia de seis anos com levantamento de requisitos, an�lise, desenvolvimento e suporte (t�cnico e de neg�cios) de solu��es relacionadas a processos  automatizados. Solu��es estas desenvolvidas com a ferramenta Ultimus BPM Suite e codifica��o na plataforma Microsoft .NET.";

            List<ExperienceDetail> d1 = new List<ExperienceDetail>();
            d1.Add(new ExperienceDetail { Value = "Levantamento de requisitos, mapeamento e automa��o de processos de neg�cios (BPMN) em diferentes empresas do setor p�blico e privado." });
            d1.Add(new ExperienceDetail { Value = "Mapeamento de banco de dados relacionais (Microsoft SQL Server e Oracle), desenvolvimento de rotinas, VIEWS, FUNCTIONS e PROCEDURES." });
            d1.Add(new ExperienceDetail { Value = "Desenvolvimento de formul�rios WEB utilizando HTML puro e plataforma ASP.NET(WebForms, MVC, Razor e Web Api)." });
            d1.Add(new ExperienceDetail { Value = "Desenvolvimento de aplica��es em camadas utilizando padr�es de projeto e boas pr�ticas (SOLID, DDD, TDD, BDD, MVC, Repository e etc) e conex�es a banco de dados via ORM (Entity Framework) e ADO.NET." });
            d1.Add(new ExperienceDetail { Value = "Desenvolvimento de integra��es via servi�os (SOA) utilizando ASP.NET WebServices (XML e JSON) e WCF." });

            c.Experiences.Add(new Experience { Name = "Analista Funcional", StartYear = 2012, EndYear = 0, Company = "Grupo Trust", Details = d1 });

            c.Projects.Add(new Project { Name = "IBGE", Value = "Levantamento de requisitos, automatiza��o, melhoria e suporte de dezenas de processos de neg�cios regionais e nacionais de diferentes �reas de neg�cios, todos estes processos foram desenvolvidos utilizando a ferramenta Ultimus BPM Suite. Desenvolvimento de Interfaces, integra��es e relat�rios na plataforma .NET." });

            c.Skills.Add(new Skill { Name = "C#", Level = 100 });
            c.Skills.Add(new Skill { Name = "jQuery", Level = 98 });
            c.Skills.Add(new Skill { Name = "ASP.NET WebForms", Level = 90 });
            c.Skills.Add(new Skill { Name = "ASP.NET WebServices", Level = 90 });
            c.Skills.Add(new Skill { Name = "Microsoft SQL Server", Level = 90 });
            c.Skills.Add(new Skill { Name = "Entity Framework", Level = 90 });
            c.Skills.Add(new Skill { Name = "ASP.NET MVC", Level = 80 });
            c.Skills.Add(new Skill { Name = ".NET WCF", Level = 80 });
            c.Skills.Add(new Skill { Name = ".NET CORE", Level = 70 });
            c.Skills.Add(new Skill { Name = "HTML5 & amp; CSS", Level = 90 });


            p.CareerProfile.Add(c);


            Repository.RespositoryBase<Profile> RepositoryP = new Repository.RespositoryBase<Profile>();
            RepositoryP.Add(p);

            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );

        }
    }
}
