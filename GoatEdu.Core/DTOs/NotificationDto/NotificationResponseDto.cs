namespace GoatEdu.Core.DTOs.NotificationDto;

public class NotificationResponseDto
{
    public Guid Id { get; set; }
    public string? NotificationName { get; set; }
    public Guid? UserId { get; set; }
    public DateTime? ReadAt { get; set; }
}