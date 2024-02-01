namespace MAUI_Control_Assignment;


public partial class AkaneBanashi : ContentPage
{
	public AkaneBanashi()
	{
		InitializeComponent();
    }

    private void chapter1clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AkaneBanashiChapterOne());
    }

}