using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Program
{
	public static void Main() //Missing Main method
	{ 
	IDictionary<int, string> numberNames = new Dictionary<int, string>();//variable name should be (numberNames)
	numberNames.Add(1,"One"); //adding key/value using the Add() method
	numberNames.Add(3, "Three");//semicolon Missing
	numberNames.Add(2,"Two");
		
	foreach(KeyValuePair<int, string> kvp in numberNames)
		Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

		
		//creating a dictionary using collection-initializer syntax
		var cities = new Dictionary<string, string>(){ 
			{"India","London, Manchester, Birmingham"},// both parameter should be string
			{"Muscut","Chicago, New York, Washington"},// both parameter should be string
			{"Karnataka","Mumbai, New Delhi, Pune"}// both parameter should be string
		};
		
		foreach(var kvp in cities)
			Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);// value is not displaying

	}
}
