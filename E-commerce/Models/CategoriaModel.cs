using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_commerce.Models
{
    [Table("Categorias")]
    public class CategoriaModel
    {
        [Key]
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 10, ErrorMessage = "O tamanho máximo é {1} caracteres.")]
        [Required(ErrorMessage = "O nome da categoria deve ser informado.")]
        [Display(Name = "Nome da Categoria")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Uma breve descrição da categoria deve ser informada.")]
        [Display(Name = "Descrição da Categoria")]
        [MinLength(20, ErrorMessage = "Descrição deve conter no mínimo {1} caracteres.")]
        [MaxLength(255, ErrorMessage = "Descrição não pode exceder {1} caracteres.")]
        public string Descricao { get; set; }
        public List<ProdutoModel> ProdutoModels { get; set; }
    }
}