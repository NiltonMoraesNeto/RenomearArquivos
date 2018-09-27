using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {// coleta os parâmetros, se houver


            //RenomeiaArquivo “[PASTA]” “[PROCURA]” “[SUBSTITUI]”
            Console.WriteLine("Digite o caminho da pasta:");
            string caminho = Console.ReadLine();
            string pasta = caminho;

            Console.WriteLine("Digite o texto que será excluído:");
            string textoAntigo = Console.ReadLine();
            string nomeAntigo = textoAntigo;

            Console.WriteLine("Digite o texto que será incluído:");
            string textoNovo = Console.ReadLine();
            string nomeNovo = textoNovo;


            string folder = pasta;
            if (!Directory.Exists(folder))
            {
                Console.WriteLine("A pasta não existe");
                Console.ReadKey();
                return;
            }

            string find = nomeAntigo;
            if (string.IsNullOrEmpty(find))
            {
                Console.WriteLine("Nome Antigo não pode ser vazio");
                return;
            }

            string replace = nomeNovo;

            foreach (string file in Directory.GetFiles(folder))
            {
                Console.WriteLine(string.Format("Renomeando arquivo {0}", new object[] { file }));
                try
                {
                    File.Move(file, file.Replace(find, replace));
                    Console.WriteLine("SUCESSO!");
                }
                catch
                {
                    Console.WriteLine("Ops! Não foi possível renomear este arquivo!");
                }
            }
            Console.WriteLine("DIGITE QUALQUER TECLA PARA ENCERRAR!");
            Console.ReadKey();
        }
    }
}