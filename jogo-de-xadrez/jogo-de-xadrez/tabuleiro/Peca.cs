

namespace tabuleiro
{
    // A peça possui apenas um tabuleiro, porem um tabuleiro contem varias peças
    // Classe generica
    //Sempre que a classe possui ao menos uma função abstrata (que não implementa metodo na propria classe), a classe também deve ser definida como abstrata
    //Uma classe abstrata não pode ser instanciada, apenas herdada
    abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null; //Toda peça inicia na posição nula
            this.cor = cor;
            this.qteMovimentos = qteMovimentos;
            this.tab = tab;
        }
        public void incrementarQteMovimentos()
        {
            qteMovimentos ++;
        }

        //Metodos abstrato não possui implementção na classe, ele possui somente a definição de sua assinatura,
        //Sua implementação deve ser feita na classe derivada, é um metodo virtual que deve ser implementado usando o modificador override
        public abstract bool[,] movimentosPossiveis();
        
    }
}
