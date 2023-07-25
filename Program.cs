using System.Runtime.CompilerServices;

public class PostoGasolina
{
    static void Main(string[] args)
    {

        // Esse sistema irá calcular o valor que você pagará pela gasolina baseado no litro por km, supondo que seu carro roda 11km por litro, lembrando que caso você pagar no cartão de
        //filiado você receberá 5% de desconto.


        float valorGasolina = 5.80f;

        int km;

        float valorPorKm;

        string pagoNoCartao;

        float desconto = 0.05f;



        while (true)
        {
            Console.WriteLine("Digite a quantidade de quilômetros que você vai percorrer");

            km = int.Parse(Console.ReadLine());

            valorPorKm = valorGasolina * (km / 11);

            Console.WriteLine("Você deseja pagar no cartão?");

            pagoNoCartao = Console.ReadLine();


            if (pagoNoCartao == "Sim")
            {
                valorGasolina = valorPorKm - (valorPorKm * desconto);

                Console.WriteLine("Você deverá pagar {0}R$", valorGasolina);
            }
            else
            {
                valorGasolina = valorPorKm;
                Console.WriteLine("Você deverá pagar {0}R$", valorGasolina);
            }
        }


    }

}   
