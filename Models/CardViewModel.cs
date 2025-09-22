namespace MVC_Components.Models;

public class CardViewModel
{
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public string? Footer { get; set; }
    public string? ImageUrl { get; set; }
    public string? ActionUrl { get; set; }
    public string? ActionText { get; set; }
    public string CssClass { get; set; } = "card-default";
    public bool ShowBorder { get; set; } = true;
    public bool ShowShadow { get; set; } = true;
}