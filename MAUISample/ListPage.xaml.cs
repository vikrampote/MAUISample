namespace MAUISample;

public partial class ListPage : ContentPage
{
	public ListPage()
	{
		InitializeComponent();
	}

    int count = 0;

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}
