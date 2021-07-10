using System.Collections.ObjectModel;

namespace XamarinFormsGroupHeaderDataTypeExample
{
    public class GroupObservableCollection<T> : ObservableCollection<T>, IGroupHeader
    {
        public string Title { get; set; }
    }
}
