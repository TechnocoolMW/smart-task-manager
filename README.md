🚀 Smart Task Manager

A full-stack task management application built with:

⚙️ ASP.NET Core Web API (.NET 10)

🔐 JWT Authentication

🗄️ Entity Framework Core (SQLite)

⚛️ React Frontend

This project demonstrates full-stack development skills including authentication, RESTful APIs, database integration, and frontend-backend communication.

📌 Features
✅ Authentication

User Registration

User Login

JWT Token Generation

Password Hashing with BCrypt

✅ Task Management

Create Tasks

Update Tasks

Delete Tasks

View User-Specific Tasks

Protected Routes (JWT Required)

🏗️ Project Structure
SmartTaskManager.API/
│
├── Controllers/
│   ├── AuthController.cs
│   └── TasksController.cs
│
├── Models/
│   ├── User.cs
│   └── TaskItem.cs
│
├── Data/
│   └── AppDbContext.cs
│
├── smart-task-frontend/
│   └── React application
🔧 Backend Setup (API)
1️⃣ Navigate to backend
cd SmartTaskManager.API
2️⃣ Restore dependencies
dotnet restore
3️⃣ Run migrations
dotnet ef database update
4️⃣ Run API
dotnet run

API runs on:

http://localhost:5069
💻 Frontend Setup (React)
1️⃣ Navigate to frontend
cd smart-task-frontend
2️⃣ Install packages
npm install
3️⃣ Start app
npm start

Frontend runs on:

http://localhost:3000
🔐 API Endpoints
Register
POST /api/auth/register
Login
POST /api/auth/login
Get Tasks (Protected)
GET /api/tasks
Create Task (Protected)
POST /api/tasks
Update Task (Protected)
PUT /api/tasks/{id}
Delete Task (Protected)
DELETE /api/tasks/{id}
🛠️ Technologies Used

ASP.NET Core

Entity Framework Core

SQLite

JWT Authentication

React

Axios

📈 What This Project Demonstrates

✔ Full-stack application architecture
✔ Secure authentication implementation
✔ REST API design
✔ Database migrations
✔ Frontend-backend integration
✔ Git version control

👨‍💻 Author

Kevin Binali
Web & App Developer
