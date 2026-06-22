package az.abb.first.dto;

import java.io.Serializable;

/**
 * DTO for {@link az.abb.first.entity.Contact}
 */
public record ContactRequestDto(String userType, String email, String name, String subject,
                                String message) implements Serializable {
}