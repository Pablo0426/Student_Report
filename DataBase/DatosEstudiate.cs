using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class DatosEstudiate
    {
        public List<Estudientes> GetAll()
        {
            SchoolContext context = new SchoolContext();
            return context.Estudientes.ToList();
        }

        public void AddRegistro(string name, string Last_name, string seccion, string encargado, string padre_madre, string falta, string promo)
        {
            SchoolContext context = new SchoolContext();
            context.Estudientes.Add(new Estudientes { Nombre = name, Apellido = Last_name, Seccion = seccion, Encargado = encargado, Padre_o_Madre = padre_madre, Falta = falta,  Promocion = promo});
            context.SaveChanges();
        }

        public bool login(string user, string pass)
        {
            SchoolContext context = new SchoolContext();
            var tutores = context.Padres.ToList().Where(x => x.Nombre == user && x.Contraseña == pass);
            if (tutores.Count()>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Estudientes> getEstudiante(string tutor)
        {
            SchoolContext context = new SchoolContext();
            return context.Estudientes.Where(x => x.Padre_o_Madre == tutor).ToList();
        }

        public void AddUser(string name, string pass)
        {
            SchoolContext context = new SchoolContext();
            context.Padres.Add(new Padres { Nombre = name, Contraseña = pass});
            context.SaveChanges();
        }
    }
}
