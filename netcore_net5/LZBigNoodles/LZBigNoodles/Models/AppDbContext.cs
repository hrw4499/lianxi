using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LZBigNoodles.Models
{
    //引导数据（DbContext是域或实体类与数据库之间的桥梁）
    public class AppDbContext:DbContext
    {
        //构造函数参数（依赖注入上下文）
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        //
       public DbSet<Noodle> Noodles { get; set; }
       public DbSet<Feedback> Feedbacks { get; set; }
    }
}
