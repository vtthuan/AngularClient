using System.Collections.Generic;

namespace AngularClient.Models
{
    public class Category : UpdatableEntity
    {
        public string Name { get; set; }
        public bool Actif { get; set; }

        public ICollection<Video> Videos { get; set; }

    }
}