namespace Assignment01_Josiah_Clark
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnClicked(object? sender, EventArgs e)
        {
            double bill = double.Parse(BillEntry.Text);
            double tip = bill * 0.20;
            double total = bill + tip;
            Result.Text = $"tip:{tip:C}";
            Result2.Text = $"total:{total:C}";
        }
    }
}
