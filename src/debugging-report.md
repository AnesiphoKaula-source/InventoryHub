Debugging Report
Issue
The front-end failed to retrieve product data from the API.

Error Message
404 Not Found

Root Cause
Incorrect API endpoint was used.

Incorrect:

api/product
Correct:

api/products
Resolution
Fixed API route.
Updated HttpClient configuration.
Corrected serialization settings.
Added exception handling.
Copilot Assistance
Microsoft Copilot identified routing inconsistencies and proposed corrective actions.
<img width="775" height="2268" alt="image" src="https://github.com/user-attachments/assets/1438ecc0-418c-470b-9f8e-1213a48c1f7d" />
