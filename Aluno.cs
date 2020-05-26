namespace ProjetoSimplesPOO
{
    public class Aluno
    {
        public string nome;
        public string curso;
        public int idade;
        public string rg;
        public bool bolsista;
        public float percentual;
        public float mediaFinal;
        public float valorMensalidade;

        /// <summary>
        /// Mostra a média final do aluno
        /// </summary>
        /// <returns>Media final (float)</returns>
        public float verMediaFinal(){
            return mediaFinal;
        }

        /// <summary>
        /// Calcular a mensalidade de acordo com a bolsa disponível
        /// </summary>
        /// <returns>Valor da Mensalidade a ser paga</returns>
        public float verMensalidade(){
            float calculo = valorMensalidade;

            if(bolsista == true){
                calculo = valorMensalidade - (valorMensalidade * percentual / 100);
            }
            return calculo;
        }

        /// <summary>
        /// Aprimora a resposta do usuário 
        /// </summary>
        /// <param name="condicao">Texto capturado pelo console</param>
        /// <returns>Retorna se é bolsista ou não - boolean</returns>
        public bool TraduzConsole (string condicao){

            if(condicao == "sim"){
                bolsista  = true;
            }else{
                bolsista = false;
            }

            return bolsista;
        }
    }
}