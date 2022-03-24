using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutor_tp5
{
	internal class SayaTubeVideo
	{
		private int id;
		private string title;
		private int playCount;

		// Deklarasi konstruktor dengan title
		public SayaTubeVideo(string title)
		{
			this.title = title;
			this.id = new Random().Next(10000, 99999);
			this.playCount = 0;
		}

		// Tambahkan playCount dengan parameter add
		public void IncreasePlayCount(int add)
		{
			this.playCount += add;
		}

		// Tampilkan informasi video
		public void PrintVideoDetails()
		{
			Console.WriteLine("Id: " + id + ", Title: " + title + ", Play: " + playCount);
		}
	}
}
