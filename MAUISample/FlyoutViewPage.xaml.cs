namespace MAUISample;

public partial class FlyoutViewPage : FlyoutPage
{
	public FlyoutViewPage()
	{
		InitializeComponent();
        try
        {

            flyoutPage.collectionView.SelectionChanged += OnSelectionChanged;
            this.FlyoutLayoutBehavior = FlyoutLayoutBehavior.Split;
        }
        catch (Exception ex)
        {
            Console.WriteLine("FlyoutViewPage Constructor: " + ex.Message + " StackStace " + ex.StackTrace );
        }
    }

	void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var item = e.CurrentSelection.FirstOrDefault() as FlyoutPageItem;
        if (item != null)
        {            
            Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
            IsPresented = false;
        }
    }
}
