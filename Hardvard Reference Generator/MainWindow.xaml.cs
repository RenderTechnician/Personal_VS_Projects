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

namespace Hardvard_Reference_Generator
{
    public partial class MainWindow : Window
    {

        
        public int switcher = 0;
        public string[] header2s = {"Book Title:", "Article Title:", "Article Title:"};
        public string[] header3s = { "Publisher:", "Last Visited:", "Journal Title:"};
        public string[] header4s = { "Pages:","Website Name:", "Volume:" };
        public string[] header5s = { "Edition:", "Web Address:", "Pages:" }; 
        public MainWindow()
        {
        InitializeComponent();
        Reference_string.Text = "" ;
        Header2.Text = "Article Title:";
        }
        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if(switcher == 0)
            {
                Reference_string.Text = Textbox1.Text + ". " + "(" + Textbox1_Copy4.Text + "). " + ". Book Title : " + Textbox1_Copy.Text + ". " + Textbox1_Copy1.Text +". " + Textbox1_Copy3.Text;
            }
            if (switcher == 1)
            {
                Reference_string.Text = Textbox1.Text + ". " + "(" + Textbox1_Copy4.Text + "). " + Textbox1_Copy.Text + ". Web Address: " + Textbox1_Copy3.Text + ". Last Accessed : " + Textbox1_Copy1.Text;
            }
            if (switcher == 2)
            {
                Reference_string.Text = Textbox1.Text + ". " + "(" + Textbox1_Copy4.Text + "). " + "Article Title : " + Textbox1_Copy.Text + "  .Journal Title: " + Textbox1_Copy1.Text + " Volume (" + Textbox1_Copy2.Text + ")" + "  , " + Textbox1_Copy3.Text;
            }
        }
        private void Clear_button_Click(object sender, RoutedEventArgs e)
        {
            Reference_string.Text = "";
            Textbox1.Text = "";
            Textbox1_Copy.Text = "";
            Textbox1_Copy1.Text = "";
            Textbox1_Copy2.Text = "";
            Textbox1_Copy3.Text = "";
            Textbox1_Copy4.Text = "";
            //   dropper();
        }
        private void dropper()
        {
            Reference_string.Text = "";
            Textbox1.Text = "";
            Textbox1_Copy.Text = "";
            Textbox1_Copy1.Text = "";
            Textbox1_Copy2.Text = "";
            Textbox1_Copy3.Text = "";
            Textbox1_Copy4.Text = "";
        }
        private void dropselector(object sender, EventArgs e)
        {
            if (Selector.Text == "Reference A Book")
            {
                switcher = 0;
                dropper();
            }
           if (Selector.Text == "Reference A Website")
            {
               switcher = 1;
                dropper();
            }
            if (Selector.Text == "Reference An Article")
            {
               switcher = 2;
                dropper();
            }
            Header2.Text = header2s[switcher];
            Header3.Text = header3s[switcher];
            Header4.Text = header4s[switcher];
            Header5.Text = header5s[switcher];

        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.paypal.me/RenderTechnician");
        }

        private void Selector_DropDownClosed(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(Reference_string.Text);
            MessageBox.Show("");
        }
    }
}
