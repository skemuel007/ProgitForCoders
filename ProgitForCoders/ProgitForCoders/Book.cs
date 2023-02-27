using System;
namespace ProgitForCoders
{
	public class Book
	{
		public Book()
		{
		}

		public string Title { get; set; }
		public List<string> Authors { get; set; }
		public DateTime PublicationDate { get; set; }
	}
}

