using System;

namespace WebApplication1.Razor
{
public abstract class CustomRazorPage<TModel> : Microsoft.AspNetCore.Mvc.Razor.RazorPage<TModel>
{
    public string SayHi(string name)
    {
        return $"Hi <strong>{name}</strong>";
    }
}
}
