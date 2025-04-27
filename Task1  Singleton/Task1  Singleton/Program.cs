namespace Singleton;

class ConfigurationManager
{
	public string Theme { get; set;}
	public string Language { get; set; }
	public double Version { get; set; }
	private static ConfigurationManager _instance;

	private ConfigurationManager() { }


	public static ConfigurationManager GetInstance()
	{
		if(_instance == null)
		{
			_instance = new ConfigurationManager();
		}
		return _instance;
	}
}

class Program 
{
    public static void Main(string[] args)
    {
		ConfigurationManager instance = ConfigurationManager.GetInstance();

	}
}