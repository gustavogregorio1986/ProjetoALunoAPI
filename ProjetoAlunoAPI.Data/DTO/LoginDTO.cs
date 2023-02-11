using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetoALunoAPI.Dominio.Dominio
{
    [Table("tb_Login")]
    public class LoginDTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Usuario { get; set; }

        public string Senha { get; set; }

        public string Perfil { get; set; }

        public LoginDTO()
        {

        }

        public LoginDTO(int Id, string Usuario, string Senha, string Perfil)
        {
            this.Id = Id;
            this.Usuario = Usuario;
            this.Senha = Senha;
            this.Perfil = Perfil;
        }

        public override string ToString()
        {
            return Id + "," + Usuario + "," + Senha + "," + Perfil;
        }
    }
}
