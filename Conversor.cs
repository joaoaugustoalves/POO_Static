namespace POO_Statc
{
    public static class Conversor 
    {
        private static  float cotacaoDolar = 5.10f;

         private static  float cotacaoEuro = 6.22f;

        public static float valorUsuario;
    

        // DOLAR / REAL


        public static float ConverterDolarParaReal(float valorEmDolar){
                return valorUsuario * cotacaoDolar;
        }

        public static float ConverterRealParaDolar(float valorEmReal){
            return valorUsuario / cotacaoDolar;
        }

        // Euro / Real

        public static float ConverterEuroParaReal(float valorEmEuro){
                return valorUsuario * cotacaoEuro;
        }

        public static float ConverterRealParaEuro(float valorEmReal){
            return valorUsuario / cotacaoEuro;
        }


    }
}