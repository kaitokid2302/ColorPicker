namespace ColorPicker;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
        InitializeComponent();
	}
	void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
	{
		double _red = RedSlider.Value;
		double _green = GreenSlider.Value;
		double _blue = BlueSlider.Value;
		int red = (int)(_red * 255);
		int green = (int)(_green * 255);
		int blue = (int)(_blue * 255);

		string hex = $"{red:X2}{green:X2}{blue:X2}";
		ColorGenerate.Text = hex;
		ColorImage.BackgroundColor = Color.FromHex(hex);
		Main.BackgroundColor = Color.FromHex(hex);
		Console.WriteLine($"{red}");
	}
}


