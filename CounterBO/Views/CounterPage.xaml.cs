namespace CounterBO.Views;

public partial class CounterPage : ContentPage
{
	public CounterPage()
	{
		InitializeComponent();
        BindingContext = new Models.Counter();
    }

    private void Increment_Clicked(object sender, EventArgs e)
    {
        if (BindingContext is Models.Counter c)
            c.Increment();
    }

    private void Decrement_Clicked(object sender, EventArgs e)
    {
        if (BindingContext is Models.Counter c)
            c.Decrement();
    }
}