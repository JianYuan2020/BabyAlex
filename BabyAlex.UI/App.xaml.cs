using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using BabyAlex.UI.View;

namespace BabyAlex.UI
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application
  {
    protected override void OnStartup(StartupEventArgs e)
    {
      base.OnStartup(e);
      /*var bootStrapper = new BootStrapper();
      var container = bootStrapper.BootStrap();

      var mainWindow = container.Resolve<MainWindow>();*/

      MainWindow mainWindow = new MainWindow();
      mainWindow.Show();
    }
  }
}
