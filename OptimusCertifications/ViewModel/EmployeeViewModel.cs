using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OptimusCertifications.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace OptimusCertifications.ViewModel
{
    class EmployeeViewModel : INotifyPropertyChanged
    {
        private Employee selectedUser;
        public Employee SelectedUser { get; set; }
        //public Employee SelectedUser
        //{
        //    get
        //    {
        //        return selectedUser;
        //    }
        //    set
        //    {
        //        selectedUser = value;
        //        RaisePropertyChanged("SelectedUser");
        //    }
        //}
       
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public ObservableCollection<Employee> Employees
        {
            get;
            set;
        }

        public void LoadEmployees()
        {
            ObservableCollection<Employee> employees = new ObservableCollection<Employee>();

            employees.Add(new Employee { EmployeeName = "Anil Saini", EmployeeID = "0347", CertificationID = "70-483" });
            employees.Add(new Employee { EmployeeName = "Udham Singh", EmployeeID = "0348", CertificationID = "70-483" });
            employees.Add(new Employee { EmployeeName = "Khushbu Garg", EmployeeID = "0349", CertificationID = "70-483" });
            employees.Add(new Employee { EmployeeName = "Somvir Solanki", EmployeeID = "0321", CertificationID = "70-483" });
            employees.Add(new Employee { EmployeeName = "Ankit kr Singh", EmployeeID = "0309", CertificationID = "70-483" });

            Employees = employees;
        }
    }
}
