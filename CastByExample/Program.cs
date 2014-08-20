using System;

namespace CastByExample
{
    class Program
    {
        static void Main( string[] args )
        {
            var cat = new
            {
                IsCondescending = true,
                IsLoyalToAFault = false
            };

            var dog = new
            {
                IsCondescending = false,
                IsLoyalToAFault = true
            };

            Console.WriteLine("A cat is condescending ({0}) and loyal to a fault ({1})", cat.IsCondescending, cat.IsLoyalToAFault);
            Console.WriteLine("A dog is condescending ({0}) and loyal to a fault ({1})", dog.IsCondescending, dog.IsLoyalToAFault);
            
            cat = Cast( cat, dog );

            Console.WriteLine( "{0}**Magic**{0}", Environment.NewLine);
            
            Console.WriteLine("Now, a cat is condescending ({0}) and loyal to a fault ({1})", cat.IsCondescending, cat.IsLoyalToAFault);
            
            Console.ReadLine();
        }

        private static T Cast<T>( T typeHolder, Object x )
        {
            return (T)x;
        }
    }
}
