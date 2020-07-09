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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FinalProject_7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MediaDataGrid.ItemsSource = Library.media;
            MemberDataGrid.ItemsSource = Library.members;
        }

        private void Lend_Media_Click(object sender, RoutedEventArgs e)
        {
           // int counter = 0;
            if (MediaDataGrid.SelectedItem != null && MemberDataGrid.SelectedItem != null)
            {
                if (((Media)MediaDataGrid.SelectedItem).Status)
                {

                    ((Media)MediaDataGrid.SelectedItem).Status = false;
                     ((Media)MediaDataGrid.SelectedItem).Borrower = ((LibraryMember)MemberDataGrid.SelectedItem).Name;
                    if (((Media)MediaDataGrid.SelectedItem).Borrower == ((LibraryMember)MemberDataGrid.SelectedItem).Name)
                    {
                        ((LibraryMember)MemberDataGrid.SelectedItem).Counter++;
                    }
                    MessageBox.Show("This "+((Media)MediaDataGrid.SelectedItem).Title + " is lend by " + ((Media)MediaDataGrid.SelectedItem).Borrower,"Lend Media");
                }
                else
                {
                    MessageBox.Show("This book is Already Borrowed by " + ((Media)MediaDataGrid.SelectedItem).Borrower, "Warning", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

            else
            {
                MessageBox.Show("Please Select the Member amd Media first ", "Warning", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            RefreshMedia();
        }
    
     

        private void Return_media_click(object sender, RoutedEventArgs e)
        {
            string member = "";
            if (MediaDataGrid.SelectedItem != null)
            {
                if (((Media)MediaDataGrid.SelectedItem).Status )
                {
                   
                    MessageBox.Show("Please Select the " + ((Media)MediaDataGrid.SelectedItem).MediaType + " first before Returning ","Warning",MessageBoxButton.OK,MessageBoxImage.Error);
                }
                else
                {
                    foreach (LibraryMember m in Library.members)
                    {
                        if (((Media)MediaDataGrid.SelectedItem).Borrower == m.Name)
                        {
                            member = m.Name;
                            m.Counter--;
                        }
                    }
                   
                    ((Media)MediaDataGrid.SelectedItem).Status = true;
                    ((Media)MediaDataGrid.SelectedItem).Borrower = null;
                  
                    MessageBox.Show("This " + ((Media)MediaDataGrid.SelectedItem).Title +"is Returned by " + member, "Return Media");
                
                }
            }
            else
            {
                
               
                MessageBox.Show("Please Select the Book before Returning  ","Warning",MessageBoxButton.OK,MessageBoxImage.Error);
            }
            RefreshMedia();
        }






        void RefreshMedia()
        {
            MediaDataGrid.ItemsSource = null;
            MediaDataGrid.ItemsSource = Library.media;
            MemberDataGrid.ItemsSource = null;
            MemberDataGrid.ItemsSource = Library.members;
        }

       
    }
}
