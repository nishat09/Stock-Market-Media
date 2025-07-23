# 📈 Stock-Market-Media

A full-stack social media–style web application built to facilitate discussions around stock tickers. Users can register, log in, and comment on individual stocks. Designed to explore real-world application development using **C#**, **.NET**, and **React**.

---

## 🔧 Features (In Progress)

- 🔐 Secure user authentication with ASP.NET Core Identity  
- 💬 Real-time commenting on individual stock symbols  
- ⚛️ Dynamic and responsive UI built with React  
- 📈 Planned: stock ticker integration, user profiles, threaded replies  

---

## 🛠 Tech Stack

| Layer        | Technologies                            |
|--------------|------------------------------------------|
| **Frontend** | React                                     |
| **Backend**  | ASP.NET Core Web API, C#                 |
| **Database** | SQL Server (via SQL Server Management Studio) |
| **Tools**    | Entity Framework Core, Postman, Git, Docker (planned) |

---

## 🖥️ How to Run Locally

### 🔧 Prerequisites

- [.NET 6 or 7 SDK](https://dotnet.microsoft.com/download)
- [Node.js & npm](https://nodejs.org/)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- SQL Server Management Studio (SSMS)
- Git

---

### ⚙️ Backend Setup (ASP.NET Core)

```bash
# 1. Clone the repository
git clone https://github.com/nishat09/Stock-Market-Media.git
cd Stock-Market-Media

# 2. Navigate to the backend
cd api
```

Edit `appsettings.json` with your SQL Server connection string:
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=StockMediaDb;Trusted_Connection=True;MultipleActiveResultSets=true"
}
```

```bash
# 3. Apply migrations
dotnet ef database update

# 4. Run the API
dotnet watch run
```

---

### 💻 Frontend Setup (React)

```bash
# 1. Open a new terminal and go to the client directory
cd ../client

# 2. Install dependencies
npm install

# 3. Start the frontend
npm run dev
```

---

## 📌 Status

🚧 This project is in active development. Contributions, suggestions, and improvements are welcome!

---

## 📄 License

This project is open-sourced under the MIT License.
