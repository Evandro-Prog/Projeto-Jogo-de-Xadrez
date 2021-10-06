using tabuleiro;

namespace xadrez
{
    //Classe "filha" da classe Peça
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }

        public override string ToString()
        {
            return "T";
        }
    }
}
