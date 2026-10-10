namespace Harmony.Services
{
    public class ContactService
    {
        //Factory
        private Factory _Factory;

        private Factory Factory
        {
            get
            {
                if (_Factory == null)
                {
                    _Factory = new Factory();
                }
                return _Factory;
            }
        }


        //ADD CONTACT
        public Models.Contact AddContact(Models.Contact mContact)
        {
            //TODO
            //add validation
            //if mContact.Success == true, then create a DATA model, parse the model into a data model (calling on ContactHelper.ModelToDataModel(mContact)), and send it to Data/ContactData.cs to add Data Model to db
            //return mContact
            return mContact;
        }
    }
    
}