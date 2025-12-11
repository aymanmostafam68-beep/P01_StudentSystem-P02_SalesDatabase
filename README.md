1. How We Can Add new Index?
at the top of class using data annotation
for example :

(one column)[Index(nameof(Url), Name = "Index_Url")]  //  (Composite index) [Index(nameof(FirstName), nameof(LastName))]
public class Blog
{
 
}

-----------------------------------------

2. How We deal with inheritance processes?
the easy way to deal with inheritance is Table-per-Hierarchy (TPH)
example :
// Base class
public abstract class Vehicle
{
    public int Id { get; set; }
    public string Make { get; set; }
}

// Derived classes
public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }
}

>>> the EF will create one table Vehicles with all columns: Id, Make, NumberOfDoors, VehicleType
* override OnModelCreating method to
* configure the name and type of the discriminator column and the values that are used to identify each type in the hierarchy
* example :
* protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Vehicle>()
        .HasDiscriminator<string>("VehicleType")
        .HasValue<Car>("Car")
        .HasValue<Motorcycle>("Motorcycle");
}



