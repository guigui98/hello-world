using System;

namespace PlayWithTypes
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");

			Console.WriteLine("Function FACT :");
			Console.WriteLine ("enter a number : ");
			string n=Console.ReadLine();
			Console.WriteLine("The result is : ");
			Console.WriteLine (Fact (Int32.Parse(n)));

			Console.WriteLine("Function POW :");
			Console.WriteLine ("enter a number ");
			string x=Console.ReadLine();
			Console.WriteLine("Enter a power : ");
			string y=Console.ReadLine();
			Console.WriteLine("The result is : ");
			Console.WriteLine (Pow(Int32.Parse(x),Int32.Parse(y)));

			Console.WriteLine("Function HELLO : ");
			Console.WriteLine ("enter a sentence : ");
			string name = Console.ReadLine ();
			Console.WriteLine("The result is : ");
			Helloname (name);

			Console.WriteLine ("Function EvenOdd ");
			Console.WriteLine ("enter a number : ");
			string a=Console.ReadLine();
			Console.WriteLine("The result is : ");
			EvenOdd (Int32.Parse (a));

			Console.WriteLine ("Function DegToRad : ");
			Console.WriteLine ("enter a number : ");
			string b=Console.ReadLine();
			Console.WriteLine("The result is : ");
			Console.WriteLine (DegToRad(Int32.Parse(b)));

			Console.WriteLine ("Function RadToDeg : ");
			Console.WriteLine ("enter a number ");
			string c=Console.ReadLine();
			Console.WriteLine("The result is : ");
			Console.WriteLine (RadToDeg(float.Parse(c)));








		}
		public static int Fact( int n)
		{

			if (n < 0)
			{
				return -1;
			}
			if (n == 0) {
				return 1;
			} 
			else 
			{
				return n * Fact (n - 1);
			}

		}
		public static int Pow (int x, int y)
		{
			if (y==0)
			{
				return 1;
			}
			else
			{
				return x*Pow(x,y-1);
	        }
		}
		public static void Helloname (string name)
		{
			
			Console.WriteLine ("HELLO " + name+"!");
		}
		public static void EvenOdd (int a)
		{
			if (a % 2 != 0) {
				Console.WriteLine (a + " is odd ");
			} else {
				Console.WriteLine (a + " is even ");
			}	


		}
		public static float DegToRad(float b)
		{
			b = (float)((b * Math.PI) / 180);
			return b;
		}
		public static float RadToDeg(float c)
		{
			c = (float)((c * 180)/ Math.PI);
			return c;
		}
			
			
}



			 
}
		