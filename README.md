# How to show SfBusyIndicator when loading SfDataGrid inside SfPopUp?
In this article, we will show you how to show SfBusyIndicator when loading [.Net Maui DataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid) inside SfPopUp control.

## xaml
The below code illustrates how to show SfBusyIndicator when loading dataGrid inside SfpopUp control.
```
<ContentPage.BindingContext>
    <local:EmployeeViewModel x:Name="viewModel"/>
</ContentPage.BindingContext>

<StackLayout>
    <Button Text="Show PopUp"
            Clicked="ClickToShowPopup_Clicked" />
    <popup:SfPopup x:Name="popUp"
                   AutoSizeMode="Height"
                   HeaderTitle="SfDataGrid"
                   ShowFooter="True"
                   HeightRequest="500"
                   WidthRequest="400"
                   ShowCloseButton="True"
                   AcceptButtonText="ok"
                   Opened="popUp_Opened"
                   AppearanceMode="OneButton">
        <popup:SfPopup.PopupStyle>
            <popup:PopupStyle StrokeThickness="2"
                              CornerRadius="10" />
        </popup:SfPopup.PopupStyle>
        <popup:SfPopup.ContentTemplate>
            <DataTemplate>
                <Grid HeightRequest="550"
                      ChildAdded="Grid_ChildAdded">
                    <datagrid:SfDataGrid AutoGenerateColumnsMode="None"
                                         IsVisible="False"
                                         x:Name="dataGrid"
                                         Margin="0,10,0,10"
                                         HeightRequest="350"
                                         MaximumWidthRequest="380"
                                         SelectionMode="Single"
                                         NavigationMode="Cell"
                                         ColumnWidthMode="Auto"
                                         ItemsSource="{Binding Employees, Source={x:Reference viewModel}}">
                        <datagrid:SfDataGrid.Columns>
                            <datagrid:DataGridTextColumn HeaderText="Employee Name"
                                                         MappingName="Name" />
                            <datagrid:DataGridTextColumn  HeaderText="Contact ID"
                                                          MappingName="ContactID" />
                            <datagrid:DataGridTextColumn  HeaderText="Gender"
                                                          MappingName="Gender" />
                            <datagrid:DataGridTextColumn  HeaderText="Designation"
                                                          MappingName="Title" />
                        </datagrid:SfDataGrid.Columns>
                    </datagrid:SfDataGrid>

                    <inputLayout:SfBusyIndicator AnimationType="CircularMaterial"
                                                 x:Name="busyIndicator"
                                                 DurationFactor="2"
                                                 TitlePlacement="None"
                                                 WidthRequest="50"
                                                 HeightRequest="50"
                                                 IsRunning="True" />

                </Grid>
            </DataTemplate>
        </popup:SfPopup.ContentTemplate>
    </popup:SfPopup>
</StackLayout>
```

## C# 
```
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
```
 ![PopUpDemo.gif](https://support.syncfusion.com/kb/agent/attachment/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjMyOTE3Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.0qRK0QJ6HU9EsNrwek_yLokIIRuAicgymeEen7qKLt0)

[View sample in GitHub](https://github.com/SyncfusionExamples/How-to-show-SfBusyIndicator-when-loading-SfDataGrid-with-SfPopUp)

Take a moment to explore this [documentation](https://help.syncfusion.com/maui/datagrid/overview), where you can find more information about Syncfusion .NET MAUI DataGrid (SfDataGrid) with code examples. Please refer to this [link](https://www.syncfusion.com/maui-controls/maui-datagrid) to learn about the essential features of Syncfusion .NET MAUI DataGrid (SfDataGrid).
 
##### Conclusion
 
I hope you enjoyed learning about how to show SfBusyIndicator when loading .NET MAUI DataGrid (SfDataGrid) inside SfpopUp control.
 
You can refer to our [.NET MAUI DataGrid’s feature tour](https://www.syncfusion.com/maui-controls/maui-datagrid) page to learn about its other groundbreaking feature representations. You can also explore our [.NET MAUI DataGrid Documentation](https://help.syncfusion.com/maui/datagrid/getting-started) to understand how to present and manipulate data. 
For current customers, you can check out our .NET MAUI components on the [License and Downloads](https://www.syncfusion.com/sales/teamlicense) page. If you are new to Syncfusion, you can try our 30-day [free trial](https://www.syncfusion.com/downloads/maui) to explore our .NET MAUI DataGrid and other .NET MAUI components.
 
If you have any queries or require clarifications, please let us know in the comments below. You can also contact us through our [support forums](https://www.syncfusion.com/forums), [Direct-Trac](https://support.syncfusion.com/create) or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sfdatagrid), or the feedback portal. We are always happy to assist you!