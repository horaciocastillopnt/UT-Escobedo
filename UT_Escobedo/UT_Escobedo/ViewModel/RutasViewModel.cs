using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using UT_Escobedo.Model;

namespace UT_Escobedo.ViewModel
{
    public class RutasViewModel
    {

        public IList<Rutas> rutas { get; set; }
        public object SelectedRuta { get; set; }

        public RutasViewModel()
        {

            rutas = new List<Rutas>();

            GeneratedRutasDefault();

        }

        private void GeneratedRutasDefault()
        {

            rutas = new ObservableCollection<Rutas>
            {

                new Rutas
                {

                    Id = 1,
                    Icon = "bus.png",
                    RutaU = "Ruta 88"

                },
                new Rutas
                {

                    Id = 2,
                    Icon = "bus.png",
                    RutaU = "Ruta 527"

                },
                new Rutas
                {

                    Id = 3,
                    Icon = "bus.png",
                    RutaU = "Hidalgo"

                }

            };

        }
    }
}
