using System;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//Add in Contact Model for use
using InvontoDevTest.Models;
using InvontoDevTest.ViewModels;

//Use this to convert javascript object to class object
using System.Web.Script.Serialization;


namespace InvontoDevTest.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;


        public HomeController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        


        public ActionResult Index()
        {
            //GET THE LIST OF CONTACTS FROM DATABASE
            var my_contacts = _context.Contacts.ToList();

            var viewModel = new ContactsViewModel()
            {
                Contacts = my_contacts
            };

            return View(viewModel);
        }






        public ActionResult Add()
        {
            return View();
        }







        public ActionResult Edit(int? id)
        {
            //If no id then redirect back to homepage
            //Else sent the appropriate contact to the view
            if (id == null)
            {
                return Redirect("Index");
            }
            else
            {
                
                var contact = _context.Contacts.Find(id);
                return View(contact);
            }

            
        }

        [HttpPost]
        public ActionResult saveContact(Contact contact)
        {
            var test = contact;
            //Add the new contact to the database and save changes
            _context.Contacts.Add(contact);
            var result = _context.SaveChanges();

            //If successful return success message
            if (result == 1)
            {
                return Content("Success");
            }
            else
            {
                return Content("Error");
            }
            
        }

        [HttpPost]
        public ActionResult editContact(Contact contact)
        {
            //Get new contact info
            var new_contact = contact;

            //Get old contact info based on id
            var old_contact = _context.Contacts.Find(new_contact.Id);

            //Update each field in old contact info with new contact info
            old_contact.FirstName = new_contact.FirstName;
            old_contact.LastName = new_contact.LastName;
            old_contact.Email = new_contact.Email;
            old_contact.Phone = new_contact.Phone;
            old_contact.Birthdate = new_contact.Birthdate;
            old_contact.Profile = new_contact.Profile;
            old_contact.Family = new_contact.Family;
            old_contact.Friend = new_contact.Friend;
            old_contact.Colleague = new_contact.Colleague;
            old_contact.Associate = new_contact.Associate;
            old_contact.Comments = new_contact.Comments;

            var result = _context.SaveChanges();

            if (result == 1)
            {
                return Content("Success");
            }
            else
            {
                return Content("Error");
            }
            
        }



        public ActionResult deleteContact(int? id)
        {
            //If no ide then redirect back to homepage
            //Else proceed with deleting the contact
            if (id == null)
            {
                return Redirect("Index");
            }
            else
            {
                //Get the contact to be removed based on id
                var contact = _context.Contacts.Find(id);

                //Remove contact
                _context.Contacts.Remove(contact);

                //Save changes
                var result = _context.SaveChanges();

                if (result == 1)
                {
                    return Content("Success");
                }
                else
                {
                    return Content("Error");
                }
            } //End big else statement

            
            
        }
    }
}