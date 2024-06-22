using Microsoft.EntityFrameworkCore;

namespace EmptyCoreWebApplication.Models
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Product> Products {get;set;}

        public RepositoryContext(DbContextOptions<RepositoryContext> options)
            : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
                .HasData
                (
                new Product() { ProductId=1,ProductName="English 101",Price=500, Description = "English 101: Introduction to Language Learning is designed for students who are beginning their journey in mastering the English language. This course focuses on developing foundational skills in reading, writing, listening, and speaking." },
                new Product() { ProductId = 2, ProductName = "English 201", Price = 600, Description= "English 201: Intermediate Language Learning is designed for students who have a foundational knowledge of English and seek to further develop their language skills. This course focuses on enhancing proficiency in reading, writing, listening, and speaking at an intermediate level." },
                new Product() { ProductId = 3, ProductName = "English 301", Price = 800, Description= "English 301: Advanced Language Learning is designed for students who have an intermediate proficiency in English and aim to achieve advanced language skills. This course focuses on refining and mastering the intricacies of English in reading, writing, listening, and speaking." },
                new Product() { ProductId = 4, ProductName = "English 401", Price = 1000, Description= "English 401: Proficient Language Mastery is designed for students who have advanced proficiency in English and aspire to reach a near-native level of fluency. This course focuses on perfecting language skills in reading, writing, listening, and speaking through engagement with highly complex texts and sophisticated communication activities." },
                new Product() { ProductId = 5, ProductName = "German 101", Price = 500, Description= "German 101: Introduction to German Language is designed for beginners eager to start learning German. This course focuses on building foundational skills in reading, writing, listening, and speaking German. Students will learn basic vocabulary, essential grammar, and key phrases for everyday communication." },
				new Product() { ProductId = 6, ProductName = "German 201", Price = 600, Description= "German 201: Intermediate German Language is designed for students who have a basic understanding of German and wish to enhance their proficiency. This course focuses on expanding vocabulary, refining grammar, and improving skills in reading, writing, listening, and speaking at an intermediate level." },
				new Product() { ProductId = 7, ProductName = "German 301", Price = 800, Description= "German 301: Advanced German Language is designed for students who have intermediate proficiency in German and aim to reach a higher level of fluency. This course focuses on refining advanced language skills in reading, writing, listening, and speaking. " },
				new Product() { ProductId = 8, ProductName = "German 401", Price = 1000, Description= "German 401: Proficient German Language Mastery is designed for students who have advanced proficiency in German and strive for near-native fluency. This course focuses on perfecting language skills in reading, writing, listening, and speaking through engagement with highly complex texts and sophisticated communication activities." }
				);
        }
    }
}
