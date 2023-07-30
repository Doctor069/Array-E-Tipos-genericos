using System;

namespace ByteBank
{
    // genericos --- lista generica
    // T é de conversao --- T de tipo --- pode ser qualquer nome
    public class List<T>
    {
        private T[] _itens;
        private int _proximaPosicao;

        public int Tamanho { get { return _proximaPosicao; } }

        public List()
        {
            _itens = new T[3];
            _proximaPosicao = 0;
        }

        public void AdicionarObject(T item)
        {
            VerificadorCapacidadeT(_proximaPosicao + 1); // nesse caso ( + 1 != ++ )

            Console.WriteLine($"Item sendo adicionado na psoção : {_proximaPosicao}");

            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }

        private void VerificadorCapacidadeT(int tamanhoArray)
        {
            if (_itens.Length >= tamanhoArray)
            {
                return;
            }

            Console.WriteLine("Tamanho de arraw ultrapassado, aumentando array.");
            int novoTamanhoArray = _itens.Length * 2;
            if (novoTamanhoArray < tamanhoArray)
            {
                novoTamanhoArray = tamanhoArray;
            }

            T[] novoArray = new T[novoTamanhoArray];

            for (int indece = 0; indece < _itens.Length; indece++)
            {
                novoArray[indece] = _itens[indece];
            }

            _itens = novoArray;

        }

        public T GetIndexT(int index)
        {
            if (index < 0 || index >= _proximaPosicao)
            {
                throw new ArgumentOutOfRangeException("The argument is out of the range - ", nameof(index));
            }

            return _itens[index];
        }

        public void Remover(T item)
        {
            int indeceItem = -1; // tipo de valor invalido --- para dizer que nao inicializou

            for (int i = 0; i < _proximaPosicao; i++)
            {
                T itemAtual = _itens[i];
                if (itemAtual.Equals(item))
                {
                    indeceItem = i;
                    break;
                }
            }

            for (int i = indeceItem; i < _proximaPosicao; i++)
            {
                _itens[i] = _itens[i + 1];
            }

            _proximaPosicao--;
            //_itens[_proximaPosicao] = null; --- tipo genero nao pode receber nulo
            // ha possibilidades de ser --- int ou bool --- elas nao podem ser nulas
            // valores padroes --- 0 e false ---
            // proteção do compilador
        }

        public void AdicionarVariasT(params T[] itens)
        {
            foreach (T item in itens)
            {
                AdicionarObject(item);
            }
        }

        public T this[int index]
        {
            get
            {
                return GetIndexT(index);
            }
        }
    }
}
