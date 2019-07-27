using System;
using GameTOP.Interface;

namespace GameTOP
{
    public class JogoFODA
    {
        private readonly iJogador _Jogador1;
        private readonly iJogador _Jogador2;

        public JogoFODA(iJogador jogador1, iJogador jogador2)
        {
            _Jogador2 = jogador2;
            _Jogador1 = jogador1;
        }
        public void IniciarJogo()
        {
            Console.WriteLine(_Jogador1.Corre());
            Console.WriteLine(_Jogador1.Chuta());
            Console.WriteLine(_Jogador1.Passe());

            Console.WriteLine("PROXIMO JOGADOR");

            Console.WriteLine(_Jogador2.Corre());
            Console.WriteLine(_Jogador2.Chuta());
            Console.WriteLine(_Jogador2.Passe());
        }
    }

}