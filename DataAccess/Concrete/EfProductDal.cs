using DataAccess.Abstract;

namespace DataAccess.Concrete;

public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
{

}
