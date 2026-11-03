using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using _4VGymEF.Validations;

namespace _4VGymEF.Models
{
    public class Activity
    {
        public int Id { get; set; } //lo entiende como autonumérico

        public int? ActivityTypeId { get; set; }

        public int MaxParticipants { get; set; }

        public DateTime DateStart { get; set; }

        public DateTime DateEnd { get; set; }

        //PROPIEDADES DE NAVEGACIÓN
        // 1 Actividad puede tener N isntructores
        public ICollection<Instructor> Instructors { get; set; } = new List<Instructor>();
        
        // 1 Actividad pertenece a 1 Tipo de Actividad
        public ActivityType? ActivityType { get; set; } = new ActivityType(); 
        //ahora se podrá hacer actividad.ActivityType.name y sacar el nombre del tipo de actividad de la Actividad que estamos buscando
        //activity.Instructors.FirstOrDefault().Nombre -> para sacar el primer nombre del instructor de la actividad seleccionada.
    }

}
