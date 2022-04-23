using Microsoft.AspNetCore.Razor.TagHelpers;

namespace AschauerIT.TagHelpers;

public class GravatarTagHelper : TagHelper
{
    #region Public Properties

    public GravatarDefault Default { get; set; } = GravatarDefault.MysteryPerson;
    public int Size { get; set; } = 80;

    #endregion Public Properties

    #region Public Methods

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "img";
        var content = await output.GetChildContentAsync();
        var target = content.GetContent().GetMD5Hash();

        string defaultImage = string.Empty;
        switch (Default)
        {
            case GravatarDefault.MysteryPerson: defaultImage = "mp"; break;
            case GravatarDefault.Retro: defaultImage = "retro"; break;
            case GravatarDefault.Identicon: defaultImage = "identicon"; break;
            case GravatarDefault.MonsterId: defaultImage = "monsterid"; break;
            case GravatarDefault.NotFound: defaultImage = "404"; break;
            case GravatarDefault.Wavatar: defaultImage = "wavatar"; break;
            case GravatarDefault.RoboHash: defaultImage = "robohash"; break;
            case GravatarDefault.Blank: defaultImage = "blank"; break;
            case GravatarDefault.Default: defaultImage = ""; break;
        }

        output.Attributes.SetAttribute("src", $"https://www.gravatar.com/avatar/{target}?d={defaultImage}&s={Size}");
        output.Content.SetContent(string.Empty);
    }

    #endregion Public Methods
}