namespace UiDesktopAppTest.ViewModels.Pages
{
    public partial class DashboardViewModel : ObservableObject
    {

        //private string? text;
        //private string? Text
        //{
        //    get { return text; }
        //    set { this.text = value;
        //        // 이 변수가 변함을 알리는 함수가있어서 따로 구현해야하지만
        //        // [ObservableProperty] 이걸 선언하면 다 자동으로 생성됨
        //    }
        //}

        [ObservableProperty]
        private string? text = string.Empty;

        [ObservableProperty]
        private int _counter = 0;

        [RelayCommand]
        private void OnCounterIncrement()
        {
            // 데이터 바인딩 용도로 사용됨
            // [ObservableProperty]
            // private int _counter = 0; 
            // [ObservableProperty]
            // private string? text = string.Empty;
            // 이 선언된 변수로부터 생성된 속성을 통해 접근가능

            //Counter++; 

            this.Text = "Clicked!";

        }

        [RelayCommand]
        private void OnTextChanged()
        {

        }
    }
}
