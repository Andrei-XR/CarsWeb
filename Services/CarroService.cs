using System.Collections.Generic;
using System.Linq;
using CarsWeb.Models;

namespace CarsWeb.Services
{
    public static class CarroService {

        static List<Carro> Carros { get; set; }
        static int NextId = 3;

        static CarroService() {

            Carros = new List<Carro> {
                new Carro { Id = 1, Marca = "Chevrolet", Modelo = "Tracker", Ano = 2018, Preco = 66000, Categoria = CategoriaVeiculo.SUV},
                new Carro { Id = 2, Marca = "Honda", Modelo = "Civic", Ano = 2009, Preco = 33000, Categoria = CategoriaVeiculo.Sedan},
            };
        }

        public static List<Carro> GetAll() => Carros;

        public static Carro Get(int id) => Carros.FirstOrDefault(c => c.Id == id);

        public static void Add(Carro carro) {

            carro.Id = NextId++;
            Carros.Add(carro);
        }

        public static void Delete(int id) {

            var carro = Get(id);

            if(carro is null) {

                return;
            }

            Carros.Remove(carro);
        }
    }
}