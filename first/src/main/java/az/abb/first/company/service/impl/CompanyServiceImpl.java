package az.abb.first.company.service.impl;

import az.abb.first.company.service.ICompanyService;
import az.abb.first.dto.CompanyDTO;
import az.abb.first.entity.Company;
import az.abb.first.repository.CompanyRepository;
import java.util.List;
import java.util.stream.Collectors;
import org.springframework.stereotype.Service;

@Service
public class CompanyServiceImpl implements ICompanyService {

    private final CompanyRepository companyRepository;

    public CompanyServiceImpl(CompanyRepository companyRepository) {
        this.companyRepository = companyRepository;
    }

    @Override
    public List<CompanyDTO> getAllCompanies() {

        var companyList = companyRepository.findAll();
        return companyList.stream().map(this::transformToDto).collect(Collectors.toList());
    }

    private CompanyDTO transformToDto(Company company) {
        return new CompanyDTO(company.getId(), company.getName(), company.getLogo(),
                company.getIndustry(), company.getSize(), company.getRating(),
                company.getLocations(), company.getFounded(), company.getDescription(),
                company.getEmployees(), company.getWebsite(), company.getCreatedAt());
    }
}
