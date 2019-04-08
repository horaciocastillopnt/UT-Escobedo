using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using UT_Escobedo.Model;

namespace UT_Escobedo.Factory
{
    public static class ContactosFactory
    {

        public static IList<Contacto> Contactos { get; set; }

        static ContactosFactory()
        {
            Contactos = new ObservableCollection<Contacto>() {
                new Contacto
                {
                    Nombre = "Área de Becas",
                    Telefono = "5000-4251",
                    Correo = "bescobedo@ute.edu.mx",
                },
                new Contacto
                {
                    Nombre = "Enfermeria",
                    Telefono = "5000-4242",
                    Correo = "enfermeria@ute.edu.mx",
                },
                new Contacto
                {
                    Nombre = "Trabajo Social y Promocionales",
                    Telefono = "5000 4251",
                    Correo = "atamez@ute.edu.mx",
                },
                 new Contacto
                {
                    Nombre = "Área Psicopedagogía",
                    Telefono = "5000-4251",
                    Correo = "gbautista@ute.edu.mx",
                },
                 new Contacto
                {
                    Nombre = "Área Deportes y Cultura",
                    Telefono = "5000-4250",
                },
                  new Contacto
                {
                    Nombre = "Departamento de Bolsa de Trabajo y Seguimiento de Egresados",
                    Telefono = "5000-4206",
                    Correo = "bolsaute@ute.edu.mx",
                },
                new Contacto
                {
                    Nombre = "Secretaria Academica y De Desarrollo",
                    Telefono = "5000-4209",
                    Correo = "sespinosa@ute.edu.mx",
                },
                new Contacto
                {
                    Nombre = "Secretaria De Administracion",
                    Telefono = "5000-4234",
                    Correo = "tleyva@ute.edu.mx",
                },
                new Contacto
                {
                    Nombre = "Contralora Interna",
                    Telefono = "5000-4241",
                    Correo = "ugonzalez@ute.edu.mx",
                },
                new Contacto
                {
                    Nombre = "Director De Vinculacion",
                    Telefono = "5000-4210",
                    Correo = "jrico@ute.edu.mx",
                },
                new Contacto
                {
                    Nombre = "Director De Carrera Desarrollo De Negocios Area Mercadotecnia",
                    Telefono = "5000-4223",
                    Correo = "morozco@ute.edu.mx ",
                },
                new Contacto
                {
                    Nombre = "Director De Carrera En Mantenimiento Area Industrial",
                    Telefono = "5000-4212",
                    Correo = "rhuerta@ute.edu.mx",
                },
                new Contacto
                {
                    Nombre = "Director De Carrera En Mecatronica Area Automatizacion",
                    Telefono = "5000-4245",
                    Correo = "jdeleon@ute.edu.mx",
                },
                new Contacto
                {
                    Nombre = "Encargado De La Direccion En La Carrera Tecnologias De la Informacion Y Comunicacion",
                    Telefono = "5000-4266",
                    Correo = "vdominguez@ute.edu.mx",
                },
                new Contacto
                {
                    Nombre = "Encargado De La Direccion En La Carrera Quimica Area Tecnologia Ambiental",
                    Telefono = "5000-4237",
                    Correo = "anochebuena@ute.edu.mx",
                },
                new Contacto
                {
                    Nombre = "Subdirector De Servicios Escolares",
                    Telefono = "5000-4226",
                    Correo = "mgallaga@ute.edu.mx",
                },
                 new Contacto
                {
                    Nombre = "Subdirector De Servicios Estudiantiles",
                    Telefono = "5000-4236",
                    Correo = "fdelarosa@ute.edu.mx",
                },
                 new Contacto
                {
                    Nombre = "Subdirector De Administrativos",
                    Telefono = "5000-4223",
                    Correo = "hgarcia@ute.edu.mx",
                },
                new Contacto
                {
                    Nombre = "Jefe De Control De Documentos",
                    Telefono = "5000-4211",
                    Correo = "mrodriguez@ute.edu.mx",
                },
                new Contacto
                {
                    Nombre = "Jefe De Infrestuctura",
                    Telefono = "5000-4214",
                    Correo = "dcaballero@ute.edu.mx",

                },
                new Contacto{
                    Nombre ="Jefe De Planeacion Y Evaluacion",
                    Telefono = "5000-4280",
                     Correo = "lusanchez@ute.edu.mx",
                },
                new Contacto
                {
                    Nombre ="Jefe De Investigacion y Desarrollo",
                    Telefono = "5000-4206",
                     Correo = "vflores@ute.edu.mx",
                },
                new Contacto
                {
                    Nombre = "Jefa Del Departamento De Educacion Continua",
                    Telefono = "5000-4203",
                     Correo = "nzuniga@ute.edu.mx",
                },
                new Contacto
                {
                    Nombre = "Jefa De Inlcusion Y Equidad De Genero",
                    Telefono = "5000-4290",
                     Correo = "lvallejo@ute.edu.mx",
                },
                new Contacto
                {
                    Nombre = "Jefa Del Programa Tutorial",
                    Telefono = "5000-4271",
                     Correo = "rcaballero@ute.edu.mx",
                },
                new Contacto
                {
                    Nombre = "Jefe De Control e Informatica Escolar",
                    Telefono = "5000-4278",
                   Correo = "alopez@ute.edu.mx",
                },
                new Contacto
                {
                    Nombre = "Jefe De Incubadora De Negocios Division Emprendedurismo",
                    Telefono = "5000-4219",
                   Correo = "rmartinez@ute.edu.mx",
                },
                new Contacto
                {
                    Nombre = "Jefe De Mantenimiento",
                    Telefono = "5000-4222",
                   Correo = "lsanchez@ute.edu.mx",
                },
                new Contacto
                {
                    Nombre = "Jefe De Informacion y Estadistica",
                    Telefono = "5000-4270",
                   Correo = "ftamayo@ute.edu.mx",
                },
                new Contacto
                {
                    Nombre = "Jefa De Recursos Humanos",
                    Telefono = "5000-4208",
                   Correo = "mgonzalez@ute.edu.mx",
                },
                new Contacto
                {
                    Nombre = "Jefa De Contabilidad",
                    Telefono = "5000-4208",
                   Correo = "sgarza@ute.edu.mx",
                },new Contacto
                {
                    Nombre = "Encargado Del Despacho De Rectoria",
                    Telefono = "5000-4216",
                    Correo = "utenl@ute.edu.mx",
                }


            };
        }

    }
}
