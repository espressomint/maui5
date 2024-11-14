namespace aplikacjatress
{
    public partial class ShowContact : ContentPage
    {
        public ShowContact()
        {
            InitializeComponent();
            contactsListView.ItemsSource = ContactList.Contacts;
        }
    }
}