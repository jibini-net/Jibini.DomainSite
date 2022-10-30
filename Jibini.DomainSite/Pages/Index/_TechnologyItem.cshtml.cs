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
            Description = "Interactive UI with server- and client-side code; product template and framework design"
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
            IconClass = "fa fa-leaf",
            Description = "Java and Kotlin backends using an O/RM, used in combination with React.js"
        },
        new()
        {
            Name = "React.js and Node.js",
            IconClass = "fab fa-js",
            Description = "JS and TypeScript frontends for pure JS stacks, or other APIs in .NET Core/Java"
        },
        new()
        {
            Name = "Windows Server",
            IconClass = "fab fa-microsoft",
            Description = "Deployment to on-premises servers and IaaS (Azure, AWS, HostWinds, and more)"
        },
        new()
        {
            Name = "Linux and UNIX-likes",
            IconClass = "fab fa-freebsd",
            Description = "System and cluster administration with heavily virtualized workloads, ZFS filesystem"
        },
        new()
        {
            Name = "Git and SCM",
            IconClass = "fab fa-git",
            Description = "Promoting general code cleanliness and trackability with point-in-time restore"
        },
        new()
        {
            Name = "OpenGL Graphics",
            IconClass = "fa fa-gamepad",
            Description = "Desktop and embedded graphics for games and detailed rendering with shader pipelines"
        },
        new()
        {
            Name = "C and Low-level Code",
            IconClass = "fa fa-microchip",
            Description = "OS kernel and embedded development with a focus on memory safety and portability"
        },
    };
};