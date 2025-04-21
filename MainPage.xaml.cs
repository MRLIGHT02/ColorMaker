
namespace ColorMaker;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

    private void sld_ValueChanged(object sender, ValueChangedEventArgs e)
        {
		var red = sldRed.Value;
		var green = slGreen.Value;
		var blue = sldBlue.Value;

		Color color = Color.FromRgb(red, green, blue);
		SetColor(color);
        }

    private void SetColor(Color color)
        {
		btnRandom.Background = color;
		Container.BackgroundColor = color;
		lblHex.Text = color.ToHex();
        }
    }

