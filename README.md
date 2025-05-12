# RJO'Brien Backend Tech Assessment – C# .NET

Clone the repo, you'll find an ASP.NET Core 9 Web API and a xUnit project.

Create an HTTP endpoint that:

1. Accepts a GET request with three optional query parameters to filter products or
   highlight some words (separated by commas in the query parameter) in their
   description:  
   Example:  
   `/filter?minprice=5&maxprice=20&size=medium&highlight=green,blue`

2. Reads the list of all products from the URL (think of this as the database):  
   https://pastebin.com/raw/JucRNpWs

3. Design the endpoint response so that it contains (in JSON format):
   - All products if the request has no parameters
   - A filtered subset of products if the request has filter parameters
   - A filter object to contain:
       - The minimum and maximum price of all products in the source URL
       - An array of strings to contain all sizes of all products in the source URL
       - A string array of size ten to contain the most common words in the product descriptions, excluding the most common five
   - Add HTML `<em>` tags to returned product descriptions to highlight the words provided in the _highlight_ parameter  
     Example: `"These trousers make a perfect pair with <em>green</em> or <em>blue</em> shirts."`

---

### What we will look for

- Clean, readable, easy-to-understand code
- Performance, scalability, and security
- Unit tests
- Dependency injection
- Appropriate logging
- Documentation for the users of your API

---

### Hints

- You do not need to implement authorization but look for other potential security vulnerabilities
- Feel free to use any open-source libraries
