using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.ComponentModel.DataAnnotations;
namespace L01_2022_QR_601_2021_AA_651.Models
{
    public class Clientes
    {
        [Key]
        public int clienteId { get; set; }
        public string nombreCliente { get; set; }
        public string direccion { get; set; }


    }
}
