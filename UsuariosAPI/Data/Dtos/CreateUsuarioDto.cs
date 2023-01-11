using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UsuariosAPI.Data.Dtos
{
    public class CreateUsuarioDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)] //define os dados como senha
        public string Password { get; set; }
        [Required]
        [Compare("Password")] //Compara a senha
        public string RePassword { get; set; }
        [Required]
        public DateTime DataNascimento { get; set; }
    }
}
