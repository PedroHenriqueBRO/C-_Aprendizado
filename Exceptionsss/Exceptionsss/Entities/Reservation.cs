using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exceptionsss.Entities.Exceptions;
namespace Exceptionsss.Entities
{
    public class Reservation
    {
        public int roomNumber {  get; set; }
        public DateTime checkin {  get; set; }

        public DateTime checkout { get; set; }

        public Reservation(int roomNumber,DateTime checkin,DateTime checkout) { 
            this.roomNumber = roomNumber;

            if (checkout <= checkin) throw new DomainException("A data de checkout é menor que a data de checkin");
            else
            {
                this.checkin = checkin;
                this.checkout = checkout;
            }

        }
        public int duration()
        {
            return (int)checkout.Subtract(checkin).TotalDays;
        }
        public void updateDates(DateTime checkin,DateTime checkout)
        {
            if ((this.checkin < checkin && this.checkout < checkout) && (checkout > checkin))
            {
                this.checkin = checkin;
                this.checkout = checkout;
            }
            else throw new DomainException("Data de atualização não permitida");
            
        }

        public override string ToString()
        {
            return "Quarto : "+roomNumber+",Checkin : "+checkin+ ",Checkout : "+checkout;
        }
    }
}
