using tabuleiro;

namespace xadrez
{
    //Classe "filha" da classe Peça
    class Rei : Peca 
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }

        public override string ToString()
        {
            return "R";
        }
    }
}
