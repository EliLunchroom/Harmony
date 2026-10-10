using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Harmony.Managers;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Harmony.Controllers;

public class ContactController : Controller
{
    private Factory _oFactory;
		private Factory oFactory
		{
			get
			{
				if (_oFactory == null)

					_oFactory = new Factory();
				return _oFactory;

			}
		}
    //-------------------------------ADD------------------------------------\\
    public ActionResult Add()
    {
        
        return View();
    }

    [HttpPost]
    public ViewModels.Contact Add(ViewModels.Contact vmContact)
    {
        // Contact is sent to the ContactManager
        vmContact = oFactory.ContactManager.AddContactManager(vmContact);
        
        // Notify User of successful addition to the db
        if (vmContact.Success == true)
        {
            vmContact.Message = "Contact Added Successfully";
        }

        return vmContact;
    }

    //-------------------------------SEARCH---------------------------------\\
    public ActionResult Search()
    {
        ViewModels.Contact vmContact = new ViewModels.Contact();
        vmContact.Success = false;
        return View(vmContact);
    }

    [HttpPost]
    public ActionResult Search(ViewModels.Contact vmContact)
    {
        //data goes to ContactManager
        vmContact = oFactory.ContactManager.SearchContactManager(vmContact);
        vmContact.Success = true;
        
        return View(vmContact);
    }


    //-------------------------------EDIT-----------------------------------\\
    [HttpGet]
    public ActionResult Edit(int ContactID)
    {
        ViewModels.Contact vmContact = new ViewModels.Contact();
        vmContact.ContactID = ContactID;
        vmContact = oFactory.ContactManager.SearchContactManager(vmContact);
        if (vmContact.VMContactList.Count > 0)
        {
            return View(vmContact.VMContactList[0]);
        }

        return View();
    }

    [HttpPost]
    public ActionResult Edit(ViewModels.Contact vmContact)
    {
        // Get all data for Contact and populate textboxes
        vmContact = oFactory.ContactManager.EditContactManager(vmContact);
        if (vmContact.Success == true)
        {
            vmContact.Message = "Contact Updated Successfully";
        }

        return View(vmContact);
    }
    //-------------------------------DELETE---------------------------------\\
    [HttpGet]
    public ActionResult Delete(int ContactID)
    {
        ViewModels.Contact vmContact = new ViewModels.Contact();
        vmContact.ContactID = ContactID;
        vmContact = oFactory.ContactManager.SearchContactManager(vmContact);

        if (vmContact.VMContactList.Count > 0)
        {
            return View(vmContact.VMContactList[0]);
        }

        return View();
    }

    [HttpPost]
    public ActionResult Delete(ViewModels.Contact vmContact)
    {
        // Send Contact to be deleted
        vmContact = oFactory.ContactManager.DeleteContactManager(vmContact);
        if (vmContact.Success == true)
        {
            vmContact.Message = "Contact Deleted Successfully";
        } else
        {
            vmContact.Message = "Contact unable to be deleted. Please try again.";
        }

        return View(vmContact);
    }
}