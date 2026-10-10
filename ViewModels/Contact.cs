namespace Harmony.ViewModels{

public class Contact
    {
        public int ContactID {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Email {get; set;}
        public string Phone {get; set;}

        //Community contact belongs to
        public int ChurchID {get; set;}
        public Boolean Success {get; set;}
        public string Message {get; set;}
        public List<ViewModels.Contact> VMContactList {get; set;}


        //Constructor
        public Contact(){}
    }
}