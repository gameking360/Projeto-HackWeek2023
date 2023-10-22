﻿using Back_End.Model;

namespace Back_End.Services.Interfaces
{
    public interface IEmissaoService
    {
        Task<EmissaoModel> GetEmissaoById(int id);
        Task<List<EmissaoModel>> GetAllEmissao();
        Task CreateEmissao(EmissaoModel request);
        Task DeleteEmissao(int id);
        Task UpdateEmissao(int id, EmissaoModel request);
        Task CalculoEmissao(EmissaoModel emissaoModel);
        Task<double> GetEmissaoTotal();
    }
}
