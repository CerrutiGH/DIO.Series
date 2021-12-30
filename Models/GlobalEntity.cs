namespace DIO.Series
{
    public abstract class GlobalEntity
    {
        public int Id {get; protected set;}
        public bool IsDeleted {get; protected set;} = false;
    }
}