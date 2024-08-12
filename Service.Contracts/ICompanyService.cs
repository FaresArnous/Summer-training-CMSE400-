﻿using Shared.DataTransferObjects;

namespace Service.Contracts
{
    public interface ICompanyService
    {
        Task<IEnumerable<CompanyDto>> GetAllCompaniesAsync(bool trackChanges);
        Task<CompanyDto> GetCompanyAsync(Guid CompanyId, bool trackChanges);
        Task<CompanyDto> GetCompanybyNameAsync(string CompanyName, bool trackChanges);

        Task<CompanyDto> CreateCompanyAsync(CompanyForCreationDto company);
        Task<IEnumerable<CompanyDto>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges);
       Task<(IEnumerable<CompanyDto> companies,string ids)> CreateCompanyCollectionAsync
            (IEnumerable<CompanyForCreationDto> companyCollection);

        Task DeleteCompanyAsync(Guid CompanyId, bool trackChanges);

        Task UpdateCompanyAsync(Guid comoanyId, CompanyForUpdateDto companyForUpdate, bool trackChanges);

    }
}
