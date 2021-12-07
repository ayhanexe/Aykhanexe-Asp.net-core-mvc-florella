﻿using asp.net_core_empty_task.Models;
using Microsoft.EntityFrameworkCore;

namespace asp.net_core_empty_task.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Slider> Slider { get; set; }
        public DbSet<SliderItem> SliderItem { get; set; }
        public DbSet<VideoSection> VideoSections { get; set; }
        public DbSet<VideoSectionItem> VideoSectionsItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Subscription> Subscription { get; set; }
        public DbSet<Experts> Experts { get; set; }
        public DbSet<ExpertItem> ExpertItems { get; set; }
    }
}