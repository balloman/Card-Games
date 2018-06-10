using System.Configuration;
using System.Xml;
using System;
using System.Collections.Generic;

namespace CardGames.Utils
{
	//I copy and pasted all of this and it's too hard to explain, but it basically gets the list of games from the app.config xml file
	public static class Utilities
	{
		public static class ConfigUtilities
		{
			public static Configuration OpenConfig()
			{
				return ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			}
			public static string ReadSetting(string key)
			{
				try
				{

					var appSettings = ConfigurationManager.AppSettings;
					string result = appSettings[key] ?? "Not Found";
					return result;
				}
				catch (ConfigurationErrorsException)
				{
					return ("Error reading app settings");
				}
			}
			public static List<GameElement> GetGames()
			{
				return ConfigurationManager.GetSection("Games") as List<GameElement>;
			}
		}

	}

	public class GamesListSection : IConfigurationSectionHandler
	{
		public object Create(object parent, object configContext, XmlNode section)
		{
			List<GameElement> myConfigOption = new List<GameElement>();
			foreach (XmlNode childNode in section.ChildNodes)
			{
				foreach (XmlAttribute attrib in childNode.Attributes)
				{
					myConfigOption.Add(new GameElement() { Name = attrib.Value });
				}
			}
			return myConfigOption;
		}
	}

	public class GameElement
	{
		public string Name { get; set; }
	}
}