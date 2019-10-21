using Avalonia;
using Avalonia.Markup.Xaml;

namespace stress
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
   }
}