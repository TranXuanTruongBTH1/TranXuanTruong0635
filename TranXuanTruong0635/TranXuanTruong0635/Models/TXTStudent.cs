using System.ComponentModel.DataAnnotations;
namespace TranXuanTruong0635.Models;

public class TXTStudent
{
    [Key]
    public string? TXTStudentId { get; set; }

    public string? TXTStudentName {get; set; }
    public string? TXTStudentSex {get; set;}
}
