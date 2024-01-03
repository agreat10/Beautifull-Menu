using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace App2
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            ContentFrame.Navigate(typeof(BlankPage1));
        }

        private void radioButton_Click(object sender, RoutedEventArgs e)
        {
            if (MySplit.IsPaneOpen) { MySplit.IsPaneOpen = false; }
            else {  MySplit.IsPaneOpen = true; }
        }

        private void radioButton2_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(BlankPage2));
        }

        private void radioButton3_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(BlankPage3));
        }

        private void radioButton4_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(BlankPage4));
        }

        private void radioButton5_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(BlankPage5));
        }

        private void radioButton6_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(BlankPage6));
        }

        private void radioButton1_Click(object sender, RoutedEventArgs e)
        {
            if(ContentFrame.CanGoBack) { ContentFrame.GoBack(); }
        }

       
    }
}
