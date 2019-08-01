using ConsultantManagement.Shared.Models;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ConsultantManagement.Shared.Providers
{
    //This can be replaced with local database or web api call to fetch data
    public class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataProvider();
                }
                return instance;
            }
        }

        public ObservableCollection<Consultant> Consultants { get; set; }

        private DataProvider()
        {
            Consultants = new ObservableCollection<Consultant>
            {
                new Consultant()
                {
                    FirstName = "Richard",
                    Type = "Front-End",
                    Clients = new ObservableRangeCollection<Client>()
                    {
                        new Client() { Name = "Microsoft" },
                        new Client() { Name = "ALink Company"},
                        new Client() { Name = "Startup 123"}
                    }
                },
                new Consultant()
                {
                    FirstName = "John",
                    Type = "Full-Stack Web",
                    Clients = new ObservableRangeCollection<Client>()
                    {
                        new Client() { Name = "Tesla" }
                    }
                },
                new Consultant()
                {
                    FirstName = "Brent",
                    Type = "Full-Stack Mobile",
                    Clients = new ObservableRangeCollection<Client>()
                    {
                        new Client() { Name = "XYZ Company" },
                        new Client() { Name = "G Finance"}
                    }
                }
            };
        }
    }
}
