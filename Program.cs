using System;

namespace resale_a_car
{
    class Program
    {
        static void Main()
        {
            Console.Write("Cu cati lei doresti sa procuri masina ?   ");
            int pret = Convert.ToInt32 (Console.ReadLine ());
            Console.Write("Cati lei vrei sa dai pentru accesorii pentru masina ?   ");
            int pretAccesorii = Convert.ToInt32 (Console.ReadLine ());

            int totalInvestitie = pret + pretAccesorii ;

            Console.Write( " Ai bagat in masina : " + totalInvestitie + " lei   ");

            Console.Write("Cu ce coeficient vrei sa vinzi masina ? (ex: 1.5 pentru 50%):   ");
            double coeficient = Convert.ToDouble ( Console.ReadLine ());
            double baniPrimiti = totalInvestitie * coeficient ;
            Console.Write("Felicitari! ai vandut masina cu " + baniPrimiti    );

        }
    }
}