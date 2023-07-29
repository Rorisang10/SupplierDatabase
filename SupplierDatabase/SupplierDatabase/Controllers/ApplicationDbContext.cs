internal class ApplicationDbContext
{
    public object Suppliers { get; internal set; }

    internal void Dispose()
    {
        throw new NotImplementedException();
    }

    internal void SaveChanges()
    {
        throw new NotImplementedException();
    }
}