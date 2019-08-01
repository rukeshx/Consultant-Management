using ConsultantManagement.Shared.Models;
using ConsultantManagement.Shared.Providers;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace ConsultantManagement.Shared.ViewModels
{
    public class MainPageViewModel : ObservableObject
    {
        public ObservableCollection<Consultant> Consultants { get => DataProvider.Instance.Consultants; }

        private Consultant newConsultant = new Consultant();
        public Consultant NewConsultant
        {
            get => newConsultant;
            set => SetProperty(ref newConsultant, value);
        }

        private Client newClient = new Client();
        public Client NewClient
        {
            get => newClient;
            set => SetProperty(ref newClient, value);
        }

        #region Commands
        private ICommand addConsultantCommand;
        public ICommand AddConsultantCommand
        {
            get
            {
                if (addConsultantCommand == null)
                {
                    addConsultantCommand = new RelayCommand(() =>
                    {
                        if (!String.IsNullOrWhiteSpace(NewConsultant.FirstName))
                        {
                            DataProvider.Instance.Consultants.Insert(0, NewConsultant);
                            NewConsultant = new Consultant();
                        }
                    });
                }
                return addConsultantCommand;
            }
        }

        private ICommand addClientCommand;
        public ICommand AddClientCommand
        {
            get
            {
                if (addClientCommand == null)
                {
                    addClientCommand = new RelayCommand(() =>
                    {
                        NewConsultant.Clients.Add(NewClient);
                        NewClient = new Client();
                    });
                }
                return addClientCommand;
            }
        }
        #endregion
    }
}
