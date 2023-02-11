using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetoALunoAPI.Dominio.Dominio
{
    [Table("tb_Administrador")]
    public class Administrador
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string NomeAdm { get; set; }

        public string EmailAdm { get; set; }

        public Login Login { get; set; }

        [ForeignKey("Login")]
        public int Id_Login { get; set; }

        public Administrador()
        {

        }

        public Administrador(int Id, string NomeAdm, string EmailAdm)
        {
            this.Id = Id;
            this.NomeAdm = NomeAdm;
            this.EmailAdm = EmailAdm;
        }

        public override string ToString()
        {
            return Id + "," + NomeAdm + "," + EmailAdm;
        }
    }
}
