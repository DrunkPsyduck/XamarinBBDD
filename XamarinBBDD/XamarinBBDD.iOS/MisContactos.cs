using Contacts;
using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UIKit;
using XamarinBBDD.Dependencies;
using XamarinBBDD.iOS;
using XamarinBBDD.Models;


[assembly: Xamarin.Forms.Dependency(typeof(MisContactos))]
namespace XamarinBBDD.iOS
{
    public class MisContactos : IContactos
    {
        public async Task<List<Contacto>> GetContactos()
        {
            var keysToFetch = new[] { CNContactKey.GivenName, CNContactKey.FamilyName, CNContactKey.PhoneNumbers };
            NSError error;
            var contactList = new List<CNContact>();

            using (var store = new CNContactStore())
            {
                var allContainers = store.GetContainers(null, out error);
                foreach (var container in allContainers)
                {
                    try
                    {
                        using (var predicate = CNContact.GetPredicateForContactsInContainer(container.Identifier))
                        {
                            var containerResults = store.GetUnifiedContacts(predicate, keysToFetch, out error);
                            contactList.AddRange(containerResults);
                        }
                    }
                    catch
                    {
                    }
                }
            }
            List<Contacto> lista = new List<Contacto>();

            foreach (var item in contactList)
            {
                var numbers = item.PhoneNumbers;
                if (numbers != null)
                {
                    foreach (var item2 in numbers)
                    {
                        lista.Add(new Contacto
                        {
                            Nombre = item.GivenName + " " + item.FamilyName,
                            Telefono = item2.Value.StringValue

                        });
                    }
                }
            }
            return lista;
        }
    }
}