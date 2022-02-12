using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{
    [Table("Category")]
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //anotação para informar que o id será gerado pelo banco.
        public int Id { get; set; }

        [Required]  //constraint is not null
        [MaxLength(80)] // define o tamanho maximo de caractere no campo IMPORTANTE SER O TAMANHO DO VARCHAR DO BANCO.
        [MinLength(3)] //define o tamanho minimo de caractere a ser inserido
        [Column("Name", TypeName = "NVARCHAR")] // Column definimos o nome da coluna referente do banco e o typename é para definir o tipo de coluna
        public string Name { get; set; }

        [Required]
        [MaxLength(80)]
        [MinLength(3)]
        [Column("Slug", TypeName = "VARCHAR")]
        public string Slug { get; set; }
    }
}