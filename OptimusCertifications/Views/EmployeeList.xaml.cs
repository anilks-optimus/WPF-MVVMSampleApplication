using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace OptimusCertifications.Views
{
    /// <summary>
    /// Interaction logic for EmployeeList.xaml
    /// </summary>
    public partial class EmployeeList : Window
    {
        //private List<Model.Employee> employees;
        public EmployeeList()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            OptimusCertifications.ViewModel.EmployeeViewModel employeeViewModelObject = new OptimusCertifications.ViewModel.EmployeeViewModel();
            employeeViewModelObject.LoadEmployees();

            this.DataContext = employeeViewModelObject;           
            
            

        }

        private void EmployeeListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //OptimusCertifications.ViewModel.EmployeeViewModel employeeViewModelObject = new OptimusCertifications.ViewModel.EmployeeViewModel();
            //employeeViewModelObject.LoadEmployees();
            //grd.DataContext = employeeViewModelObject.SelectedUser;
            EmployeeDetail empDetail = new EmployeeDetail();
            empDetail.Show();
            this.Hide();
        }
    }
}
