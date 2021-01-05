class ConversorDeMoedas {
    static public double cotacao = 3.10;
    static double IOF = 1.06;

    public static double dolarParaReal(double quantia) {
        return (cotacao * quantia) * IOF;
    }
}