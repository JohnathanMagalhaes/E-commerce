using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_commerce.Models
{
    [Table("Produtos")]
    public class ProdutoModel
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "O nome do produto deve ser informado.")]
        [Display(Name = "Nome do Produto")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Uma breve descrição do produto deve ser informado.")]
        [Display(Name = "Descrição curta do Produto")]
        [MinLength(20, ErrorMessage = "Descrição deve conter no mínimo {1} caracteres.")]
        [MaxLength(255, ErrorMessage = "Descrição não pode exceder {1} caracteres.")]
        public string DescricaoCurta { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "Uma breve descrição do produto deve ser informado.")]
        [Display(Name = "Descrição do Produto")]
        [MinLength(20, ErrorMessage = "Descrição deve conter no mínimo {1} caracteres.")]
        [MaxLength(1048, ErrorMessage = "Descrição não pode exceder {1} caracteres.")]
        public string DescricaoDetalhada { get; set; }

        [Required(ErrorMessage = "O valor do produto deve ser informado.")]
        [Display(Name = "Valor do Produto")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Uma imagem do produto deve ser informado.")]
        [Display(Name = "Valor do Produto")]
        public string imagem { get; set; }
        public bool ProdutoFavorito { get; set; }
        public bool Status { get; set; }

        [Required(ErrorMessage = "O produto deve conter uma categoria.")]
        [Display(Name = "Categoria do Produto")]
        public int CategoriaID { get; set; }
        public virtual CategoriaModel Categoria { get; set; }
    }
}