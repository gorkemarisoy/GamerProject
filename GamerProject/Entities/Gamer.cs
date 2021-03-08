using System;
using System.Collections.Generic;
using System.Text;
using GamerProject.Abstract;

namespace GamerProject.Entities
{
    public class Gamer:IEntity //kaydı yapılacak nesne
    {
        public int Id { get; set; }
        public string NationalIdNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
