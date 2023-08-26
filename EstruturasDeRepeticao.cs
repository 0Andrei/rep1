namespace estruturas_csharp {
    public class EstruturasDeRepeticao {
        public static void executar() {
            int cont = 10;

            // Enquanto
            while (cont < 10) {
                Console.WriteLine("While: " + cont++);
            }

            int cont2 = 10;

            // Faça ... Enquanto
            do {
                Console.WriteLine("DO...While: " + cont2++);
            }  while(cont2 < 10);

            // Para
            for(int contFor = 0;contFor < 10;contFor++) {
               Console.WriteLine("For:" + contFor);
            }
        }
    }
}