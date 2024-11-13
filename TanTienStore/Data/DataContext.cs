﻿using Microsoft.EntityFrameworkCore;
using TanTienStore.Models;

namespace TanTienStore.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        public DbSet<SanPhamModel> SanPhams { get; set; }
        public DbSet<LoaiSanPhamModel> LoaiSanPhams { get; set; }
    }
}