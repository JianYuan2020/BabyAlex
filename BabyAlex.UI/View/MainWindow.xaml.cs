﻿using System;
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
using BabyAlex.UI.ViewModel;

namespace BabyAlex.UI.View
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    private MainViewModel _viewModel;

    public MainWindow(/*MainViewModel viewModel*/)
    {
      InitializeComponent();
      this.Loaded += MainWindow_Loaded;

      _viewModel = new MainViewModel("Good Morning, Baby Alex");
      DataContext = _viewModel;
    }

    private void MainWindow_Loaded(object sender, RoutedEventArgs e)
    {
      _viewModel.Load();
    }

  }
}
