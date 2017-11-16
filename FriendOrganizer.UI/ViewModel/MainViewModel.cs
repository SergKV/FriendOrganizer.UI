using FriendOrganizer.Model;
using FriendOrganizer.UI.Data;
using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;

namespace FriendOrganizer.UI.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        IFriendDataService _friendDataService = new FriendDataService();

        public ObservableCollection<Friend> Friends { get; set; }
        private Friend _selectedFriend;

        public Friend SelectedFriend
        {
            get { return _selectedFriend; }
            set
            {
                _selectedFriend = value;                
                RaisePropertyChanged();
            }
        }

        public MainViewModel()
        {
            Friends = new ObservableCollection<Friend>();
            Load();
        }
        public void Load()
        {
            var friends = _friendDataService.GetAll();
            Friends.Clear();
            foreach (var friend in friends)
            {
                Friends.Add(friend);
            }
        }
    }
}