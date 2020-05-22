namespace aula_28_04_2020_listaEncadeadaSimples
{
    public class Lista
    {
        public Elemento inicio { get; set; }
        public int tamanho { get; private set; }
        public Lista()
        {
            this.inicio = null;
        }
        public Lista(Elemento elemento)
        {
            this.inicio = elemento;
            if (elemento == null)
            {
                this.tamanho = 0;
            }
            else
            {
                this.tamanho = 1;
            }
        }

        public object mostrarElemento(int posicao)
        {
            if (inicio == null)
            {
                return "Empty list";
            }
            return this.inicio.mostrarElemento(posicao);
        }

        public string adecionar(Elemento novoElemento)
        {
            if (this.inicio == null)
            {
                this.inicio = novoElemento;
                tamanho++;
            }
            else
            {
                tamanho += inicio.adecionar(novoElemento);
            }
            return "item added";
        }

        public object deletarElemento(int posicao)
        {
            object holder = "item deleted";
            if (this.inicio == null)
            {
                holder = "Empty list";
            }
            else if (posicao == 0 && this.inicio.proximoElemento == null)
            {
                this.inicio = null;
                tamanho = 0;
            }
            else if (posicao == 1)
            {
                inicio.proximoElemento = inicio.proximoElemento.proximoElemento;
                tamanho--;
            }
            else
            {
                holder = this.inicio.deletarElemento(posicao);
                if (holder.Equals("item deleted"))
                {
                    tamanho--;
                }
            }
            return holder;
        }

        // public int tamanho(){
        //     if (this.inicio == null)
        //     {
        //         return 0;
        //     }
        //     return this.inicio.tamanho(1);
        // }
    }
}