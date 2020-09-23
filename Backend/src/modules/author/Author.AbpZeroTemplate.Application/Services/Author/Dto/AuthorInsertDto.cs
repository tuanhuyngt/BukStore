using System;
using System.ComponentModel.DataAnnotations;

namespace Author.AbpZeroTemplate.Application.Share.Author.Dto
{
    public class AuthorInsertDto
    {
        [Required]
        public string Author_Name { get; set; }

        public string Author_Gender { get; set; }

        public int Author_Birth { get; set; }

        public string Author_Des { get; set; }
    }
}
