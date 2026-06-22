package az.abb.first.company.service;

import az.abb.first.dto.CompanyDTO;
import az.abb.first.entity.Company;
import java.util.List;

public interface ICompanyService {

    List<CompanyDTO> getAllCompanies();
}
