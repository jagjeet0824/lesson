using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace comp2007amMusicStore.Models
{
    public class Album
    {
        public string Title { get; set; }
        public Genre Genre { get; set; }

        [Display(Name = "Album Cover")]
        public string AlbumArtUrl { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        [Required]
        public double Price { get; set; }
    }
}