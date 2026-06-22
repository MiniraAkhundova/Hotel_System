package az.abb.first.company.controller;

import az.abb.first.company.service.ICompanyService;
import az.abb.first.dto.CompanyDTO;
import java.util.List;
import lombok.RequiredArgsConstructor;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("/companies")
@RequiredArgsConstructor
public class CompanyController {

    private final ICompanyService companyService;

//    @Autowired //optional
//    public CompanyController(ICompanyService companyService) {
//        this.companyService = companyService;
//    }

    @GetMapping
    public ResponseEntity<List<CompanyDTO>> getAllCompanies() {
        return ResponseEntity.ok().body(companyService.getAllCompanies());
    }

}
