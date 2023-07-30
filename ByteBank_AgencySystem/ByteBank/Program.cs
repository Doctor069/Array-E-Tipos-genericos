using System;
using ByteBank.Models;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] nomes = new string[] { "N", "V" };
            //foreach (string nome in nomes)
            //{
            //    Console.WriteLine(nome);
            //}

            /* int[] contador = new int[3];

              for(int i = 0; i < contador.Length; i++)
              {
                  Console.WriteLine("Digite um numero");
                  contador[i] = Convert.ToInt32(Console.ReadLine());
              }

              Console.WriteLine();

              for(int i = 0; i < contador.Length; i++)
              {
                  Console.WriteLine($"A posição do array é: {i}. O numero correspondente é: {contador[i]}");
              }
            */
            //criandoVariias();
            IndixadoresEDeclarações();
            Console.ReadLine();
        }
        static void partefinal()
        {
            // Null em classes genericas
            List<int> idades = new List<int>();
            idades.AdicionarVariasT(45, 44, 54);

            int somaDasIdades = 0; // inicializado com zero --- nao nulo --- sao diferentes - 
                                   // null nao aponta para nenhum lugar da memoria
                                   // nao é possivel colocar nulo em int ----- obsssss
                                   // nem em booleanas --- valor padrao ja é --- false ---

            for (int i = 0; i < idades.Tamanho; i++)
            {
                int idade = idades[i]; // nao é necessario fazer conversao --- tipo generico ja int
                Console.WriteLine($"Indece da Idade {i}. Idade = {idade}");
            }


            string[] arrayTest = new string[2];
            arrayTest[0] = "Gato";
            Console.WriteLine(arrayTest[0]);
            Console.WriteLine(arrayTest[1]);
        }
        static void listaGenerica()
        {
            // lista generica --- criação para o tipo int --- int é um argumento do tipo generico
            List<int> idades = new List<int>();
            idades.AdicionarVariasT(45, 44, 54);

            // obs quando colocamos o mouse em sima da função aparece como --- int ---
            // acontece pois nos difinimos como uma lista generica de ints
            // --- caso colocassemos string, double, seria criado um tipo de lista desta
        }

        static void listaDeObjetos()
        {
            ObjectList listaIdades = new ObjectList();
            listaIdades.AdicionarVariasObjects(35, 5, 5);
            listaIdades.AdicionarObject(4);

            for (int i = 0; i < listaIdades.Tamanho; i++)
            {
                int idade = (int)listaIdades[i]; // necessario fazer a conversao
                Console.WriteLine($"Indece da Idade {i}. Idade = {idade}");
            }

        }

        static void argumentoParams()
        {
            ListCurrentAccount listaDeContas = new ListCurrentAccount();

            //argumento params --- criando varios indexes de vez
            CurrentAccount[] contas = new CurrentAccount[]
            {
                new CurrentAccount(44, 44),
                new CurrentAccount(55, 55),
                new CurrentAccount(66, 66),
                new CurrentAccount(77, 77)
            };
            listaDeContas.AdicionarVariasContas(contas);


        }

        static void IndixadoresEDeclarações()
        {
            //metado .Remove
            ListCurrentAccount list = new ListCurrentAccount();
            CurrentAccount conta = new CurrentAccount(99999, 99999);

            list.Adicionar(conta);
            list.Adicionar(new CurrentAccount(454, 454));
            list.Adicionar(new CurrentAccount(6565, 6565));
            list.Adicionar(new CurrentAccount(6565, 5665));

            for (int i = 0; i < list.Tamanho; i++)
            {
                //CurrentAccount itemAtual = list.GetIndexCurrentAccount(i);  -- nao é necessario fazer esse codigo todo, criamos um indexador
                CurrentAccount itemAtual = list[i];
                Console.WriteLine($"Posição atual referente : {i}. Numero da conta {itemAtual.NumeroDaConta}. Numero da Agencia {itemAtual.NumeroDaAgencia}");
            }

            Console.WriteLine("--------------------------------------");

            list.Remover(conta);
            for (int i = 0; i < list.Tamanho; i++)
            {
                CurrentAccount itemAtual = list[i];
                Console.WriteLine($"Posição atual referente : {i}. Numero da conta {itemAtual.NumeroDaConta}. Numero da Agencia {itemAtual.NumeroDaAgencia}");
            }

        }

        static void List()
        {
            //criando nosssas listas
            ListCurrentAccount list = new ListCurrentAccount();

            list.Adicionar(new CurrentAccount(454, 454));
            list.Adicionar(new CurrentAccount(6565, 6565));
            list.Adicionar(new CurrentAccount(6565, 5665));
            list.Adicionar(new CurrentAccount(6565, 5665));
            list.Adicionar(new CurrentAccount(6565, 5665));
            list.Adicionar(new CurrentAccount(6565, 5665));
        }
       
        static void criandoVariias()
        {
            CurrentAccount[] accounts = new CurrentAccount[]
            {
                //Inicialização de arrays  ---  açucar sintatico
                new CurrentAccount(326, 265),
                new CurrentAccount(455, 965),
                new CurrentAccount(355, 865),
                new CurrentAccount(926, 465),
                new CurrentAccount(136, 665)
            };
            /*
            accounts[0] = new CurrentAccount(326, 265);
            accounts[1] = new CurrentAccount(455, 965);
            accounts[2] = new CurrentAccount(355, 865);
            accounts[3] = new CurrentAccount(926, 465);
            accounts[4] = new CurrentAccount(136, 665); 
            */

            for (int i = 0; i < accounts.Length; i++)
            {
                CurrentAccount ContaAtual = accounts[i]; // para nao escrever --- ContaAtual[i].NumeroDaAgencia
                Console.WriteLine($"Acessando o numero da agencia {i}: {ContaAtual.NumeroDaAgencia}");
                Console.WriteLine($"Acessando o numero da conta {i}: {ContaAtual.NumeroDaConta}");

                Console.WriteLine();
            }
        }
       
        static void PrimeirasArrays()
        {
            // criação de arrays
            // criação com base nos indeces --- começando do zero --- caso 5 indices - 0 1 2 3 4
            // como o indece é um valor, ele pode ser guardado dentro de uma variavel e dps usado
            int quantidadeIndeces = 6;
            int[] gatos = new int[quantidadeIndeces];
            gatos[0] = 0;
            gatos[1] = 1;
            gatos[2] = 2;
            //gatos[3] = 3;   ---- sem valor  --- valor padrao = 0;
            gatos[4] = 4;
            gatos[5] = 5;

            //manipulando os arrays
            int Indece_5_gatos = gatos[5];

            if (Indece_5_gatos == 5)
            {
                Console.WriteLine("sim");
            }
            else
            {
                Console.WriteLine("nao");
            }

            Console.WriteLine(gatos[5]);
            Console.WriteLine("indece sem inicialização --- " + gatos[3]);

            // ------------------------------------------------------------

            /*
            int[] teste = null;
            teste[0] = 0;
            teste[1] = 1;
            teste[2] = 2; 
            */
            int[] pegandoValores = gatos;
            Console.WriteLine(pegandoValores[4]);
            Console.WriteLine();

            // ------------------------------------------------------------
            // escrevendo os array
            int acomulado = 0;
            for (int indece = 0; indece < gatos.Length; indece++)
            {
                int gato = gatos[indece];

                Console.WriteLine($"numedo do gato {gato}, numero do indece {indece}");

                Console.WriteLine(gatos.Length);

                acomulado += gato; // recupera os valores dos gatos o acoculador
            }

            int media = acomulado / gatos.Length; // recupera o total de gatos  ---  gatos.Length

            Console.WriteLine(media);
        }
    }
}
