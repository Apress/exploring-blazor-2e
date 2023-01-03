using Microsoft.AspNetCore.Components;

namespace codebehindfiles.Pages
{
    public class Component1Logic : ComponentBase
    {
        public string texttodisplay;


        public async Task SetText()
        {
            texttodisplay = "test";
        }
    }
}
