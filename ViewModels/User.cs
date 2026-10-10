using Microsoft.AspNetCore.SignalR;

namespace Harmony.Models {
    public class User
    {
        public int UserID {get; set;}
        public int ParishID {get; set;}
        public int RoleID {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Email {get; set;}
        public string Password {get; set;}
        public string ? Phone {get; set;}
        public string Address1 {get; set;}
        public string ? Address2 {get; set;}
        public string City {get; set;}
        public string State {get; set;}
        public string Country {get; set;}
        public string Zip {get; set;}
        public string ? Zip4 {get; set;}
        public DateTime CreatedAt {get; set;}
        public DateTime ModifiedOn {get; set;}

    }
}