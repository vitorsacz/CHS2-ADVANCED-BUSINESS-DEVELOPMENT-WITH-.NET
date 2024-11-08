using System.ComponentModel.DataAnnotations.Schema;

namespace Prevdent.Domain.Entities
{
    [Table("T_CH_Dentistas")]
    public class DentistaEntity : UserEntity
    {
        public string CRO { get; set; }
    }
}
