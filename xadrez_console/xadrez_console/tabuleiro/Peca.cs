using tabuleiro;

namespace tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdMovimento { get; protected set; }
        public Tabuleiro Tabuleiro { get; set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            Posicao = null;
            Cor = cor;
            QtdMovimento = 0;
            Tabuleiro = tab;
        }

        

    }
}
