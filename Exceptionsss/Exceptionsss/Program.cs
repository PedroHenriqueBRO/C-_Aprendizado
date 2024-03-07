using Exceptionsss.Entities;
using Exceptionsss.Entities.Exceptions;
using System;
using System.Globalization;
namespace reservas
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Reservation Pedro = new Reservation(1003, DateTime.ParseExact("03/03/2004", "dd/MM/yyyy", CultureInfo.InvariantCulture), DateTime.ParseExact("06/03/2004", "dd/MM/yyyy", CultureInfo.InvariantCulture));
                Console.WriteLine("Dias : " + Pedro.duration());
                Console.WriteLine(Pedro.ToString());
                Pedro.updateDates(DateTime.ParseExact("02/03/2004", "dd/MM/yyyy", CultureInfo.InvariantCulture), DateTime.ParseExact("09/03/2004", "dd/MM/yyyy", CultureInfo.InvariantCulture));
                Console.WriteLine(Pedro.ToString());
            }
            catch(DomainException e) { 
                Console.WriteLine("Erro na reserva,"+e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Erro no formato," + e.Message);
            }
        }
    }
}