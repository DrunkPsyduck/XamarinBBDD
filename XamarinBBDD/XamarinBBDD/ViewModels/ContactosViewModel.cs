using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using XamarinBBDD.Base;
using XamarinBBDD.Dependencies;
using XamarinBBDD.Models;

namespace XamarinBBDD.ViewModels
{
    public class ContactosViewModel : ViewModelBase
    {
        public Command ShowContacts
        {
            get
            {
                return new Command(async() =>
                {
                    List<Contacto> contactos = await DependencyService.Get<IContactos>().GetContactos();
                    this.Contactos = new ObservableCollection<Contacto>(contactos);
                });
            }
        }

        private ObservableCollection<Contacto> _Contactos;
        public ObservableCollection<Contacto> Contactos
        {
            get{return this._Contactos;}
            set
            {
                this._Contactos = value;
                OnPropertyChanged("Contactos");
            }
        }
    }
}
