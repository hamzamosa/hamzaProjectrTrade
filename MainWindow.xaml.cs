using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Telerik.Windows.Controls;

namespace VertexFXClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            
            InitializeComponent();

            Windows11Palette.Palette.UseSystemAccentColor = true;




            SwitchLanguage("en");
        }

        private void Arab_Lang(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
            SwitchLanguage("ar");
            ribbon.FlowDirection = FlowDirection.RightToLeft;
            main_layout.FlowDirection = FlowDirection.RightToLeft;
        }

        private void English_lang(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
            SwitchLanguage("en");
            ribbon.FlowDirection = FlowDirection.LeftToRight;
            main_layout.FlowDirection = FlowDirection.LeftToRight;
        }

        private void Hindi_lang(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
            SwitchLanguage("hindi");
        }

        private void hebrew_lang(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
            SwitchLanguage("hebrew");

        }

        private void french_lang(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
            SwitchLanguage("french");
        }

        private void urdu_lang(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
            SwitchLanguage("urdu");

        }

        private void russian_lang(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
            SwitchLanguage("russian");

        }

        private void japanees_lang(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
            SwitchLanguage("japanees");
        }

        private void portugal_lang(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
            SwitchLanguage("portugal");

        }

        private void china_lang(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
            SwitchLanguage("china");
        }

        private void spanch_lang(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
            SwitchLanguage("span");

        }

        private void SwitchLanguage(string lang) 
        {

            ResourceDictionary resource = new ResourceDictionary();

            switch (lang) 
            {
                case "en": resource.Source = new Uri("..\\languages/ResourceDictionares.en.xaml", UriKind.Relative);
                    break;
                case "ar":
                    resource.Source = new Uri("..\\languages/Res_Ar.xaml", UriKind.Relative);
                    break;

                case "hindi":
                    resource.Source = new Uri("..\\languages/Resource_Hindi .xaml", UriKind.Relative);
                    break;

                case "span":
                    resource.Source = new Uri("..\\languages/Resource_Span.xaml", UriKind.Relative);
                    break;
                case "portugal":
                    resource.Source = new Uri("..\\languages/Resource_Portugal.xaml", UriKind.Relative);
                    break;
                case "japanees":
                    resource.Source = new Uri("..\\languages/Resource_Japanees .xaml", UriKind.Relative);
                    break;
                case "russian":
                    resource.Source = new Uri("..\\languages/Resource_Russian.xaml", UriKind.Relative);
                    break;
                case "urdu":
                    resource.Source = new Uri("..\\languages/Resource_Urdu.xaml", UriKind.Relative);
                    break;
                case "hebrew":
                    resource.Source = new Uri("..\\languages/Resource_Hebrew.xaml", UriKind.Relative);
                    break;
                case "french":
                    resource.Source = new Uri("..\\languages/Resource_French.xaml", UriKind.Relative);
                    break;

                case "china":
                    resource.Source = new Uri("..\\languages/Resource_China.xaml", UriKind.Relative);
                    break;




                default:
                
                    resource.Source = new Uri("..\\ResourceDictionares.en.xaml", UriKind.Relative);
                    break;

            }
            Application.Current.Resources.MergedDictionaries.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resource);


        }

        private void txt_note_MouseEnter(object sender, MouseEventArgs e)
        {
            SolidColorBrush redBrush = new SolidColorBrush(Colors.Red);

            // Set the Background property of txt_note to the red SolidColorBrush
            txt_note.Foreground = redBrush;
            txt_note.FontWeight = FontWeights.Bold;
           



        }

        private void txt_note_MouseLeave(object sender, MouseEventArgs e)
        {
            SolidColorBrush redBrush = new SolidColorBrush(Colors.Blue);

            // Set the Background property of txt_note to the red SolidColorBrush
            txt_note.Foreground = redBrush;
            txt_note.FontWeight = FontWeights.Normal;
        }
     
        private void Mouse_Enter_Hedge(object sender, MouseEventArgs e)
        {


            SolidColorBrush redBrush = new SolidColorBrush(Colors.Red);

            // Set the Background property of txt_note to the red SolidColorBrush
            txt_bkock_hedge.Foreground = redBrush;
            txt_bkock_hedge.FontWeight = FontWeights.Bold;

        }

        private void Mouse_Leave_Hedge(object sender, MouseEventArgs e)
        {
            SolidColorBrush redBrush = new SolidColorBrush(Colors.Blue);

            // Set the Background property of txt_note to the red SolidColorBrush
            txt_bkock_hedge.Foreground = redBrush;
            txt_bkock_hedge.FontWeight = FontWeights.Normal;
        }

        private void Mouse_Enter_Cancel(object sender, MouseEventArgs e)
        {
            SolidColorBrush redBrush = new SolidColorBrush(Colors.Red);

            // Set the Background property of txt_note to the red SolidColorBrush
            txt_block_Cancel.Foreground = redBrush;
            txt_block_Cancel.FontWeight = FontWeights.Bold;

        }

        private void Mouse_Leave_Cancel(object sender, MouseEventArgs e)
        {
            SolidColorBrush redBrush = new SolidColorBrush(Colors.Blue);

            // Set the Background property of txt_note to the red SolidColorBrush
            txt_block_Cancel.Foreground = redBrush;
            txt_block_Cancel.FontWeight = FontWeights.Normal;
        }

        private void radGridView_SelectionChanged(object sender, SelectionChangeEventArgs e)
        {

        }
    }
}
