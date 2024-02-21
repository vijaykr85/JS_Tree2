using Microsoft.EntityFrameworkCore;

namespace JS_Tree2.Models
{
    public class TreeContext:DbContext
    {
        public TreeContext(DbContextOptions options): base(options) 
        {
            
        }
        public DbSet<TreeViewNode> trees { get; set; }
    }
}
