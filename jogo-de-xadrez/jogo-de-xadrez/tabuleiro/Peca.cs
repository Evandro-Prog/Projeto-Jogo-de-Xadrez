

namespace tabuleiro
{
    // A peça possui apenas um tabuleiro, porem um tabuleiro contem varias peças
    // Classe generica
    class Peca
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
    }
}
