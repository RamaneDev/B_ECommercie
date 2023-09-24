using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class ProductBrand : BaseEntities
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public new int Id { get; set; }
        public string Name { get; set; }

    }
}
