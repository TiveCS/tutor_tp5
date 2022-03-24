using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutor_tp5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Demo class SayaTubeVideo
			SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – Ahmad Fathan Hanif");
			video.IncreasePlayCount(7230);
			video.PrintVideoDetails();
		}
	}
}
