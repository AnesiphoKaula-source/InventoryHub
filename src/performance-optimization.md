Performance Optimization
Challenges
Slow API responses
Repeated API requests
Excessive resource usage
Improvements
Async Requests
var products = await _productService.GetProductsAsync();
HttpClient Reuse
builder.Services.AddScoped<ProductService>();
Caching
Implemented caching for frequently accessed inventory data.

Query Optimization
Reduced unnecessary database calls and selected only required data.

Copilot Contribution
Microsoft Copilot recommended asynchronous operations, caching, and HttpClient reuse for improved performance.

Outcome
Faster API responses and reduced server load.
<img width="1222" height="2268" alt="image" src="https://github.com/user-attachments/assets/286d3668-0c5c-4fdc-8884-7923ab3261d7" />
