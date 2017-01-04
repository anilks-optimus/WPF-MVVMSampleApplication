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

namespace OptimusCertifications
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class EmployeeDetail : Window
    {
        public EmployeeDetail()
        {
            InitializeComponent();
            this.Loaded += EmployeeDetailView_Loaded;
        }

        void EmployeeDetailView_Loaded(object sender, RoutedEventArgs e)
        {
            //txtEmployeeName.Text = "Anil";
            //txtEmployeeID.Text = "1";
            //txtCertificationID.Text = "70-483";
            //txtDateOfCompletion.Text = "19th Nov 2016";
            OptimusCertifications.ViewModel.EmployeeViewModel employeeViewModelObject = new OptimusCertifications.ViewModel.EmployeeViewModel();
            employeeViewModelObject.LoadEmployees();

            this.DataContext = employeeViewModelObject;
            
        }

        public void button_Click(object sender, RoutedEventArgs e)
        {
            OptimusCertifications.Views.EmployeeList empList = new OptimusCertifications.Views.EmployeeList();
            empList.Show();
            this.Hide(); 
        }
    }
}
