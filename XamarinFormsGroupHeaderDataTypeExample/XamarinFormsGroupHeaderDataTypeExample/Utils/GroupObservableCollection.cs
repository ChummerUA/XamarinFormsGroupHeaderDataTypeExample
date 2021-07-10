using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace XamarinFormsGroupHeaderDataTypeExample.Utils
{
    public class GroupObservableCollection<T> : ObservableCollection<T>, IGroupHeader
    {
        public string Title { get; set; }

        public GroupObservableCollection()
        {
        }

        public GroupObservableCollection(IEnumerable<T> collection) : base(collection)
        {
        }

        public GroupObservableCollection(List<T> list) : base(list)
        {
        }
    }
}
