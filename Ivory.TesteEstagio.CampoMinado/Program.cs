using System;

namespace Ivory.TesteEstagio.CampoMinado
{
    class Program
    {
        static void Main(string[] args)
        {
            var linha = "";
            var coluna = "";
            int linha1; 
            int coluna1;
            var campoMinado = new CampoMinado();
            Console.WriteLine("Início do jogo\n=========");            
            while(campoMinado.JogoStatus == 0)
            {
                Console.WriteLine(campoMinado.Tabuleiro); 
                Console.WriteLine("Escolha uma linha de 1 a 9");
                linha =  Console.ReadLine();
                int.TryParse(linha, out linha1);              
                
                while(linha1<=0 || linha1 >9)
                {   
                    Console.WriteLine("Comando linha invalido. Entre com nova jogada");
                    linha = Console.ReadLine();
                    int.TryParse(linha, out linha1);
                }
                
                Console.WriteLine("Escolha uma coluna de 1 a 9");
                coluna = Console.ReadLine();                
                int.TryParse(coluna, out coluna1);
                while (coluna1 <= 0 || coluna1 >9)
                {
                    Console.WriteLine("Comando colunda invalido. Entre com nova jogada");
                    coluna = Console.ReadLine();
                    int.TryParse(coluna, out coluna1);
                }
                campoMinado.Abrir(linha1, coluna1);
                switch (campoMinado.JogoStatus)
                {
                    case 0:
                        Console.WriteLine("Continue jogando");
                        break;
                    case 2:
                        Console.WriteLine("Game Over");
                        Console.WriteLine(campoMinado.Tabuleiro);
                        break;
                    case 1:
                        Console.WriteLine("Voce venceu o jogo");
                        Console.WriteLine(campoMinado.Tabuleiro);
                        break;
                }




            }
            
            Console.ReadLine(); 

            
        }   
    }
}