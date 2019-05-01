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

namespace TemplateCreator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Field> gridData = new List<Field>();
        Template template = new Template();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void UpdateWebPreview(string html)
        {
            wbTemplatePreview.NavigateToString(html);
        }

        #region Events
        private void btnTemplateLoad_Click(object sender, RoutedEventArgs e)
        {
            var fd = new Microsoft.Win32.OpenFileDialog();
            fd.Filter = "HTML Files (*.html, *.htm)|*.html;*.htm|Text Files (*.txt)|*.txt|All Files|*.*";

            Nullable<bool> result = fd.ShowDialog();

            if (result == true)
            {
                template.TemplateFromFile(fd.FileName);
                tbTemplatePath.Text = fd.FileName;
                UpdateWebPreview(template.GetTemplateHTML());
            }
            
        }

        private void btnTemplateReload_Click(object sender, RoutedEventArgs e)
        {
            template.TemplateFromFile(tbTemplatePath.Text);
            UpdateWebPreview(template.GetTemplateHTML());
        }

        private void btnSetSaveLocation_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnVerifyTemplateNameExpression_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCreateTemplates_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion
    }
}
