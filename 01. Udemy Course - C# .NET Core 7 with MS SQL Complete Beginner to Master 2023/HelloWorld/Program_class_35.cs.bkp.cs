using System;
using System.Data;
using System.Globalization;
using System.Text.RegularExpressions;
using HelloWorld.Models;
using Microsoft.Data.SqlClient;
using Dapper;
using HelloWorld.Data;

namespace HelloWorld
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DataContextDapper dapper = new DataContextDapper();

			DateTime rightNow = dapper.LoadDataSingle<DateTime>("SELECT GETDATE()");
			Console.WriteLine(rightNow);

			Computer myComputer = new Computer()
			{
				Motherboard = "Z690",
				HasWifi = true,
				HasLTE = false,
				ReleaseDate = DateTime.Now,
				Price = 943.87m,
				VideoCard = "RTX 2060"
			};
			string sql = @"INSERT INTO TutorialAppSchema.Computer (
				Motherboard,
				HasWifi,
				HasLTE,
				ReleaseDate,
				Price,
				VideoCard
			) VALUES ('" + myComputer.Motherboard
					+ "','" + myComputer.HasWifi
					+ "','" + myComputer.HasLTE
					+ "','" + myComputer.ReleaseDate.ToString("yyyy-MM-dd")
					+ "','" + myComputer.Price.ToString("0.00", CultureInfo.InvariantCulture)
					+ "','" + myComputer.VideoCard
			+ "')";
			Console.WriteLine(sql);

			// int result = dapper.ExecuteSqlWithRowCount(sql);
			bool result = dapper.ExecuteSql(sql);
			Console.WriteLine(result);

			string sqlSelect = @"
				SELECT 
					Computer.ComputerId,
					Computer.Motherboard,
					Computer.HasWifi,
					Computer.HasLTE,
					Computer.ReleaseDate,
					Computer.Price,
					Computer.VideoCard
				FROM TutorialAppSchema.Computer";
			IEnumerable<Computer> computers = dapper.LoadData<Computer>(sqlSelect);

			Console.WriteLine("'ComputerId','Motherboard','HasWifi','HasLTE','ReleaseDate','Price','VideoCard'");
			foreach (Computer singleComputer in computers)
			{
				Console.WriteLine("'" + myComputer.Motherboard
					+ "','" + singleComputer.HasWifi
					+ "','" + singleComputer.HasLTE
					+ "','" + singleComputer.ReleaseDate.ToString("yyyy-MM-dd")
					+ "','" + singleComputer.Price.ToString("0.00", CultureInfo.InvariantCulture)
					+ "','" + singleComputer.VideoCard
				+ "'");
			}
		}
	}
}
