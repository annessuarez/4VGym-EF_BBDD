using System.Text.Json.Serialization;

namespace _4VGymEF.Models
{
    public class ActivityType
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public int NumberMonitors { get; set; } = 1;

        //PROPIEDAD DE NAVEGACIÓN: puedes hacer que un tipo de actividad tenga varias actividades
        //nueva interfaz, hay que decirle la nueva colección
        //ESTO RELACIONA CON LA TABLA ACTIVITY
        public ICollection<Activity> Activities { get; set; } = new List<Activity>();

    }

}
