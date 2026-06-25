using System;

public class SearchOperations
{
    // Linear Search
    public static Product? LinearSearch(Product[] products, string name)
    {
        foreach (Product product in products)
        {
            if (product.ProductName.Equals(name,
                StringComparison.OrdinalIgnoreCase))
            {
                return product;
            }
        }

        return null;
    }

    // Binary Search
    public static Product? BinarySearch(Product[] products, string name)
    {
        int left = 0;
        int right = products.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            int result = string.Compare(
                products[mid].ProductName,
                name,
                true);

            if (result == 0)
                return products[mid];

            if (result < 0)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return null;
    }
}