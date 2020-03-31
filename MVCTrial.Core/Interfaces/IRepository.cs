namespace MVCTrial_Core.Interfaces
{

    interface IRepository<TEntity> where TEntity: class, IEntity
    {
        void Create();
        void Read(TEntity entity);
        void Read(int Id);
        void Update(TEntity entity);
        void Update(int Id);
        void Delete(TEntity entity);
        void Delete(int Id);
    }
}