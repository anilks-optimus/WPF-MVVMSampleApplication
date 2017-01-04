using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimusCertifications.Model
{
    public class Employee : INotifyPropertyChanged
    {
        private string employeeName;
        private string employeeID;
        private string certificationID;

        public string EmployeeName
        {
            get
            {
                return employeeName;
            }

            set
            {
                if (employeeName != value)
                {
                    employeeName = value;
                    RaisePropertyChanged("EmployeeName");
                }
            }
        }
        public string EmployeeID
        {
            get
            {
                return employeeID;
            }

            set
            {
                if (employeeID != value)
                {
                    employeeID = value;
                    RaisePropertyChanged("EmployeeID");
                }
            }
        }
        public string CertificationID
        {
            get
            {
                return certificationID;
            }

            set
            {
                if (certificationID != value)
                {
                    certificationID = value;
                    RaisePropertyChanged("CertificationID");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
