namespace wa.Models.Dtos;

public class ResponseDto<T>
{
    public int status { get; set; }
    public string? msg { get; set; }
    public List<T>? items { get; set; }
}
