using projet.Core;

namespace projet.MVM.ViewWodel
{
    public class MainViewModel: ObservableObject
    {
        
        public RelayCommand HomeViewComand { get; set; }
        public RelayCommand CityViewComand { get; set; }
        
        public HomeViewModel HomeVM { get; set; }
        public CityViewModel CityVM { get; set; }
        
        
        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value; 
                
                OnPropertyChanged();
            }
        }
       

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            CityVM = new CityViewModel();

            _currentView = HomeVM;

            HomeViewComand = new RelayCommand(o => { CurrentView = HomeVM; });
            CityViewComand = new RelayCommand(o => { CurrentView = CityVM; });
        }
    }
}