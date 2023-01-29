using CommunityToolkit.Mvvm.ComponentModel;


namespace WpfApp1.MVVM.ViewModels
{
    public partial class AddContactViewModel: ObservableObject

    {
        [ObservableProperty]
        private string title = "Add Cantact";
    }
}
