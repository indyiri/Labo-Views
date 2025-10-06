
namespace LaboViews
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            cardGrid.BackgroundColor = Colors.Black;
        }

        int tappedCount = 0;
        private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            Border? borderTapped = sender as Border;

            if (borderTapped != null)
            {
                await borderTapped.RotateYTo(360, 1200);
                borderTapped.RotationY = 0;
            }

            tappedCount++;

            if (tappedCount % 2 == 0)
            {
                cardGrid.BackgroundColor = Colors.Black;
            }
            else
            {
                cardGrid.BackgroundColor = Colors.DarkGray;
            }
        }
    }

}
