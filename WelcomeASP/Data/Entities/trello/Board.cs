using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace WelcomeASP.Data.Entities.trello
{
    public class Board
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        public Guid Id { get; set; }

        public string Title { get; set; }
        public ICollection<TrelloTag> Tags { get; set; }

        public List<Column> Column { get; set; }
    
        // Ссылка на изображение, в случае, если файл будет храниться в файловой системе

        public string ImgUrl { get; set; }

        // Поле в БД, где будет храниться тело изображения

        public byte[] Logo { get; set; }

        /*
        [NotMapped]
        public IFormFile fileToStorage { get; set; }

        [NotMapped]
        public IFormFile fileToDB { get; set; }
        */

    }
}
