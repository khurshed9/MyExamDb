using exam.n1.Enums;

namespace exam.n1.Mapping;

public class Query10
{
    public int UserId { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public string PhoneNumber { get; set; }

    public string Address { get; set; }

    public DateTime DateOfBirth { get; set; }

    public SupportTicketStatus Status { get; set; }
}