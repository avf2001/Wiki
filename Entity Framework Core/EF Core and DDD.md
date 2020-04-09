DbContextOptionsBuilder

.UseLoggerFactory

.EnableSensitiveDataLogging

## DbContext encapsulation
Initialize DbContext with connection string instead of DbContextOptions

## Model
Make setters private
Use contructor to set properties
Class need to have private parameterless constructor

## Many-to-one relationship
Prefer navigation properties over IDs
```csharp
modelBuilder.Entity<Student>(x => {
x.HasOne(p => p.FavouriteCourse).WithMany();
});

modelBuilder.Entity<Course>(x => {
x.ToTable("Course").HasKey(k => k.Id);
});
```
Prefer lazy loading to eager loading:
- helps to avoid partitially initialized entities;
- more performant in some scenarious.

To use lazy loading:
1. install package Microsoft.EntityFrameworkCore.Proxies
2. optionsBuilder.UseLazyLoadingProxies()
3. set model properties as virtual, class should not be sealed, class have to have protected default constructor
```csharp
public abstract class Entity
{
  public long Id { get; }
  
  public override bool Equals(object obj)
  {
    if (!(obj is Entity other)) return false;
    
    if (ReferenceEquals(this, other)) return true;
    
    if (GetRealType() != other.GetRealType()) return false;
    
    if (Id == 0 || othre.Id == 0) return false;
    
    return Id == other.Id;
  }
  
  public statuc bool operator ==(Entity a, Entity b)
  {
    if (a is null && b is null) return false;
    
    if (a is null || b is null) return false;
    
    return a.Equals(b);
  }
  
  public static bool operator !=(Entity a, Entity)
  {
    return !(a == b);
  }
  
  public override int GetHashCode()
  {
    return (GetType().ToString() + Id).GetHashCode();
  }
  
  private Type GetRealType()
  {
    Type type = GetType();
    
    if (type.ToString().Contains("Castle.Proxies.")) return type.BaseType;
    
    return type;
  }
}
```
Use Find(), not Single() or First()

## One-to-many
modelBuilder.Entity<Student>( x => {
x.HasMany(p => p.Enrollments).WithOne(p => p.Student);
});

Bad Ways:
- student.Enrollments.Add(new Enrollment(course, student, grade));
- student.Enrollments.Clear()
- student.Enrollments = null;

public class Student : Entity
{
  private readonly List<Enrollment> _enrollments = new List<Enrollment>();
  public virtual IReadOnlyList<Enrollment> Enrollments => _enrollments.ToList();
  
  public void AddEnrollment(Course course, Grade grade)
  {
    var enrollment = new Enrollment(course, this, grade);
    _enrollments.Add(enrollment);
  }
}

x.HasMany(p => p.Enrollments).WithOne(p => p.Student)
  .OnDelete(DeleteBehavior.Cascade)
  .Metadata.PrinciaplToDependent(SetPropertyAccessMode(PropertyAccessMode.Field));

public class StudentRepository
{
  public Student GetById(long studentId)
  {
    Student student = _context.Students.Find(studentId);
    
    if (student == null) return null;
    
    _context.Entry(student).Collection(x => x.Enrollments).Load();
    
    return student;
  }
}

## Working with disconnected objects
- Detached
- Unchanged
- Deleted
- Modified
- Added

_context.Students.Attach(student);
Always prefer Attach over Update or Add for new objects;

Add marks the whole aggregate as added.

The use of Update() is an anti-pattern (except for desktop applications).

## Value object
Value object has no identity. Value objects are immutable;
```csharp
using System.Collections.Generic;
using System.Text.RegularExpressions;
using CSharpFunctionalExtensions;

namespace App
{
    public class Email : ValueObject
    {
        public string Value { get; }

        private Email(string value)
        {
            Value = value;
        }

        public static Result<Email> Create(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return Result.Failure<Email>("Email should not be empty");

            email = email.Trim();

            if (email.Length > 200)
                return Result.Failure<Email>("Email is too long");

            if (!Regex.IsMatch(email, @"^(.+)@(.+)$"))
                return Result.Failure<Email>("Email is invalid");

            return Result.Success(new Email(email));
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        public static implicit operator string(Email email)
        {
            return email.Value;
        }
    }
}

x.Property(p => p.Email).HasConversion(p => p.Value, p => Email.Create(p).Value);

x.OwnsOne(...)

```
Owned entity - id is shadow property.
