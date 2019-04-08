using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using UT_Escobedo.Model;

namespace UT_Escobedo.ViewModel
{
    public class UT_BusViewModel
    {

        public IList<UT_Bus> buses { get; set; }
        public object SelectItem { get; set; }

        public UT_BusViewModel()
        {

            buses = new List<UT_Bus>();

            GenerateDataDefault();

        }

        private void GenerateDataDefault()
        {

            buses = new ObservableCollection<UT_Bus>
            {

                new UT_Bus()
                {

                    Id = 1,
                    Image = "bus.png",
                    Ruta = "Escobedo"

                },
                new UT_Bus()
                {

                    Id = 2,
                    Image = "bus.png",
                    Ruta = "Hidalgo Directo"

                },
                new UT_Bus()
                {

                    Id = 3,
                    Image = "bus.png",
                    Ruta = "Zuazua"

                },
                new UT_Bus()
                {

                    Id = 4,
                    Image = "bus.png",
                    Ruta = "Solidaridad"

                },
                new UT_Bus()
                {

                    Id = 5,
                    Image = "bus.png",
                    Ruta = "Apodaca Concordia"

                }

            };

        }
    }
}
