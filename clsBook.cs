using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject1_Book_Store
{
	public class clsBook
	{
		public string sID;
		public string sBookName;
		public string sBookAuthor;
		public double dPrice;
		public string sBookDesc;
		public string sGenre;
		public string sImageName;



		public override string ToString()
		{
			return sBookName;
		}
	}
}
