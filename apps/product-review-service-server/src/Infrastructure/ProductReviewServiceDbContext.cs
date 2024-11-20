using Microsoft.EntityFrameworkCore;

namespace ProductReviewService.Infrastructure;

public class ProductReviewServiceDbContext : DbContext
{
    public ProductReviewServiceDbContext(DbContextOptions<ProductReviewServiceDbContext> options)
        : base(options) { }
}
