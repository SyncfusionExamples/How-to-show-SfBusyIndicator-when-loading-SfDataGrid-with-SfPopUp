using Syncfusion.Maui.Core.Carousel;
using Syncfusion.Maui.DataGrid;
using Syncfusion.Maui.Popup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridSample
{
    public class MainPageBehavior : Behavior<ContentPage>
    {
        SfDataGrid dataGrid;
        EmployeeViewModel viewModel;
        protected override void OnAttachedTo(ContentPage bindable)
        {
            base.OnAttachedTo(bindable);
            viewModel = (EmployeeViewModel)bindable.BindingContext;
        }

        protected override void OnDetachingFrom(ContentPage bindable)
        {
            base.OnDetachingFrom(bindable);
            dataGrid = null;
            viewModel = null;
        }
    }
}
