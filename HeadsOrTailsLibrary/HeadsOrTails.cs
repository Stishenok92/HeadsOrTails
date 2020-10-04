using System.ComponentModel.DataAnnotations;
using System;

namespace HeadsOrTailsLibrary
{
    public class HeadsOrTails
    {
        public const int MIN_NUMBER_THROW = 0;
        
        public static bool ValidationNumberThrow(int numberThrow)
        {
            return numberThrow >= 0;
        }
        
        public static bool TossCoinIsHead()
        {
            return new Random().Next(2) % 2 == 0;
        }

        public static int CalculateDropOneSide(int numberThrow)
        {
            if (!ValidationNumberThrow(numberThrow))
            {
                throw new ValidationException();
            }

            int count;
            
            for (count = 0; numberThrow != 0; --numberThrow)
            {
                if (TossCoinIsHead())
                {
                    ++count;
                }
            }

            return count;
        }
        
        
    }
}