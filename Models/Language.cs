using System.ComponentModel.DataAnnotations;

namespace AngularClient.Models
{
    public class Language : UpdatableEntity
    {
        public string Name { get; set; }

        [StringLength(2)]
        public string Code { get; set; }
    }
}