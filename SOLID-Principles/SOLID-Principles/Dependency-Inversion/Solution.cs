namespace SOLID_Principles.Dependency_Inversion;

public class Solution
{
    public enum Relationship
    {
        Parent, Child, Sibling
    }

    public class Person
    {
        public string Name;
    }
    
    public interface IRelationshipBrowser
    {
        IEnumerable<Person> FindAllChildrenOf(string name);
    }
    
    //low-level module
    public class Relationships : IRelationshipBrowser
    {
        private List<(Person, Relationship, Person)> relations = new List<(Person, Relationship, Person)>();

        public void AddParentAndChild(Person parent, Person child)
        {
            //duplication of data my allow for faster access speed depending on the type of query
            relations.Add((parent, Relationship.Parent, child));
            relations.Add((child, Relationship.Child, parent));
        }

        public IEnumerable<Person> FindAllChildrenOf(string name)
        {
            foreach (var r in relations.Where(
                         x=> x.Item1.Name == name && 
                             x.Item2 == Relationship.Parent))
            {
                yield return r.Item3;
            }
        }
    }
}