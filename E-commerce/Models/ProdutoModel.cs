using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_commerce.Models
{
    [Table("Produtos")]
    public class ProdutoModel
    {
        [Key]
        public int ID { get; set; }

        [StringLength(100, MinimumLength = 10, ErrorMessage = "O tamanho máximo é {1} caracteres.")]
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
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, 19999.99, ErrorMessage = "O Preço deve estar entre 1 e 19.999,99")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Uma imagem do produto deve ser informado.")]
        [Display(Name = "Valor do Produto")]
        public string ImagemUrl { get; set; }

        [Display(Name = "Produto Favorito")]
        public bool ProdutoFavorito { get; set; }

        [Display(Name = "Estoque")]
        public bool Status { get; set; }

        [Required(ErrorMessage = "O produto deve conter uma categoria.")]
        [Display(Name = "Categoria do Produto")]
        public int CategoriaID { get; set; }
        public virtual CategoriaModel Categoria { get; set; }
    }
}