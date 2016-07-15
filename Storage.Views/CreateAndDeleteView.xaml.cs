﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
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
using Mita.Mvvm.Views;

namespace Storage.Views
{
    /// <summary>
    /// Interaction logic for CreateAndDeleteView.xaml
    /// </summary>
    /// 
    [Export("CreateAndDeleteView", typeof(IView))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class CreateAndDeleteView : IView
    {
        public CreateAndDeleteView()
        {
            InitializeComponent();
        }
    }
}
