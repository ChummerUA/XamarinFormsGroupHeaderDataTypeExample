using System.Collections.Generic;
using System.Collections.ObjectModel;
using XamarinFormsGroupHeaderDataTypeExample.Utils;

namespace XamarinFormsGroupHeaderDataTypeExample.ViewModels
{
    public class MainPageViewModel
    {
        public ObservableCollection<GroupObservableCollection<string>> ItemsSource { get; }

        public MainPageViewModel()
        {
            var list = new List<string>
            {
                "Item 1",
                "Item 2",
                "Item 3"
            };

            ItemsSource = new ObservableCollection<GroupObservableCollection<string>>();
            for (int i = 0; i < 5; i++)
            {
                var group = new GroupObservableCollection<string>(list)
                {
                    Title = $"Group {i + 1}"
                };
                ItemsSource.Add(group);
            }
        }
    }
}
