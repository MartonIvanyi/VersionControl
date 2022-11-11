3.	public class User
4.	{
5.	    public Guid ID { get; set; } = Guid.NewGuid();
6.	    public string FirstName { get; set; }
7.	    public string LastName { get; set; }
8.	    public string FullName
9.	    {
10.	        get
11.	        {
12.	            return string.Format(
13.	                "{0} {1}", 
14.	                LastName,
15.	                FirstName);
16.	        }
17.	    }
18.	
19.	    // Ugyanaz a FullName property kompaktabb formában is írható
20.	    /*
21.	    public string FullName
22.	        => string.Format(
23.	            "{0} {1}",
24.	            LastName,
25.	            FirstName);
26.	    */
27.	}
