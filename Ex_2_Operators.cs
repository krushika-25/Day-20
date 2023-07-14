using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace MVCConApp
{
	internal class Ex_2_Operators
	{
		static void Main(string[] args)
		{
			Console.WriteLine(&quot; Enter Num 1 & quot;);
			float n1 = float.Parse(Console.ReadLine());
			Console.WriteLine(&quot; Enter Num 2 & quot;);
			float n2 = float.Parse(Console.ReadLine());
			Console.WriteLine(&quot; Menu: 1.Add 2.Sub 3.Mul 4.Div & quot;);
			Console.WriteLine(&quot; Enter Your Choice & quot;);
			int c = int.Parse(Console.ReadLine());
			switch (c)
			{
				case 1:
					Console.WriteLine(&quot; Ans add is &quot; +(n1 + n2));
					break;
				case 2:
					Console.WriteLine(&quot; Ans sub is &quot; +(n1 - n2));
					break;
				case 3:

					Console.WriteLine(&quot; Ans mul is &quot; +(n1 * n2));
					break;
				case 4:
					Console.WriteLine(&quot; Ans mul is &quot; +(n1 / n2).ToString());
					break;
				Default: Console.WriteLine(&quot; Wrong Choice:::&quot;);

			}
		}
	}
}
