namespace Mission11_Conley.Models
{
	public interface IBookRepository
	{
		public IQueryable<Book> Books { get;}
	}
}
