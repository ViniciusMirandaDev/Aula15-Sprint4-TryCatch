using System;
using System.IO;

namespace Aula15_Sprint4_TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Permissao app = new Permissao();
            app.Autorizar();

             try
            {
                using (StreamReader sr = File.OpenText("data.txt"))
                {
                    Console.WriteLine($"A primeira linha desse arquivo é: \n {sr.ReadLine()}");
                }
            }
            // usar em arquivo
            
            catch (FileNotFoundException)
            {
                Console.WriteLine($"O arquivo não foi encontrado");
            }
            //Usar em diretório
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine($"O diretório não foi encontrado");
            }
            //usar em id
            catch (IOException)
            {
                Console.WriteLine($"O arquivo não pode ser aberto");
            }  
        }
    }
}
