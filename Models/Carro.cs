namespace CarsWeb.Models 
{
    public class Carro {

        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public decimal Preco { get; set; }
        public CategoriaVeiculo Categoria { get; set;}
    }

    public enum CategoriaVeiculo {

        SUV,
        Sedan,
        Caminhonete,
        Hatch,
        Motocicleta,
        Conversivel
    }
}