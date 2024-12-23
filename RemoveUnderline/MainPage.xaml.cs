namespace RemoveUnderline
{
    public partial class MainPage : ContentPage
    {
        private int[] nums = { 1, 2, 3 };
        public MainPage()
        {
            InitializeComponent();
            numberPicker.ItemsSource = nums;
        }
    }
}
