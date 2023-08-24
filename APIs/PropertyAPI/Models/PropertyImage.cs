using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PropertyAPI.Models;

public class PropertyImage
{
	[Key]
	public int ImageID { get; set; }

	[ForeignKey("Properties")]
	public int PropertyID { get; set; }
	public string ImageURL { get; set; }
	public string? Label { get; set; }
	public string? Type { get; set; }
	public int isThumbnail { get; set; }
}
