using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCConApp
{
	internal class Ex_1_Welcome
	{
		static void Main(string[] args)
		{
			Console.WriteLine(&quot; Enter Your Name & quot;);
			string UserName = Console.ReadLine();
			Console.WriteLine(&quot; Enter Your Age & quot;);
			int age = int.Parse(Console.ReadLine());
			Console.WriteLine(&quot; Hello & quot; +UserName + &quot;,How are You ? &quot; +&quot; Age is &quot; +age.ToString());
		}
	}
}