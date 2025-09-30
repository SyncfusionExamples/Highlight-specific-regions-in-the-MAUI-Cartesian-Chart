using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartSample
{
    public class ViewModel
    {
        public ObservableCollection<Model> ClimateData { get; set; }

        public ViewModel()
        {
            ClimateData = new ObservableCollection<Model>()
            {
                new Model { Date = new DateTime(2024, 01, 15), Name = "Jan", Value = 22.7 },
                new Model { Date = new DateTime(2024, 02, 05), Name = "Feb", Value = 24.5 },
                new Model { Date = new DateTime(2024, 03, 05), Name = "Mar", Value = 26.8 },
                new Model { Date = new DateTime(2024, 04, 05), Name = "Apr", Value = 28.4 },
                new Model { Date = new DateTime(2024, 05, 05), Name = "May", Value = 29.6 },
                new Model { Date = new DateTime(2024, 06, 05), Name = "Jun", Value = 29.2 },
                new Model { Date = new DateTime(2024, 07, 05), Name = "Jul", Value = 27.6 },
                new Model { Date = new DateTime(2024, 08, 05), Name = "Aug", Value = 27.2 },
                new Model { Date = new DateTime(2024, 09, 05), Name = "Sep", Value = 27.3 },
                new Model { Date = new DateTime(2024, 10, 05), Name = "Oct", Value = 28.3 },
                new Model { Date = new DateTime(2024, 11, 05), Name = "Nov", Value = 27.2 },
                new Model { Date = new DateTime(2024, 12, 01), Name = "Dec", Value = 25.2 }
            };
        }
    }
}
