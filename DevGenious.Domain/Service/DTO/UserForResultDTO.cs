﻿namespace DevGenious.Domain.Service.DTO;
public class UserForResultDTO : AuditableForCreationDTO
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
}
