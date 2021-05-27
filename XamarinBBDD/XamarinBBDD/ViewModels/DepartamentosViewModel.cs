using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using XamarinBBDD.Base;
using XamarinBBDD.Models;
using XamarinBBDD.Repositories;

namespace XamarinBBDD.ViewModels
{
    public class DepartamentosViewModel : ViewModelBase
    {
        RepositoryDepartamentos repo;
        public DepartamentosViewModel()
        {
            this.repo = new RepositoryDepartamentos();
            List<Departamento> departamentos = this.repo.GetDepartamentos();
            this.Departamentos = new ObservableCollection<Departamento>(departamentos);
        }

        private ObservableCollection<Departamento> _Departamentos;

        public ObservableCollection<Departamento> Departamentos
        {
            get { return this._Departamentos; }
            set
            {
                this._Departamentos = value;
                OnPropertyChanged("Departamentos");
            }
        }

    }
}
