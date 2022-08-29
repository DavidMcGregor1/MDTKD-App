namespace MdtkdApp;

public partial class EventsPage : ContentPage
{
	public EventsPage()
	{
		InitializeComponent();
		BindingContext = new EventsViewModel();

	}


	private void EventClicked(object sender, EventArgs e)
	{
        App.Current.MainPage = new NavigationPage(new EventDetailsPage());

    }




}