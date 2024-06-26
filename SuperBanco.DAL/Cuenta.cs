namespace SuperBanco.DAL
{
    public class Cuenta
    {

        public int Id { get; set; }
        public string UsuarioId { get; set; }
        public string IBAN { get; set; }
        public decimal Saldo { get; set; }
        public string Tipo { get; set; }
        public string Estado { get; set; } 

    }
}
