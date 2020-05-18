using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string FavoriteGenre { get; set; }
        public string FavoriteSong { get; set; }        
        [Display(Name = "Album Cover")]
        public string ImagePath { get; set; }
    }
}
