3.	public class User
4.	{
5.	    public Guid ID { get; set; } = Guid.NewGuid();
6.	    public string FirstName { get; set; }
7.	    public string LastName { get; set; }
21.	    public string FullName
22.	        => string.Format(
23.	            "{0} {1}",
24.	            LastName,
25.	            FirstName);
26.	    
27.	}
18.		    

