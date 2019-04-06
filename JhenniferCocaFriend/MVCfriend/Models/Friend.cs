using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCfriend.Models
{
    public class Friend
    {
        public enum TipoFriend {
            Conocido,
            CompaneroEstudio,
            ColegaDeTrabajo,
            Amigo,
            AmigoDeInfancia,
            Pariente
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