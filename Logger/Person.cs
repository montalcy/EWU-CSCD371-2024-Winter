using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger;

public record class Person : Base
{
    private string FirstName {  get; set; }
    private string LastName {  get; set; }
    private string? MiddleName { get; set; }
    private FullName FullName { get; set; }
    private Guid Identity {  get; set; }
    public Person(string firstName, string lastName, string? middleName)
    {
        FirstName = firstName;
        LastName = lastName;
        MiddleName = middleName;
        FullName = new FullName(FirstName, LastName, MiddleName);
        Identity = new Guid();

    }

    public Guid Id { get { return Identity; } }

    public override string Name{ get { return FullName.GetFullName(); } set { } }
}
// Implemented name implicitly as we are retuning FullName.GetFullName();