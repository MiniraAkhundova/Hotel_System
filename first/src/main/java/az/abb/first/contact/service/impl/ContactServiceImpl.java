package az.abb.first.contact.service.impl;

import az.abb.first.contact.service.IContactService;
import az.abb.first.dto.ContactRequestDto;
import az.abb.first.entity.Contact;
import az.abb.first.repository.ContactRepository;
import java.time.Instant;
import lombok.AccessLevel;
import lombok.RequiredArgsConstructor;
import lombok.experimental.FieldDefaults;
import org.springframework.beans.BeanUtils;
import org.springframework.stereotype.Service;

@Service
@RequiredArgsConstructor
@FieldDefaults(level = AccessLevel.PRIVATE, makeFinal = true)
public class ContactServiceImpl implements IContactService {

    ContactRepository contactRepository;

    @Override
    public boolean saveContact(ContactRequestDto contactRequestDto) {
        boolean result = false;
        var contact = contactRepository.save(transformToEntity(contactRequestDto));
        if(contact != null && contact.getId() != null) {
            result = true;
        }
        return result;
    }

    private Contact transformToEntity(ContactRequestDto contactRequestDto) {
        Contact contact = new Contact();
        BeanUtils.copyProperties(contactRequestDto, contact);
        contact.setCreatedAt(Instant.now());
        contact.setCreatedBy("System");
        contact.setStatus("NEW");
        return contact;
    }
}
