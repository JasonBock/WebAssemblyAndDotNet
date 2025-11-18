using Avalonia;
using Avalonia.Browser;
using CollatzWithAvalonia;
using System.Runtime.Versioning;

[assembly: SupportedOSPlatform("browser")]

internal sealed partial class Program
{
	private static Task Main(string[] args) => 
		Program.BuildAvaloniaApp()
			.WithInterFont()
			.StartBrowserAppAsync("out");

	public static AppBuilder BuildAvaloniaApp() => 
		AppBuilder.Configure<App>();
}