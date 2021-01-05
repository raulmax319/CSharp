using System;

class Conta {

    private string _titular;
    public double Saldo { get; private set; }
    public int NumeroDaConta { get; private set; }

    public Conta(string titular, int numConta) {
        Titular = titular;
        NumeroDaConta = numConta;
    }

    public string Titular {
        get { return _titular; }
        set {
            if(value != null && value.Length > 1) _titular = value;
            else System.Console.WriteLine("Nome do Titular precisa conter 4 ou mais caracteres");
        }
    }

    public void Deposito(double quantia) {
        Saldo += quantia;
    }

    public void Saque(double quantia) {
        Saldo -= (quantia + 5);
    }

    public override string ToString()
    {
        return $"Conta {this.NumeroDaConta}, Titular: {this.Titular}, Saldo: $ {this.Saldo}";
    }
}