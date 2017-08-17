
namespace LM_Events
{
    public class DBEndereco
    {
        public int EnderecoId { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string CEP { get; set; }
        public int Cidade_id { get; set; }
        public int Estado_id { get; set; }
    }
}
