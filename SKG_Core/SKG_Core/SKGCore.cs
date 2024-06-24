namespace SKG_Core
{
    // This SKGCore library defines the structures of the basic elements
    // Composition into domain ontology graphs is in KGGraphs
    // Storage is in SKGStore
    // KGAPI gives remote access to graphs and ellements
    //    CRUD for elements https://simpleknowledgegraph/org/[domain|class|proporty|relation]
    //    CRUD for graph nodes and edges
    public abstract class SKGBase
    {
        protected SKGBase()
        {
            Name = String.Empty;
        }
        public string Name { get; protected set; }
        public Guid UID { get; protected set; }
    }
    public class SKGDomain : SKGBase
    {
        public SKGDomain() { }
        public SKGDomain(string name) 
        { 
            Name = name;
            UID = SKGDomain.MakeSKGUID(name);
        }
        public static Guid MakeSKGUID(string name)
        {
            return Guid.NewGuid();
        }

    }
    public class SKGClass : SKGBase 
    {
        public Guid KGDomain { get; set; }
        public SKGClass(Guid domain)
        {
            KGDomain = domain;
        }  
        public List<SKGProperty> Properties { get; set; } = new List<SKGProperty>();
    }
    public class SKGProperty : SKGBase 
    {
        public Guid KGDomain { get; set; }
        public SKGProperty(Guid domain)
        {
            KGDomain = domain;
        }
    }
    public class SKGRelationship : SKGBase
    {
        public Guid SKGDomain { get; set; }
        public SKGRelationship(Guid domain)
        {
            SKGDomain = domain;
        }
        public Guid? From { get; set; } = null;
        public Guid? To { get; set; } = null;
    }
}
