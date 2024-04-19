using WebAppStudy.Data.Enum;
using WebAppStudy.Models;

namespace WebAppStudy.ViewModule;

public class EditClubViewModule
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int AdressId { get; set; }
    public Adress Adress { get; set; }
    public string Image { get; set; }
    public ClubCategory ClubCategory { get; set; }
}