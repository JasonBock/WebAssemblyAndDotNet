using Avalonia.Controls;
using Avalonia.Interactivity;
using Collatz;
using System.Numerics;

namespace CollatzWithAvalonia.Views;

public partial class MainView 
	: UserControl
{
	public MainView() => this.InitializeComponent();

	private void OnButtonClick(object sender, RoutedEventArgs e)
	{
		this.Results.Text = string.Empty;

		if (BigInteger.TryParse(this.StartingValue.Text, out var startingValue))
		{
			var sequence = CollatzSequenceGenerator.Generate<BigInteger>(startingValue);
			this.Results.Text = string.Join(", ", sequence);
		}
		else
		{
			this.Results.Text = $"The value, {this.StartingValue.Text}, is not a valid value.";
		}
	}
}