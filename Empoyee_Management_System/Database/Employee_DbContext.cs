using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Empoyee_Management_System.Database;

public partial class Employee_DbContext : DbContext
{
    public Employee_DbContext(DbContextOptions<Employee_DbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Attendance> Attendances { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Payroll> Payrolls { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Attendance>(entity =>
        {
            entity.ToTable("ATTENDANCE");

            entity.Property(e => e.AttendanceId).HasColumnName("ATTENDANCE_ID");
            entity.Property(e => e.AttendanceDate)
                .HasColumnType("datetime")
                .HasColumnName("ATTENDANCE_DATE");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.EmployeeId).HasColumnName("EMPLOYEE_ID");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STATUS");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.ToTable("DEPARTMENT");

            entity.Property(e => e.DepartmentId).HasColumnName("DEPARTMENT_ID");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.DepartmentName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DEPARTMENT_NAME");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.ToTable("EMPLOYEE");

            entity.Property(e => e.EmployeeId).HasColumnName("EMPLOYEE_ID");
            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADDRESS");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.DateOfBirth)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DATE_OF_BIRTH");
            entity.Property(e => e.DepartmentId).HasColumnName("DEPARTMENT_ID");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.FirstName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("FIRST_NAME");
            entity.Property(e => e.Gender)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GENDER");
            entity.Property(e => e.JoiningDate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("JOINING_DATE");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LAST_NAME");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PHONE_NUMBER");
        });

        modelBuilder.Entity<Payroll>(entity =>
        {
            entity.ToTable("PAYROLL");

            entity.Property(e => e.PayrollId).HasColumnName("PAYROLL_ID");
            entity.Property(e => e.BasicSalary).HasColumnName("BASIC_SALARY");
            entity.Property(e => e.Bonus).HasColumnName("BONUS");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.Deduction).HasColumnName("DEDUCTION");
            entity.Property(e => e.EmployeeId).HasColumnName("EMPLOYEE_ID");
            entity.Property(e => e.NetPay)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("NET_PAY");
            entity.Property(e => e.Overtime).HasColumnName("OVERTIME");
            entity.Property(e => e.PayDate)
                .HasColumnType("datetime")
                .HasColumnName("PAY_DATE");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("PAYMENT_METHOD");
            entity.Property(e => e.Tax)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("TAX");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
