using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juuhn_uwp
{
    public class StoryViewModel
    {
        private ObservableCollection<Story> stories = new ObservableCollection<Story>();

        public ObservableCollection<Story> Stories
        {
            get
            {
                return stories;
            }
        }

        public StoryViewModel()
        {

        }
    }
}
