using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace CrudMVC_MongoDB.Models
{
    public class Aluno
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Digite o nome do Aluno")]
        [MaxLength(50, ErrorMessage = "Nome do Aluno está muito grande, favor abreviar")]
        public string Nome { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "Digite o e-mail do Aluno")]
        [EmailAddress(ErrorMessage = "E-mail em formato inválido")]
        [MaxLength(100, ErrorMessage = "E-mail está muito grande")]
        public string Email { get; set; }

        [Display(Name = "Curso")]
        [Required(ErrorMessage = "Digite o curso do Aluno")]
        [MaxLength(50, ErrorMessage = "Nome do curso está muito grande, favor abreviar")]
        public string Curso { get; set; }

        [Display(Name = "Sexo")]
        [Required(ErrorMessage = "Escolha o sexo do Aluno")]
        public string Sexo { get; set; }

        [BsonIgnore]
        public SelectList Gender { get; set; }
    }
}
