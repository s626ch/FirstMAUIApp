//using Android.Icu.Text;

namespace FirstMAUIApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnBtnClick(object sender, EventArgs e)
	{
		Random rnd = new Random();
		string[] strings = { "Oh my gawwwwd.", "Ayo the pizza here.", "Is this an 'on god' moment?", "Oh no, my scrobbles!", "Oh lord, Jetson made another one!", "I got too silly for them." };
		int rndstr = rnd.Next(strings.Length);
		RandomString.Text = strings[rndstr];
	}
}

