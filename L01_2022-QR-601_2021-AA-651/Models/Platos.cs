using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.ComponentModel.DataAnnotations;
namespace L01_2022_QR_601_2021_AA_651.Models
{
    public class Platos
    {

        [Key]
        public int platoId { get; set; }
        public string nombrePlato { get; set; }
        public decimal precio { get; set; }
    }
}
