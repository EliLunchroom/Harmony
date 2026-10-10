namespace Harmony.Models{

public class Contact
    {
        public int ContactID {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Email {get; set;}
        public string Phone {get; set;}
        //Community contact belongs to
        public int ChurchID {get; set;}
        public DateTime CreatedOn {get; set;}
        public DateTime ModifiedOn {get; set;}
        public List<Models.Contact> MContactList {get; set;}

        //Constructor
        public Contact(){}
    }
}