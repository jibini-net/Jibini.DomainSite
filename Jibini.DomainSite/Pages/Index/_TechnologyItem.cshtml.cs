namespace Jibini.DomainSite.Pages;

public class TechnologyItem
{
    public string Name { get; set; } = "";
    public string NameClass => ShowDescription ? "m-0 mb-2" : "m-0";
    public string IconClass { get; set; } = "";
    public string Description { get; set; } = "";
    public bool ShowDescription => !string.IsNullOrEmpty(Description);

    public static IEnumerable<TechnologyItem> All => new List<TechnologyItem>()
    {
        new()
        {
            Name = "ASP.NET Core (MVC/Blazor)",
            IconClass = "fa fa-globe",
            Description = "Interactive UI with server and client side code; product template and framework design"
        },
        new()
        {
            Name = "Microsoft SQL Server",
            IconClass = "fa fa-database",
            Description = "Integrated database features, including stored procedures and JSON queries"
        },
        new()
        {
            Name = "Spring Boot",
            IconClass = "fa fa-globe",
            Description = "Java and Kotlin backends with Hibernate as an O/RM, used in combination with React.js"
        },
        new()
        {
            Name = "Windows Server",
            IconClass = "fab fa-microsoft",
            Description = "Deployment to on-premises servers and IaaS (Azure, AWS, HostWinds, and more)"
        },
    };
};