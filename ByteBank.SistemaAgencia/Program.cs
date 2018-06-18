using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            // Olá, meu nome é Guilherme e você pode entrar em contato comigo
            // através do número 8457-4456!

            // Meu nome é Guilherme, me ligue em 4784-4546

            //  "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
            //  "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            //  "[0-9]{4,5}[-][0-9]{4}";
            //  "[0-9]{4,5}[-]{0,1}[0-9]{4}";
            //  "[0-9]{4,5}-{0,1}[0-9]{4}";
            string padrao = "[0-9]{4,5}-?[0-9]{4}";

            // 879.546.120-20
            // 879546120-20

            string textoDeTeste = "idyufdgfugfjksdhf 99871--5456 sdjkfgsdjgsjgh sfsdjgsdjghsdfj";

            Match resultado = Regex.Match(textoDeTeste, padrao);

            Console.WriteLine(resultado.Value);
            Console.ReadLine();








            string urlTeste = "https://www.bytebank.com/cambio";
            int indiceByteBank = urlTeste.IndexOf("https://www.bytebank.com");




            Console.WriteLine(urlTeste.StartsWith("https://www.bytebank.com"));
            Console.WriteLine(urlTeste.EndsWith("cambio/"));


            Console.WriteLine(urlTeste.Contains("ByteBank"));

            
            Console.ReadLine();

            // pagina?argumentos
            // 012345678



            //moedaOrigem=real&moedaDestino=dolar
            //          |
            //  -------´

            string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametros);

            string valor = extratorDeValores.GetValor("moedaDestino");
            Console.WriteLine("Valor de moedaDestino: " + valor);

            string valorMoedaOrigem = extratorDeValores.GetValor("moedaOrigem");
            Console.WriteLine("Valor de moedaOrigem: " + valorMoedaOrigem);

            Console.WriteLine(extratorDeValores.GetValor("VALOR"));

            Console.ReadLine();



            //Testando ToLower
            string mensagemOrigem = "PALAVRA";
            string termoBusca = "ra";

            Console.WriteLine(mensagemOrigem.ToLower());


            // Testando Replace
            termoBusca = termoBusca.Replace('r', 'R');
            Console.WriteLine(termoBusca);

            termoBusca = termoBusca.Replace('a', 'A');
            Console.WriteLine(termoBusca);

            Console.WriteLine(mensagemOrigem.IndexOf(termoBusca));
            Console.ReadLine();

            // Testando o método Remove
            string testeRemocao = "primeiraParte&123456789";
            int indiceEComercial = testeRemocao.IndexOf('&');
            Console.WriteLine(testeRemocao.Remove(indiceEComercial, 4));
            Console.ReadLine();


            // <nome>=<valor>
            string palavra = "moedaOrigem=moedaDestino&moedaDestino=dolar";
            string nomeArgumento = "moedaDestino=";

            int indice = palavra.IndexOf(nomeArgumento);
            Console.WriteLine(indice);

            Console.WriteLine("Tamanho da string nomeArgumento: " + nomeArgumento.Length);

            Console.WriteLine(palavra);
            Console.WriteLine(palavra.Substring(indice));
            Console.WriteLine(palavra.Substring(indice + nomeArgumento.Length));
            Console.ReadLine();





            // Testando o IsNullOrEmpty
            string textoVazio = "";
            string textoNulo = null;
            string textoQualquer = "kjhfsdjhgsdfjksdf";
            Console.WriteLine(String.IsNullOrEmpty(textoVazio));
            Console.WriteLine(String.IsNullOrEmpty(textoNulo));
            Console.WriteLine(String.IsNullOrEmpty(textoQualquer));
            Console.ReadLine();

            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL("");

            string url = "pagina?moedaOrigem=real&moedaDestino=dolar";

            int indiceInterrogacao = url.IndexOf('?');

            Console.WriteLine(indiceInterrogacao);

            Console.WriteLine(url);
            string argumentos = url.Substring(indiceInterrogacao + 1);
            Console.WriteLine(argumentos);
        }
    }


}
