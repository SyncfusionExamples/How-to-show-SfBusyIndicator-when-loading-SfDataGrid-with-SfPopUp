using Syncfusion.Maui.Core;
using Syncfusion.Maui.DataGrid;
using Syncfusion.Maui.DataGrid.Helper;
using Syncfusion.Maui.Popup;
using System.Globalization;

namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {
        SfDataGrid dataGrid;
        SfBusyIndicator busyIndicator;
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ClickToShowPopup_Clicked(object sender, EventArgs e)
        {
            popUp.Show();
        }

        private void Grid_ChildAdded(object sender, ElementEventArgs e)
        {
            if (e.Element is SfDataGrid)
            {
                this.dataGrid = e.Element as SfDataGrid;
            }
            else if (e.Element is SfBusyIndicator)
            {
                this.busyIndicator = e.Element as SfBusyIndicator;
            }
        }

        private async void popUp_Opened(object sender, EventArgs e)
        {
            if (dataGrid != null)
            {
                await Task.Delay(2000);
                busyIndicator.IsRunning = false;
                dataGrid.IsVisible = true;
            }
        }
    }
}
 