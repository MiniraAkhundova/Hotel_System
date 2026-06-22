package az.abb.first.contact.service;

import az.abb.first.dto.ContactRequestDto;

public interface IContactService {

    boolean saveContact(ContactRequestDto contactRequestDto);

}
