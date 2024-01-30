namespace MAUI_Control_Assignment
{
    public partial class MainPage : ContentPage
    {
        //int count = 0;

        public MainPage()
        {
            InitializeComponent();
            
        }

        private void OnButton1Click(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AkaneBanashi());
        }
        private void OnButton2Click(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BokuNoHeroAcademia());
        }
        private void OnButton3Click(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ChainsawMan());
        }
        private void OnButton4Click(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Dandadan());
        }
        private void OnButton5Click(object sender, EventArgs e)
        {
            Navigation.PushAsync(new KaguraBachi());
        }
        private void OnButton6Click(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MarriageToxin());
        }
        private void OnButton7Click(object sender, EventArgs e)
        {
            Navigation.PushAsync(new OnePiece());
        }
        private void OnButton8Click(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UndeadUnluck());
        }


    }

}
