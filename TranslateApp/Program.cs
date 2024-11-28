namespace Translate
{
	internal class Translate
	{
		static void Main(string[] Args)
		{
			const string mainPath = "C:\\Users\\Tsotne\\OneDrive\\Desktop\\ItStepAcademyProjects\\TranslateApp\\Translate DB\\";
			string EN_GEO_Path = Path.Combine(mainPath, "En-Geo.txt");
			var test = File.ReadAllLines(EN_GEO_Path);
			test.ToList().ForEach(x => Console.WriteLine(x));
		}
	}
}