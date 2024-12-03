namespace TaskMasterClient
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
        protected override Window CreateWindow(IActivationState activationState)
        {
            var window = base.CreateWindow(activationState);
            const int newWidth = 350;
            const int newHeight = 700;
            window.Width = newWidth;
            window.Height = newHeight;
            window.MaximumHeight = newHeight;
            window.MaximumWidth = newWidth;
            return window;
        }
    }
}
