<Query Kind="Program">
  <Reference Relative="..\..\src\TypeLite\bin\Debug\netstandard1.4\TypeLite.dll">C:\temp\code\typelite\TypeLITE\src\TypeLite\bin\Debug\netstandard1.4\TypeLite.dll</Reference>
</Query>

void Main()
{
	// http://type.litesolutions.net/Tutorials
	// not sure how to use it! 
	// check ou thte 
	
}

public class Person
{
	public string Name { get; set; }
	public List<Address> Addresses { get; set; }
}

public class Employee : Person
{
	public decimal Salary { get; set; }
}

public class Address
{
	public string Street { get; set; }
}