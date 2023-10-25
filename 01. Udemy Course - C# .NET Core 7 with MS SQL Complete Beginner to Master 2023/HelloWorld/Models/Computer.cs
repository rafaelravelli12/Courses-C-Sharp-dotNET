namespace HelloWorld.Models
{
	// First approach
	// public class Computer
	// {
	// 	// private string _motherboard;
	// 	// public string? Motherboard { get; set; }
	// 	public string Motherboard { get; set; }
	// 	public int CPUCores { get; set; }
	// 	public bool HasWifi { get; set; }
	// 	public bool HasLTE { get; set; }
	// 	public DateTime ReleaseDate { get; set; }
	// 	public decimal Price { get; set; }
	// 	// public string? VideoCard { get; set; }
	// 	public string VideoCard { get; set; }
	// 	public Computer()
	// 	{
	// 		if (VideoCard == null)
	// 		{
	// 			VideoCard = "";
	// 		}
	// 		if (Motherboard == null)
	// 		{
	// 			Motherboard = "";
	// 		}
	// 	}
	// }

	// Second Approach
	public class Computer
	{
		public string Motherboard { get; set; } = "";
		public int CPUCores { get; set; }
		public bool HasWifi { get; set; }
		public bool HasLTE { get; set; }
		public DateTime ReleaseDate { get; set; }
		public decimal Price { get; set; }
		public string VideoCard { get; set; } = "";
	}
}
