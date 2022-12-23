using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using QuanLyBanDienThoai.Models;

namespace QuanLyBanDienThoai.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<QuanLyBanDienThoai.Models.Product> Product { get; set; }
        public DbSet<QuanLyBanDienThoai.Models.BillDetail> BillDetail { get; set; }
        public DbSet<QuanLyBanDienThoai.Models.Bill> Bill { get; set; }
    }
}
