﻿using Microsoft.Win32;
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

namespace Bibliotheque.UI.Views
{
    /// <summary>
    /// Logique d'interaction pour AdminBookAddView.xaml
    /// </summary>
    public partial class AdminBookAddView : ContentControl
    {
        public AdminBookAddView()
        {
            InitializeComponent();
        }

        private void SelectFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new();
            fileDialog.Filter = "Image File (*.jpg)|*.jpg|(*.jpeg)|*.jpeg|All files (*.*)|*.*";
            if (fileDialog.ShowDialog() == true)
            {
                FilePath.Text = fileDialog.FileName;
            }
        }
    }
}
