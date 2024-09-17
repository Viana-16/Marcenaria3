using API.DTO.Produto;
using AutoMapper;
using Marcenaria._03_Entidades;
using Marcenaria01._03_Entidades;
using Marcenaria01._03_Entidades.DTO.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marcenaria01
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {

            CreateMap<CreateProdutosDTO, Produtos>().ReverseMap();
            CreateMap<CreateFornecedorDTO, Fornecedor>().ReverseMap();
            CreateMap<CreateClienteDTO, Cliente>().ReverseMap();
            CreateMap<CreateCompraDTO, Compra>().ReverseMap();
            CreateMap<CreateFuncionarioDTO, Funcionario>().ReverseMap();
            CreateMap<CreateMaterialDTO, Material>().ReverseMap();
        }
    }
}
