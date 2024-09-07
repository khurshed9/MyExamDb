using exam.n1.Enums;

namespace exam.n1.Mapping;

public class Query1
{
    public int UserId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string Address { get; set; } = null!;

    public DateTime DateOfBirth { get; set; }

    public int OrderId { get; set; }

    public int UserIdCustomer { get; set; }

    public DateTime OrderDate { get; set; }

    public int Sum { get; set; }

    public OrderStatus Status { get; set; }
}