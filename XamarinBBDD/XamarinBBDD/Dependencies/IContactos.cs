using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamarinBBDD.Models;

namespace XamarinBBDD.Dependencies
{
    public interface IContactos
    {
        Task<List<Contacto>> GetContactos();
    }
}
