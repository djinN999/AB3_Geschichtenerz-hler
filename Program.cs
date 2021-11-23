using System;

namespace part3
{
	class Program
	{
		public static void Main(string[] args)
		{
		string name, alter, tier, hobby;
			
			Console.WriteLine("Nenne deinen Namen:  ");
			name = Console.ReadLine();
			
			Console.WriteLine("Nenne dein Alter:  ");
			alter = Console.ReadLine();
			
			Console.WriteLine("Nenne dein Lieblingstier:  ");
			tier = Console.ReadLine();
			
			Console.WriteLine("Nenne eins deiner Hobbys:  ");
			hobby = Console.ReadLine();
		
			
			Console.WriteLine("\n\nHallo {0}! Da du ja schon {1} bist, ", name , alter);
			Console.WriteLine("gehe ich davon aus, dass du schon einiges ausprobiert hast!");
			Console.WriteLine("WOW! {0}, welch ein interessantes Hobby du doch hast!", hobby);
			Console.WriteLine("Mir war sofort bewusst, dass {0} dein Lieblingstier ist!", tier);
			

			Console.ReadKey(true);
		}
	}
}