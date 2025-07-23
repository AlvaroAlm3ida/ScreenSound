namespace ScreenSound
{
    public class sortNumber
    {
        public static void Executar()
        {
            Random aleatorio = new Random();
            int numeroSecreto = aleatorio.Next(1,101);
            do
            {
                Console.Write("Digite um numero entre 1 e 100 ");
                int chute = int.Parse(Console.ReadLine());

                if (chute == numeroSecreto)
                {
                    Console.WriteLine("Parabéns, você achou");
                    break;
                }
                else if (chute < numeroSecreto)
                {
                    Console.WriteLine("O número é maior.");

                } else
                {
                    Console.WriteLine("O número é menor.");
                }

            }while (true);
            







        }
    }
}