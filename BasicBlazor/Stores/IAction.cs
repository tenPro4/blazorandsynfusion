using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;

namespace BasicBlazor.Stores
{
    public interface IAction
    {
        public string Name { get; }
    }
}
