namespace KnowledgeCheck2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("How many records do you want to add? ");
			var numberOfRecords = int.Parse(Console.ReadLine());

			var recordList = new List<Car>();
			for (int i = 0; i < numberOfRecords; i++)
			{
				// In this loop, populate the object's properties using Console.ReadLine()
				
				Console.WriteLine($"Enter details for Car {i}");
				var myClass = new Car();

				//Console.WriteLine("Enter the value for ");
				Console.WriteLine("Enter the name:");
				myClass.Name = Console.ReadLine();

				Console.WriteLine("Enter the year:");
				myClass.Year = int.Parse(Console.ReadLine());

				Console.WriteLine("Enter the cost:");
				myClass.Cost = float.Parse(Console.ReadLine());

				recordList.Add(myClass);

				Console.WriteLine();
			}

			// Print out the list of records using Console.WriteLine()

			for (int i = 0;i < numberOfRecords;i++)
			{
				Console.WriteLine($"Car {i} Details");
				Console.WriteLine($"Name is: {recordList[i].Name}");
				Console.WriteLine($"Year is: {recordList[i].Year}");
				Console.WriteLine($"Cost is: ${recordList[i].Cost}");
				Console.WriteLine();
			}
		}
	}
}