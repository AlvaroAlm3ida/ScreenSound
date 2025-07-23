namespace ScreenSound
{
    public class List
    {
        public static void Executar()
        {
            //1. Criar uma variável chamada notaMedia e atribua um valor inteiro a ela. Caso seu valor seja maior ou igual a 5, escreva na tela "Nota suficiente para aprovação".
            int notaMedia = 5;
            if (notaMedia >= 5)
            {
                Console.WriteLine("Nota suficiente para aprovação");
            }
            else
            {
                Console.WriteLine("Nota insuficiente para aprovação");
            }

            //2.Criar uma lista de linguagens de programação, com as linguagens C#, Java e JavaScript.
            List<string> linguagens = new List<string>{"Java", "C#", "Python", "Javascript", "Go"};

            //3.Exibir o valor "C#" no console, utilizando a lista criada no exercício anterior.
            // iniciador, contador, iterador
            //Iterador é a condição executada ao final de cada iteração do loop
            string valorProcurado = "C#";
            for (int i = 0; i < linguagens.Count; i++)
            {
                if (linguagens[i] == valorProcurado)
                {
                    Console.WriteLine($"O Valor procurado '{valorProcurado}'foi encontrado na posição {i}.");
                }
            }

            //4.Criar um programa que, dado a entrada de dados de um número n inteiro, a partir do teclado, exibir a n-ésima posição de uma lista.
            Console.WriteLine("Digite a posição desejada: ");
            int posicao = int.Parse(Console.ReadLine());

            Console.WriteLine(linguagens[posicao]);


        }
    }
}