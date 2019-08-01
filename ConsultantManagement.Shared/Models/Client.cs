using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsultantManagement.Shared.Models
{
    public class Client : ObservableObject
    {
        private string name;
        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }
    }
}
