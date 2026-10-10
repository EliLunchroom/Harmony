using Harmony.Managers;

namespace Harmony
{
    internal class Factory
    {
        private Managers.ContactManager _contactManager;
        public Managers.ContactManager ContactManager
        {
            get
            {
                if(_contactManager == null)
                {
                    _contactManager = new Managers.ContactManager();
                }
                return _contactManager;
            }
        }


        private Services.ContactService _contactService;
        public Services.ContactService ContactService
        {
            get
            {
                if(_contactService == null)
                {
                    _contactService = new Services.ContactService();
                }
                return _contactService;
            }
        }


        private Helpers.BizLogicHelper _bizLogicHelper;
        public Helpers.BizLogicHelper bizLogicHelper
        {
            get
            {
                if(_bizLogicHelper == null)
                {
                    _bizLogicHelper = new Helpers.BizLogicHelper();
                }
                return _bizLogicHelper;
            }
        }



    }
} 