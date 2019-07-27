using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : iJogador
    {
        public readonly string Nome;
        public Jogador2(string Nome)
        {
            this.Nome = Nome;

        }
        public string Chuta()
        {
            return $"{Nome} está Chutando";
        }
        public string Corre()
        {
            return $"{Nome} está Correndo";
        }

        public string Passe()
        {
            return $"{Nome} está Passando";
        }
    }
}