using exam.n1.Enums;

namespace exam.n1.Mapping;

public class Query14
{
    public int TicketId { get; set; }

    public int UserId { get; set; }

    public string issuetype { get; set; }

    public string Description { get; set; }

    public SupportTicketStatus Status { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime ResolvedAt { get; set; }
}