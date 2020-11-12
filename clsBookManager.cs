using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace GroupProject1_Book_Store
{
	public class clsBookManager
	{
		clsBook Book;
		clsDataAccess db;
		List<clsBook> Books;

		public List<clsBook> GetBookName()
		{
			Books = new List<clsBook>();
			int value = 0;
			db = new clsDataAccess();

			string sSQLBook_Name = "SELECT * FROM Books;";
			int max = Convert.ToInt32(db.ExecuteScalarSQL("SELECT MAX(ID) FROM Books;"));
			DataSet ds;

			ds = db.ExecuteSQLStatement(sSQLBook_Name, ref value);


			for (int i = 0; i < max; i++)
			{
				Book = new clsBook();
				Book.sID = ds.Tables[0].Rows[i][0].ToString();
				Book.sBookName = ds.Tables[0].Rows[i]["Book_Name"].ToString();
				Book.sBookAuthor = ds.Tables[0].Rows[i]["Book_Author"].ToString();
				Book.dPrice = Convert.ToDouble(ds.Tables[0].Rows[i]["Book_Price"].ToString());
				Book.sGenre = ds.Tables[0].Rows[i]["Book_Genre"].ToString();
				Book.sImageName = ds.Tables[0].Rows[i]["Image_Name"].ToString();

				Books.Add(Book);

			}

			return Books;
			
		}


		public string GetBookDesc(string BookSelected)
		{
		    
			
			db = new clsDataAccess();
			 
			string sSQLBook_Name = "SELECT BooK_Desc FROM Books WHERE Book_Name = \"" + BookSelected + "\";";
			int max = Convert.ToInt32(db.ExecuteScalarSQL("SELECT MAX(ID) FROM Books;"));
			DataSet ds;

			string Book_desc = db.ExecuteScalarSQL(sSQLBook_Name);
			



			return Book_desc;

		}
		public string GetBookCost(string BookSelected)
		{


			db = new clsDataAccess();

			string sSQLBook_Name = "SELECT BooK_Price FROM Books WHERE Book_Name = \"" + BookSelected + "\";";
			int max = Convert.ToInt32(db.ExecuteScalarSQL("SELECT MAX(ID) FROM Books;"));
			DataSet ds;

			string Book_price = db.ExecuteScalarSQL(sSQLBook_Name);




			return Book_price;

		}
		public string GetBookAuth(string BookSelected)
		{


			db = new clsDataAccess();

			string sSQLBook_Name = "SELECT BooK_Author FROM Books WHERE Book_Name = \"" + BookSelected + "\";";
			int max = Convert.ToInt32(db.ExecuteScalarSQL("SELECT MAX(ID) FROM Books;"));
			DataSet ds;

			string Book_author = db.ExecuteScalarSQL(sSQLBook_Name);




			return Book_author;

		}



	}
}
