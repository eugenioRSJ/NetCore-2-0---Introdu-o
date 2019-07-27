using System;
using GameTOP.Lib;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            JogoFODA jogo = new JogoFODA(new Jogador1("Elvis"), new Jogador1("Pivete"));
            jogo.IniciarJogo();
        }
    }
}
