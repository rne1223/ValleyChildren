using UnityEngine;
using UnityEditor;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Database
{
    static string[] getPerson(string username)
	{
		string filePath = "Assets/Database/Data.csv";

		List<string> lines = File.ReadAllLines(filePath).ToList();

        foreach (var line in lines)
		{
            string[] person = line.Split(',');

            if (person[3] == username)
			{
				return person;
			}
		}

		return null;
	}

    static void addPerson(string[] person)
	{
		string filePath = "Assets/Database/Data.csv";

		List<string> lines = File.ReadAllLines(filePath).ToList();

		lines.Add($"{person[0]},{person[1]},{person[2]},{person[3]},{person[4]},{person[5]}");

		File.WriteAllLines(filePath, lines);
	}

}