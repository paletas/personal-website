namespace Silvestre.App.Web.Models
{
    public record SiteContent(MetaContent Meta, NavContent Nav, FooterContent Footer, HomeContent Home, WritingPageContent Writing, ProjectsPageContent ProjectsPage, ErrorContent Error, A11yContent A11y);

    public record MetaContent(string Title, string Description, string AiTitle, string AiDescription, string ProjectsTitle, string ProjectsDescription);

    public record NavContent(string About, string Ai, string Projects, string Writing, string Wisc, string Contact, string Theme, string ThemeLabel, string OpenMenu, string LanguageSwitch);

    public record FooterContent(string Rights);

    public record HomeContent(HeroContent Hero, AboutContent About, AiTeaserContent AiTeaser, ProjectsContent Projects, WritingContent Writing, ContactContent Contact);

    public record HeroContent(string Status, string LeadBefore, string LeadAfter, string PrimaryButton, string SecondaryButton, string PhotoBadge);

    public record AboutContent(string Label, string Heading, string Body, string StackLabel, string AiToolingLabel);

    public record AiTeaserContent(string Label, string Heading, string Body, string PhaseLearn, string PhaseUnderstand, string PhasePlan, string PhaseImplement, string PhaseValidate, string Button);

    public record ProjectCard(string Meta, string Title, string Body);

    public record ProjectsContent(string Label, ProjectCard Wisc, ProjectCard F1, string SeeAll);

    public record WritingContent(string Label, ProjectCard CpuPart1, ProjectCard CpuPart2);

    public record ContactContent(string Heading, string Body);

    public record ErrorContent(string NotFoundTitle, string NotFoundBody, string Title, string Body, string Home);

    public record A11yContent(string SkipToContent, string MainNav, string Breadcrumb, string Home, string NewTab, string ExternalSite, string Scenario);

    public record WritingPageContent(string Crumb, string Title, string Lead, string Back, string Updated);

    public record ProjectsPageContent(string Crumb, string Title, string Lead, string Back, string StatusLabel, string StackLabel, string LastActiveLabel, string WorkflowCardLabel, string AiLink, string WorkflowLink, string StatusActive, string StatusMaintenance, string StatusDormant);
}
