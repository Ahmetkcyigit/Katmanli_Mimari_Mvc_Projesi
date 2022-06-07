﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Conrete
{
   public class ContactManager:IContactService
    {
        IContactDal _Contactdal;
public ContactManager(IContactDal Contactdal)
        {
            _Contactdal = Contactdal;
        }

        public void ContactAdd(Contact contact)
        {
            _Contactdal.Insert(contact);
        }

        public void ContactDelete(Contact contact)
        {
            _Contactdal.Delete(contact);
        }

        public void ContactUpdate(Contact contact)
        {
            _Contactdal.Update(contact);
        }

        public Contact GetById(int id)
        {
            return _Contactdal.Get(x => x.ContactID == id);
        }

        public List<Contact> GetList()
        {
            return _Contactdal.List();
        }
    }
}
