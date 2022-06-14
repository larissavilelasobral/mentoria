namespace bytebak
 {
     //declarar o campo como anulável
    public class ContaCorrente
    {
        public string? titular;
        public string? titularCpf;
        public string? titularProfissao;
        public string? conta;
        public int numero_agencia;
        public string? nome_agencia;
        public double saldo;
        public bool verificador;

        public bool Sacar(double valor)
        {
            if(saldo < valor && saldo < 0)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            if(valor < 0)
            {
                return;
            }
            saldo = saldo + valor;
        }

        public bool Trasferir(double valor, ContaCorrente destino)
        {
            if(saldo < valor)
            {
                return false;
            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                destino.saldo = destino.saldo + valor;
                return true;
            }
        }

        public void Extrato()
        {
            Console.WriteLine("Titular da Conta: " + titular);
            Console.WriteLine("Saldo da Conta: " + saldo);
        }
    }
}