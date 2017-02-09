using Microsoft.Toolkit.Uwp.UI.Controls;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
  /// <summary>
  /// An empty page that can be used on its own or navigated to within a Frame.
  /// </summary>
  public sealed partial class MainPage : Page
  {
    public MainPage()
    {
      this.InitializeComponent();

      MasterDetailsView.ItemsSource = new List<string> { "Item 1", "Item 2", "Item 3" };
      MasterDetailsView.ViewStateChanged += (s, e) =>
      {
        var view = (MasterDetailsView)s;
        if (e == MasterDetailsViewState.Both && view.SelectedItem == null)
          view.SelectedItem = view.Items[0];
      };
    }
  }
}
