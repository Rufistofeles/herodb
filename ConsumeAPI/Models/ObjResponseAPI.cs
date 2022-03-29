using Newtonsoft.Json;

namespace ConsumeAPI.Models
{
	public class ResponseByNameAPI
	{
		public string Response { get; set; }
		[JsonProperty("results-for")]
		public string Results_for { get; set; }
		public List<ResultsByName> Results { get; set; }
	}
	public class ResponseByIdAPI
	{
		public string Response { get; set; }
		public string Id { get; set; }
		public string Name { get; set; }
		public Powerstats Powerstats { get; set; }
		public Biography Biography { get; set; }
		public Appearance Appearance { get; set; }
		public Work Work { get; set; }
		public Connections Connections { get; set; }
		public Image Image { get; set; }
	}
	public class ResultsByName
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public Powerstats Powerstats { get; set; }
		public Biography Biography { get; set; }
		public Appearance Appearance { get; set; }
		public Work Work { get; set; }
		public Connections Connections { get; set; }
		public Image Image { get; set; }
	}	
	public class Powerstats
	{
		public string Intelligence { get; set; }
		public string Strength { get; set; }
		public string Speed { get; set; }
		public string Durability { get; set; }
		public string Power { get; set; }
		public string Combat { get; set; }
	}
	public class Biography
	{
		[JsonProperty("full-name")]
		public string Full_name { get; set; }
		[JsonProperty("alter-egos")]
		public string Alter_egos { get; set; }
		public string[] Aliases { get; set; }
		[JsonProperty("place-of-birth")]
		public string Place_of_birth { get; set; }
		[JsonProperty("first-appearance")]
		public string First_appearance { get; set; }
		public string Publisher { get; set; }
		public string Alignment { get; set; }
	}
	public class Appearance
	{
		public string Gender { get; set; }
		public string Race { get; set; }
		public string[] Height { get; set; }
		public string[] Weight { get; set; }
		[JsonProperty("eye-color")]
		public string Eye_color { get; set; }
		[JsonProperty("hair-color")]
		public string Hair_color { get; set; }
	}
	public class Work
	{
		public string Occupation { get; set; }
		public string Base { get; set; }
	}
	public class Connections
	{
		[JsonProperty("group-affiliation")]
		public string Group_affiliation { get; set; }
		public string Relatives { get; set; }
	}
	public class Image
	{
		public string Url { get; set; }
	}
}
