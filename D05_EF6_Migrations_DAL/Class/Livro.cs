using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace D05_EF6_Migrations_DAL
{
    public class Livro
    {
        #region properties
        // Chave primária
        [Key]
        public int LivroID { get; set; }

        // Obrigatório e tamanho máximo
        [Required]
        [StringLength(9, ErrorMessage = "Limite de 9 carateres.")]
        [MaxLength(9)]
        public string ISBN { get; set; }

        // Obrigatório e tamanho máximo
        [Required]
        [StringLength(100, ErrorMessage = "Limite de 100 carateres.")]
        [MaxLength(100)]
        public string Titulo { get; set; }

        // Foreign key, mas sem data annotation
        public int EditoraID { get; set; }

        // Propriedade acrescentada depois da criação da BD.
        // Obriga a gerar 1 nova migration e fazer o update da BD.
        [Required]
        [StringLength(100, ErrorMessage = "Limite de 100 carateres.")]
        [MaxLength(100)]
        public string Tipo { get; set; }
        #endregion

        #region Navigation properties
        // 1 livro, com ISBN, é editado por uma única editora
        public Editora Editora { get; set; }
        #endregion
    }
}
