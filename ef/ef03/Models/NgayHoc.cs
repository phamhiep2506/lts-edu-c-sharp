using System.ComponentModel.DataAnnotations;

namespace ef03.Models;

public class NgayHoc
{
  [Key]
  public int NgayHocId { get; set; }

  [Required]
  public int? KhoaHocId { get; set; }

  public string? NoiDung { get; set; }

  public string? GhiChu { get; set; }

  public virtual KhoaHoc? KhoaHoc { get; set; }
}
