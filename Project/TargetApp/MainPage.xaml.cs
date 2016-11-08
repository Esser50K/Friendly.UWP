﻿using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace TargetApp
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            comboBox.ItemsSource = new object[] { "a", "b", "c" };
            listBox.ItemsSource = new object[] { "a", "b", "c" };
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            button1.Content = "★";
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            button2.Content = "★";
        }
    }

    public class MyClass
    {
        public static string Func(int val) => val.ToString();
    }
}
