namespace estruturas_csharp {
    public class Vetores {
        public static void executar() {
            int[] vetor = new int[2];

            vetor[0] = 10;
            vetor[1] = 5;

            for(int i = 0;i < 2;i++) {
                Console.WriteLine("Valor: " + vetor[i]);
            }

            foreach(int item in vetor) {
                Console.WriteLine("Valor (foreach): " + item);
            }
        }
    }
}