**## Mid-Level .NET Developer (Web API) Assessment**

### **Instructions:**
- The assessment is designed to be completed within **1-2 hours**.
- You can use any online documentation, but **do not copy-paste code** from external sources.
- Submit your solution as a **GitHub repository**.

---

## Practical Coding Task (60-90 min)**

### **Task:** Build a simple Web API for managing wines in a collection.

### **Requirements:**

- Create an ASP.NET Core Web API project.
- Use **Entity Framework Core** with an **in-memory database** (or SQLite) for data persistence.
- Implement a **WinesController** with CRUD operations.
- Implement **DTOs** to avoid exposing entity models directly.
- Use **FluentValidation** for request validation.
- Implement a **global exception handler** for error handling.
- Use **AutoMapper** to map DTOs to entities.
- Implement **logging** using built-in ASP.NET Core logging.
- Secure one endpoint using **JWT authentication** (mock authentication is acceptable).

---

### **Entities:**
```csharp
public class Wine
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int Year { get; set; }
    public string Brand { get; set; }
    public string Type { get; set; }
}
```

### **DTOs:**
```csharp
public class WineDto
{
    public string Title { get; set; }
    public int Year { get; set; }
    public string Brand { get; set; }
    public string Type { get; set; }
}
```

---

### **API Endpoints:**

| HTTP Method | Endpoint         | Description |
|------------|----------------|-------------|
| GET        | /api/wines      | Get all wines |
| GET        | /api/wines/{id} | Get a wine by ID |
| POST       | /api/wines      | Add a new wine |
| PUT        | /api/wines/{id} | Update a wine |
| DELETE     | /api/wines/{id} | Delete a wine |

---

### **Bonus (Optional, if time permits):**
- Implement **Unit Tests** for the controller using **xUnit** and **Moq**.
- Add **Swagger (Swashbuckle)** for API documentation.

---

### **Submission Guidelines:**

- Ensure the project builds and runs correctly.
- Provide clear instructions in a `README.md` file.
- Push your solution to a **public repository** and share the link.

Good luck!