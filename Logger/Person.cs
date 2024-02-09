using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger;

public record class Person : Base
{
    private string _firstName {  get; set; }
    private string _lastName {  get; set; }
    private string? _middleName { get; set; }
    private FullName FullName { get; set; }
    private Guid identity {  get; set; }
    public Person(string firstName, string lastName, string? middleName)
    {
        _firstName = firstName;
        _lastName = lastName;
        _middleName = middleName;
        FullName = new FullName(_firstName, _lastName, _middleName);
        identity = Guid.NewGuid();

    }

    public Guid id { get { return identity; } }

    public override string Name{ get { return FullName.GetFullName(); } set { Name = FullName.GetFullName();} }
}
// Implemented name implicitly as we are retuning FullName.GetFullName();