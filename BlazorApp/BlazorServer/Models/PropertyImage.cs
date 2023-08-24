using System;
namespace BlazorServer.Models
{
	public class PropertyImage
	{
		public int ImageID { get; set; }
		public int PropertyID { get; set; }
		public string ImageURL { get; set; }
		public string? Label { get; set; }
		public string? Type { get; set; }
		public int isThumbnail { get; set; }
    }
}

