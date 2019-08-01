using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ConsultantManagement.Shared.Models
{
    public class Consultant : ObservableObject
    {
        private string firstName;
        public string FirstName
        {
            get => firstName;
            set => SetProperty(ref firstName, value);
        }

        private string type;
        public string Type
        {
            get => type;
            set => SetProperty(ref type, value);
        }
        public ObservableRangeCollection<Client> Clients { get; set; } = new ObservableRangeCollection<Client>();
    }
}
