using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tv.Core.Entity.Concrete;

namespace tv.Entity.Concrete
{
    public class Offer
    {
        public int Id{ get; set; }
        public User OfferedbyUser { get; set; }
        public Advert OfferedProduct { get; set; }
        public User OfferedUser { get; set; }
        public Advert OfferedToProduct { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
