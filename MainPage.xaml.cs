
using CommunityToolkit.Maui.Alerts;

namespace ColorMaker;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

	bool isRandom;
    string hexValue;
    private void sld_ValueChanged(object sender, ValueChangedEventArgs e)
        {
		if (!isRandom)
			{
            var red = sldRed.Value;
            var green = slGreen.Value;
            var blue = sldBlue.Value;

            Color color = Color.FromRgb(red, green, blue);
            SetColor(color);
            }
        }

    private void SetColor(Color color)
        {
		btnRandom.Background = color;
		Container.BackgroundColor = color;
		lblHex.Text = color.ToHex();
        hexValue = lblHex.Text;
        }

    private void btnRandom_Clicked(object sender, EventArgs e)
        {
		isRandom = true;
		var random = new Random();
		var color = Color.FromRgb(
			random.Next(0, 255),
            random.Next(0, 255),
            random.Next(0, 255));
		SetColor(color);
		sldRed.Value = color.Red;
		slGreen.Value = color.Green;
		sldBlue.Value = color.Blue;
		isRandom = false;
        }

    private async void ImageButton_Clicked(object sender, EventArgs e)
        {
        await Clipboard.SetTextAsync(hexValue);
        var toast = Toast.Make("Color Copied", CommunityToolkit.Maui.Core.ToastDuration.Short,12);
        await toast.Show();
        }
    }

