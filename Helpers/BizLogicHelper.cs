namespace Harmony.Helpers;

public class BizLogicHelper
{
        private Factory _Factory;
        private Factory Factory
        {
            get
            {
                if (_Factory == null)

                    _Factory = new Factory();
                return _Factory;

            }
        }





    //ADD
    public ViewModels.Contact AddContact(ViewModels.Contact vmContact)
    {
        Models.Contact mContact = new Models.Contact();
        mContact = VMContactToMContact(vmContact);
        mContact = Factory.ContactService.AddContact(mContact);
        vmContact = MContactToVMContact(mContact);
        return vmContact;
    }

    // Turns ViewModel.Contact into Model.Contact
    public Models.Contact VMContactToMContact(ViewModels.Contact vmContact)
    {
        Models.Contact mContact = new Models.Contact();
        mContact.ContactID = vmContact.ContactID;
        mContact.FirstName = vmContact.FirstName;
        mContact.LastName = vmContact.LastName;
        mContact.Email = vmContact.Email;
        mContact.Phone = vmContact.Phone;
        mContact.ChurchID = vmContact.ChurchID;
        return mContact;
    } 

    //Model.Contact to ViewModel.Contact
    public ViewModels.Contact MContactToVMContact(Models.Contact mContact)
    {
        ViewModels.Contact vmContact = new ViewModels.Contact();
        return vmContact;
    }


}