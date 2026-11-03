Integration Notes
Objective
Create communication between the Blazor front-end and ASP.NET Core backend.

Product Service
public class ProductService
{
    private readonly HttpClient _httpClient;

    public ProductService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Product>> GetProductsAsync()
    {
        return await _httpClient.GetFromJsonAsync<List<Product>>("api/products");
    }
}
Products Controller
[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetProducts()
    {
        return Ok();
    }
}
Copilot Contribution
Microsoft Copilot generated starter integration code and suggested improvements to API communication patterns.
<img width="1753" height="2268" alt="image" src="https://github.com/user-attachments/assets/419bb75b-d8c1-45cc-a6d8-5b9d97bb5a81" />
