using UiDesktopAppTest.Interfaces;

namespace UiDesktopAppTest.ViewModels.Pages
{
    public partial class DashboardViewModel : ObservableObject
    {

        private readonly IDateTime _iDateTime;

        [ObservableProperty]
        private int _counter = 0;

        // 생성자 주입
        public DashboardViewModel(IDateTime dateTime)
        {
            this._iDateTime = dateTime;
        }

        [ObservableProperty]
        private string? currentTime = string.Empty;

        //[ObservableProperty]
        //private string? text = string.Empty;



        [RelayCommand]
        private void OnCounterIncrement()
        {
            // 데이터 바인딩 용도로 사용됨
            // [ObservableProperty]
            // private int _counter = 0; 
            // [ObservableProperty]
            // private string? text = string.Empty;
            // 이 선언된 변수로부터 생성된 속성을 통해 접근가능

            Counter++;

            //this.Text = "Clicked!";

        }

        [RelayCommand]
        private void OnTextChanged()
        {
            this.CurrentTime = this._iDateTime.GetCurrentTime().ToString();
        }
    }
}
