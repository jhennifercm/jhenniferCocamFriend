using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace APIfriend.Models
{
    public class Friend
    {
        public enum TipoFriend {
            Conocido,//0
            CompaneroEstudio,//1
            ColegaDeTrabajo,//2
            Amigo,//3
            AmigoDeInfancia,//4
            Pariente//5
        }
        [Key]
        public int FriendId { get; set; }

        [Required]
        public string Name { get; set; }
        
        public string Nickname { get; set; }

        public DateTime Birthdate { get; set; }

        [Required]
        public TipoFriend Type { get; set; }



    }
}