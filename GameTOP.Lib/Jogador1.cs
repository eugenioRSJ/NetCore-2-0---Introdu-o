using GameTOP.Interface;
namespace GameTOP.Lib
{
     public class Jogador1 : iJogador
    {
        public readonly string Nome;
        public Jogador1(string Nome)
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