namespace MAUI_Control_Assignment;

public partial class AkaneBanashiChapterOne : ContentPage
{
	public AkaneBanashiChapterOne()
	{
		InitializeComponent();
        CarouselView carouselView = new CarouselView();
        carouselView.SetBinding(ItemsView.ItemsSourceProperty, "ChapterOne");

        carouselView.ItemTemplate = new DataTemplate(() =>
        {
            Label nameLabel = new Label();
            nameLabel.SetBinding(Label.TextProperty, "Name");

            Image image = new Image();
            image.SetBinding(Image.SourceProperty, "ImageUrl");

            Label locationLabel = new Label();
            locationLabel.SetBinding(Label.TextProperty, "Location");

            Label detailsLabel = new Label();
            detailsLabel.SetBinding(Label.TextProperty, "Details");

            StackLayout stackLayout = new StackLayout();
            stackLayout.Add(nameLabel);
            stackLayout.Add(image);
            stackLayout.Add(locationLabel);
            stackLayout.Add(detailsLabel);

            Frame frame = new Frame();
            StackLayout rootStackLayout = new StackLayout();
            rootStackLayout.Add(frame);

            return rootStackLayout;
        });
    }

    public class ChapterOne
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Details { get; set; }
        public string ImageUrl { get; set; }
    }
}