# Gravatar TagHelper for ASP.NET Core

## Usage

Include Gravatar TagHelper in your `_ViewImports.cshtml`:

```
@using AschauerIT.TagHelpers
@addTagHelper *, AschauerIT.GravatarTagHelper
```

Add a Gravatar:

```
<gravatar default="Retro" size="35" alt="Avatar">email.address@example.com</gravatar>
```

Default values are:

* Image: MysteryPerson
* Size: 80 Pixels