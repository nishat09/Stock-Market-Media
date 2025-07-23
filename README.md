Stock-Market-Media
A full-stack social media–style web application built to facilitate discussions around stock tickers. Users can register, log in, and comment on individual stocks. Designed to explore real-world application development using C# and .NET.

🔧 Features (in progress):

Secure user authentication with ASP.NET Core Identity

Real-time commenting on individual stock symbols

React-based dynamic UI

Planned: stock ticker integration, user profile pages, threaded replies

🛠 Tech Stack:

Frontend: React

Backend: C#, ASP.NET Core Web API

Database: SQL Server (via SQL Server Management Studio)

Other Tools: Entity Framework Core, Postman, Docker (planned), Git

## 🖥️ How to Run Locally

### 🔧 Prerequisites

- [.NET 6 or 7 SDK](https://dotnet.microsoft.com/download)
- [Node.js & npm](https://nodejs.org/)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- SQL Server Management Studio (SSMS)
- Git

---

### 📦 Backend Setup (ASP.NET Core)

1. Clone the repository:
   ```bash
   git clone https://github.com/nishat09/Stock-Market-Media.git
   cd Stock-Market-Media
Navigate to the backend directory:

bash
Copy
Edit
cd api
Set up the connection string in appsettings.json:

json
Copy
Edit
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=StockMediaDb;Trusted_Connection=True;MultipleActiveResultSets=true"
}
Apply EF Core migrations:

bash
Copy
Edit
dotnet ef database update
Run the API:

bash
Copy
Edit
dotnet watch run
💻 Frontend Setup (React)
Open a new terminal and navigate to the frontend:

bash
Copy
Edit
cd ../client
Install dependencies:

bash
Copy
Edit
npm install
Start the development server:

bash
Copy
Edit
npm run dev
📌 Status
🚧 This project is in active development. Contributions, suggestions, and improvements are welcome!

📄 License
This project is open-sourced under the MIT License.
