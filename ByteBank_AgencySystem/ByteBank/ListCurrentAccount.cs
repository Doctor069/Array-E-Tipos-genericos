using ByteBank.Models;
using System;

namespace ByteBank
{
    public class ListCurrentAccount
    {
        //criando nossa lista de contas --- simplificado
        private CurrentAccount[] _itens; // campo de arrays de contas para armazenar
        private int _proximaPosicao; // representa o proximo index do array

        public int Tamanho { get { return _proximaPosicao; } } // indexador --- numero de items existente // _proximaPosicao -- do tamanho dela

        public ListCurrentAccount(int capacidadeInicial = 5) // criando argumento opcional --- não é necessario preencher na criação do construtor quando cria-lo, mas pode informar outro valor ainda  --- na criação fica mais evidente sobre oq sera do valor colocado
        { // caso digite na declaração de valor (capacidadeInicial: 10) --- sera adicionado um valor apenas a essa variavel em especifico, caso haja mais
            _itens = new CurrentAccount[capacidadeInicial]; // observação importante, maximo 3 contas
            _proximaPosicao = 0; // o valor padrao do int ja é zero, nao é necessario adioncar isso aqui
        }

        public void Adicionar(CurrentAccount item) 
        {
            VerificadorCapacidade(_proximaPosicao + 1); // criando uma nova capacidade

            Console.WriteLine($"Item sendo adicionado na psoção : {_proximaPosicao}"); // para acompanhar oq esta acontecendo

            //-------------------------------------------------------------------------------
            //PT I

            _itens[_proximaPosicao] = item; // adicionando o objeto ao indexe - 
            _proximaPosicao++; // pulando o indexe
        }

        //verificador da quantidade da lista criada se ultrapassa o limite estabelecido
        private void VerificadorCapacidade(int tamanhoArray)
        {
            if(_itens.Length >= tamanhoArray) // verificador de capacidade
            {
                return;
            }

            Console.WriteLine("Tamanho de arraw ultrapassado, aumentando array.");


            //otimizando codigo
            int novoTamanhoArray = _itens.Length * 2; // aumentando e diminuindo o processamento / otimizando programa
            if(novoTamanhoArray < tamanhoArray) // para evitar usar muita memoria do pc -- caso o array seja de 5, e precise de mais 1, ira para 10, dando mais espaço para trabalhar
            {
                novoTamanhoArray = tamanhoArray;
            }


            CurrentAccount[] novoArray = new CurrentAccount[novoTamanhoArray]; // caso ultrapasse o tamamanho, criara um novo tamanho

            for(int indece = 0; indece < _itens.Length; indece++) // aumentandp capacidade da lista
            {
                novoArray[indece] = _itens[indece];
            }

                _itens = novoArray;
        }

        public CurrentAccount GetIndexCurrentAccount(int index) // dados --- não é necessario - para indexaodr
        {
            if(index < 0 || index >= _proximaPosicao) //_proximaPosicao --- maior que o limete
            {
                throw new ArgumentOutOfRangeException("The argument is out of the range - ", nameof(index));
            }

            return _itens[index];
        }

        //metado .Remove
        public void Remover(CurrentAccount item)
        {
            int indeceItem = -1; // quando removemos um - todos os outros da frente voltam uma casa do array
                                // ele guardara a posição -  -1 --- valor invalido sem inicilalização
            for (int i = 0; i < _proximaPosicao; i++) // _proximaPosicao --- apenas para ate os espaços preenchido
            {
                CurrentAccount itemAtual = _itens[i];
                if (itemAtual.Equals(item))  // Equals -  determina quando o objeto em especifico equivale ao objecto corrente
                {
                    indeceItem = i;
                    break;
                }
            }

            for(int i = indeceItem; i < _proximaPosicao ; i++)
            {
                _itens[i] = _itens[i + 1];
            }

            _proximaPosicao--; // para uma posição livre
            _itens[_proximaPosicao] = null;
        }

        public void AdicionarVariasContas(params CurrentAccount[] itens) // criando sobrecarga de Adicionar()
        {
            foreach(CurrentAccount conta in itens)
            {
                Adicionar(conta);
            }
        }

        public CurrentAccount this[int index] => GetIndexCurrentAccount(index); // declarando indexador
    }
}
