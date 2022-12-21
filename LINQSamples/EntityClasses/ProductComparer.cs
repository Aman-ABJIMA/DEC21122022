using System.Collections.Generic;

namespace LINQSamples.EntityClasses
{
    public class ProductComparer : EqualityComparer<Product>
    {
        public override bool Equals(Product x,Product y)
        {
        //return (x.ProductID== y.ProductID);
        return (x.ProductID== y.ProductID&&
                x.Name == y.Name&&
                x.Color==y.Color&&
                x.Size==y.Size&&
                x.ListPrice==y.ListPrice&&
                x.StandardCost==y.StandardCost);
        }
        public override int GetHashCode(Product obj)
        {
            return obj.ProductID.GetHashCode();
        }

    }
}