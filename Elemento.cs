using System;

namespace aula_28_04_2020_listaEncadeadaSimples
{
    public class Elemento
    {
        public object elemento { get; set; }

        public int prioridade { get; set; }
        public Elemento proximoElemento { get; set; }

        public Elemento(object elemento, int prioridade)
        {
            this.elemento = elemento;
            this.prioridade = prioridade;
            this.proximoElemento = null;
        }

        //TODO: adicionar na lista encadeada simples caso seja adisinado um elemendo com outros elementos encadeados
        public int adecionar(Elemento novoElemento)
        {
            if (this.prioridade <= novoElemento.prioridade)
            {
                Elemento eHolder = new Elemento(this.elemento, this.prioridade);
                eHolder.proximoElemento = this.proximoElemento;
                this.proximoElemento = eHolder;
                this.elemento = novoElemento.elemento;
                this.prioridade = novoElemento.prioridade;
            }
            else if (this.proximoElemento == null)
            {
                this.proximoElemento = novoElemento;
            }
            else
            {
                this.proximoElemento.adecionar(novoElemento);
            }
            return 1;
        }

        public object mostrarElemento(int posicao)
        {
            if (posicao < 0 || (posicao > 0 && this.proximoElemento == null))
            {
                return "out of bounds";
            }
            else if (posicao == 0)
            {
                return this.elemento + ", " + this.prioridade;
            }
            else
            {
                posicao--;
                return this.proximoElemento.mostrarElemento(posicao);
            }
        }
        //TODO: aplicar o tamanho a adicionar na lista encadeada simples do elemento com outros elementos encadeados
        /*public int tamanho(){
            return tamanho(0);
        }
         private int tamanho(int continuaco){
             
             if (this.proximoElemento == null)
             {
                 return continuaco;
             }
             continuaco++;
             tamanho(continuaco);
             return continuaco;
         }*/

        public object deletarElemento(int posicao)
        {
            if (posicao < 0 || (posicao > 0 && this.proximoElemento == null))
            {
                return "out of bounds";
            }
            else if (posicao - 1 <= 0)
            {
                if (this.proximoElemento.proximoElemento != null)
                {
                    /*this.elemento = this.proximoElemento.elemento;
                    this.prioridade = this.proximoElemento.prioridade;*/
                    this.proximoElemento = this.proximoElemento.proximoElemento;
                }
                else
                {
                    this.proximoElemento = null;
                }
                return "item deleted";
            }
            else
            {
                return this.proximoElemento.deletarElemento(posicao-1);
            }
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}