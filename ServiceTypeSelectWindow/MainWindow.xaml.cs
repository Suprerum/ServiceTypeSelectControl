using System;
using System.Collections.Generic;
using System.Globalization;
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
using ServiceTypeService;
using ServiceTypeService.Dto;

namespace ServiceTypeSelectWindow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (ServiceTypeDto item in TreeView.Items)
            {
                if(item.Name == textBoxServiceName.Text || item.Code == textBoxServiceId.Text)
                {
                    MessageBox.Show($"Услуга {item.Name} найдена.");
                    break;
                }
                else
                {
                    FindNode(item, textBoxServiceName.Text, textBoxServiceId.Text);
                }
            }
        }

        private void FindNode(ServiceTypeDto parent, string name, string code)
        {
            foreach (ServiceTypeDto item in parent.ChildrenList)
            {
                if(item != null)
                {
                    if (item.Name == name || item.Code == textBoxServiceId.Text)
                    {
                        MessageBox.Show($"Услуга {item.Name} найдена.");
                        break;
                    }
                    else
                    {
                        FindNode(item, name, code);
                    }
                }
                else
                {
                    break;
                }
            }
        }
    }
}
