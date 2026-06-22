package az.abb.first.entity;

import jakarta.persistence.Column;
import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.Lob;
import jakarta.persistence.Table;
import java.time.Instant;
import lombok.Getter;
import lombok.Setter;
import org.hibernate.annotations.ColumnDefault;

@Getter
@Setter
@Entity
@Table(name = "contacts")
public class Contact {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "id", nullable = false)
    private Long id;

    @Column(name = "created_at", nullable = false)
    private Instant createdAt;

    @Column(name = "updated_at")
    private Instant updatedAt;

    @Column(name = "created_by", nullable = false, length = 20)
    private String createdBy;

    @ColumnDefault("'NEW'")
    @Column(name = "status", nullable = false, length = 20)
    private String status;

    @Column(name = "updated_by", length = 20)
    private String updatedBy;

    @Column(name = "user_type", nullable = false, length = 50)
    private String userType;

    @Column(name = "email", nullable = false)
    private String email;

    @Column(name = "name", nullable = false)
    private String name;

    @Column(name = "subject", nullable = false)
    private String subject;

    @Lob
    @Column(name = "message", nullable = false)
    private String message;


}