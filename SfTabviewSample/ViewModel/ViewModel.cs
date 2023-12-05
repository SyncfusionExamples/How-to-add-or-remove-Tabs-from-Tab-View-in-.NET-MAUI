using System.Collections.ObjectModel;

namespace SfTabviewSample;


    public class ContactInfo {
        public string Name { get; set; }
        public long Number { get; set; }
    }
    public class ViewModel {
        public ObservableCollection<ContactInfo> contactlist;
        public ObservableCollection<ContactInfo> ContactList {
            get { return contactlist; }
            set { contactlist = value; }
        }

        public bool IsSelected {
            get { return isSelected; }
            set { isSelected = value; }
        }

        public bool isSelected { get; set; }

        public ViewModel() {
            ContactList = new ObservableCollection<ContactInfo>();
            ContactList.Add(new ContactInfo { Name = "Aaron", Number = 7363750 });
            ContactList.Add(new ContactInfo { Name = "Adam", Number = 7323250 });
            ContactList.Add(new ContactInfo { Name = "Adrian", Number = 7239121 });
            ContactList.Add(new ContactInfo { Name = "Alwin", Number = 2329823 });
            ContactList.Add(new ContactInfo { Name = "Alex", Number = 8013481 });
            ContactList.Add(new ContactInfo { Name = "Alexander", Number = 7872329 });
            ContactList.Add(new ContactInfo { Name = "Barry", Number = 7317750 });
            ContactList.Add(new ContactInfo { Name = "Adrian", Number = 7239121 });
            ContactList.Add(new ContactInfo { Name = "Alwin", Number = 2329823 });
            ContactList.Add(new ContactInfo { Name = "Alex", Number = 8013481 });
            ContactList.Add(new ContactInfo { Name = "Alwin", Number = 2329823 });
            ContactList.Add(new ContactInfo { Name = "Alex", Number = 8013481 });
            ContactList.Add(new ContactInfo { Name = "Alexander", Number = 7872329 });
            ContactList.Add(new ContactInfo { Name = "Barry", Number = 7317750 });
        }
    }
