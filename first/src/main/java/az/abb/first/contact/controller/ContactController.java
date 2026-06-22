package az.abb.first.contact.controller;

import static org.springframework.http.HttpStatus.CREATED;
import static org.springframework.http.HttpStatus.INTERNAL_SERVER_ERROR;

import az.abb.first.contact.service.IContactService;
import az.abb.first.dto.ContactRequestDto;
import lombok.RequiredArgsConstructor;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("/contacts")
@RequiredArgsConstructor
public class ContactController {

    private final IContactService contactService;

    @PostMapping
    public ResponseEntity<String> saveContactMsg(@RequestBody ContactRequestDto contactRequestDto) {
        return contactService.saveContact(contactRequestDto)
                ? ResponseEntity.status(CREATED).body("Request processed successfully")
                : ResponseEntity.status(INTERNAL_SERVER_ERROR)
                                                                                                                                                  .body("Request processing failed");
    }
}
