//This class only manages what is supposed to happen with the contact
using Harmony.Models;
namespace Harmony.Managers
{
    internal class ContactManager
    {
        private Factory _Factory;
        private Factory oFactory
        {
            get
            {
                if (_Factory == null)

                    _Factory = new Factory();
                return _Factory;

            }
        }
        // ADD
        internal ViewModels.Contact AddContactManager(ViewModels.Contact vmContact)
        {
            //Parse into DataModel and send over to BizLogic
            vmContact = oFactory.bizLogicHelper.AddContact(vmContact);
            return vmContact;
        }

        // SEARCH
        internal ViewModels.Contact SearchContactManager(ViewModels.Contact vmContact)
        {
            //TODO: parse into DataModel and send into BizLogic
            return vmContact;
        }

        // EDIT
        internal ViewModels.Contact EditContactManager(ViewModels.Contact vmContact)
        {
            //TODO: parse into DataModel and send into BizLogic
            return vmContact;
        }

        // DELETE
        internal ViewModels.Contact DeleteContactManager(ViewModels.Contact vmContact)
        {
            //TODO: parse into DataModel and send into BizLogic
            return vmContact;
        }

    }
}