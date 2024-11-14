using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;
using System;
using System.Linq;

namespace aplikacjatress
{
    public partial class NewPage : ContentPage
    {
        public NewPage()
        {
            InitializeComponent();
        }

        private void OnAgePickerSelectedIndexChanged(object sender, EventArgs e)
        {
            if (agePicker.SelectedItem != null)
            {
                int selectedAge = (int)agePicker.SelectedItem;
                var filteredContacts = ContactList.GetContactsOlderThan(selectedAge);
                contactsListView.ItemsSource = filteredContacts;
            }
        }
    }
}
