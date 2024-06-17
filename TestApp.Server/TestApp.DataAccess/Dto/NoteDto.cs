namespace TestApp.DataAccess.Dto;

public class NoteDto : IStorageDto
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Text { get; set; }
}
