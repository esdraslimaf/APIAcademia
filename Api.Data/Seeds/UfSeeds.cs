using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Api.Data.Seeds
{
    public static class UfSeeds
    {
        public static void Ufs(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UfEntity>().HasData(
                new UfEntity
                {
                    Id = Guid.Parse("41a45a39-6175-4a63-8f99-d796e1d03e97"),
                    Sigla = "AC",
                    Nome = "Acre",
                    CreateAt = DateTime.Now
                },
                new UfEntity
                {
                    Id = Guid.Parse("5747e649-9a39-476e-88d3-2295d9e59e6d"),
                    Sigla = "AL",
                    Nome = "Alagoas",
                    CreateAt = DateTime.Now
                },
                new UfEntity
                {
                    Id = Guid.Parse("7c3cf2b8-6e61-4c29-aa75-107d7d3bde56"),
                    Sigla = "AP",
                    Nome = "Amapá",
                    CreateAt = DateTime.Now
                },
                new UfEntity
                {
                    Id = Guid.Parse("bc60d57e-87ad-4ab0-a37e-29c0f2f3f1e2"),
                    Sigla = "AM",
                    Nome = "Amazonas",
                    CreateAt = DateTime.Now
                },
                new UfEntity
                {
                    Id = Guid.Parse("d0f11c90-23e8-4388-98b0-99c02fdd1963"),
                    Sigla = "BA",
                    Nome = "Bahia",
                    CreateAt = DateTime.Now
                },
                new UfEntity
                {
                    Id = Guid.Parse("f0058a0a-1594-484a-9b23-02cb85d3bd1e"),
                    Sigla = "CE",
                    Nome = "Ceará",
                    CreateAt = DateTime.Now
                },
                new UfEntity
                {
                    Id = Guid.Parse("2347ae36-8725-4644-a5db-9c16f3dd90b5"),
                    Sigla = "DF",
                    Nome = "Distrito Federal",
                    CreateAt = DateTime.Now
                },
                new UfEntity
                {
                    Id = Guid.Parse("8fc1401b-7b83-4eac-bd40-87f8264c245e"),
                    Sigla = "ES",
                    Nome = "Espírito Santo",
                    CreateAt = DateTime.Now
                },
                new UfEntity
                {
                    Id = Guid.Parse("08b05eb3-0984-41d4-b727-605b6b2584c2"),
                    Sigla = "GO",
                    Nome = "Goiás",
                    CreateAt = DateTime.Now
                },
                new UfEntity
                {
                    Id = Guid.Parse("4ad9b3bc-8260-4e2a-a14e-b59e16909a77"),
                    Sigla = "MA",
                    Nome = "Maranhão",
                    CreateAt = DateTime.Now
                },
                new UfEntity
                {
                    Id = Guid.Parse("3c0ff789-0d2a-43cc-b067-44c2b4b1f30a"),
                    Sigla = "MT",
                    Nome = "Mato Grosso",
                    CreateAt = DateTime.Now
                },
                new UfEntity
                {
                    Id = Guid.Parse("1b5900b7-44ff-4a01-a1d8-c6eb4f5ab2aa"),
                    Sigla = "MS",
                    Nome = "Mato Grosso do Sul",
                    CreateAt = DateTime.Now
                },
                new UfEntity
                {
                    Id = Guid.Parse("b84760c3-efdb-4815-826e-50d529a4254c"),
                    Sigla = "MG",
                    Nome = "Minas Gerais",
                    CreateAt = DateTime.Now
                },
                new UfEntity
                {
                    Id = Guid.Parse("6dd67a6c-2f0d-4b32-b535-9c4075745f81"),
                    Sigla = "PA",
                    Nome = "Pará",
                    CreateAt = DateTime.Now
                },
                new UfEntity
                {
                    Id = Guid.Parse("ab48a0b4-2179-4a15-8a5c-6e54a2d37bfc"),
                    Sigla = "PB",
                    Nome = "Paraíba",
                    CreateAt = DateTime.Now
                },
                new UfEntity
                {
                    Id = Guid.Parse("8fd4f242-8fb1-4499-97b0-2c7f33b12212"),
                    Sigla = "PR",
                    Nome = "Paraná",
                    CreateAt = DateTime.Now
                },
                new UfEntity
                {
                    Id = Guid.Parse("7a824d07-25ec-49b7-b891-1a9f5f3e6b10"),
                    Sigla = "PE",
                    Nome = "Pernambuco",
                    CreateAt = DateTime.Now
                },
                new UfEntity
                {
                    Id = Guid.Parse("43f98b8b-3aa2-4f91-8fb6-16c98fd41a14"),
                    Sigla = "PI",
                    Nome = "Piauí",
                    CreateAt = DateTime.Now
                },
                new UfEntity
                {
                    Id = Guid.Parse("e0a6a60f-1b53-4c19-836f-7a071d1e91b1"),
                    Sigla = "RJ",
                    Nome = "Rio de Janeiro",
                    CreateAt = DateTime.Now
                },
                new UfEntity
                {
                    Id = Guid.Parse("b821b87b-0408-4665-8421-73d45a09dd54"),
                    Sigla = "RN",
                    Nome = "Rio Grande do Norte",
                    CreateAt = DateTime.Now
                },
                new UfEntity
                {
                    Id = Guid.Parse("97df85b3-cd25-4632-a356-aa9bde9cb593"),
                    Sigla = "RS",
                    Nome = "Rio Grande do Sul",
                    CreateAt = DateTime.Now
                },
                new UfEntity
                {
                    Id = Guid.Parse("8fd3c5ae-88b2-4e5c-b07b-009fb86bb6c2"),
                    Sigla = "RO",
                    Nome = "Rondônia",
                    CreateAt = DateTime.Now
                },
                new UfEntity
                {
                    Id = Guid.Parse("d9613a3a-1d62-4491-950f-d29cd1f89d5d"),
                    Sigla = "RR",
                    Nome = "Roraima",
                    CreateAt = DateTime.Now
                },
                new UfEntity
                {
                    Id = Guid.Parse("22df83df-8233-44ac-8f60-2bfa9d0dcd1c"),
                    Sigla = "SC",
                    Nome = "Santa Catarina",
                    CreateAt = DateTime.Now
                },
                new UfEntity
                {
                    Id = Guid.Parse("4fb7709a-d3b7-4e43-8104-e34b22fa2a2e"),
                    Sigla = "SP",
                    Nome = "São Paulo",
                    CreateAt = DateTime.Now
                },
                new UfEntity
                {
                    Id = Guid.Parse("3b1219b4-4887-40ed-87a3-59b1b9c02e09"),
                    Sigla = "SE",
                    Nome = "Sergipe",
                    CreateAt = DateTime.Now
                },
                new UfEntity
                {
                    Id = Guid.Parse("ba138af0-22a5-4b58-97d1-835b2566dcb3"),
                    Sigla = "TO",
                    Nome = "Tocantins",
                    CreateAt = DateTime.Now
                }
            );
        }
    }
}
