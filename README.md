# 📝 Blog App (ASP.NET Core Razor Pages)

A simple **blog web application** built with **ASP.NET Core Razor Pages**, **Entity Framework Core**, and **SQL Server**.
This project allows users to create, edit, view, and delete blog posts.
It was developed as part of my learning journey into ASP.NET Core fundamentals, focusing on Razor Pages, EF Core, and CRUD operations.

[![.NET 8.0](https://img.shields.io/badge/.NET-8.0-blue.svg)](https://dotnet.microsoft.com/)
[![Entity Framework Core](https://img.shields.io/badge/EF%20Core-8.0-green.svg)](https://learn.microsoft.com/en-us/ef/core/)
[![SQL Server](https://img.shields.io/badge/SQL%20Server-2022-red.svg)](https://www.microsoft.com/sql-server)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)


## 🚀 Features

* Create new blog posts
* Edit existing blog posts
* View post details
* Delete posts with confirmation
* Store data in a **SQL Server** database using **Entity Framework Core**
* Clean and minimal **Razor Pages** layout


## 🛠️ Technologies Used

* **ASP.NET Core 8.0** (Razor Pages)
* **Entity Framework Core (Code-First + Migrations)**
* **SQL Server 2022 / LocalDB**
* **Bootstrap 5** for UI styling


## 📸 Snapshots / Screenshots

- Home / List of Posts
 
  <img width="1343" height="2010" alt="index" src="https://github.com/user-attachments/assets/43ff43cf-85d5-40bc-adaa-69e88e0b2f15" />
  
- Create Post Page
  
  <img width="1343" height="1158" alt="create" src="https://github.com/user-attachments/assets/a149c053-8335-4d38-94dd-bee1be1fc34a" />
  
- Read Post Page
  
  <img width="1343" height="1699" alt="read" src="https://github.com/user-attachments/assets/0bc0616a-7adc-497d-bd56-7a31edcbc2fc" />
  
- Edit Post Page
  
  <img width="1343" height="1378" alt="update" src="https://github.com/user-attachments/assets/7d23c422-5f26-4564-8d4b-3b46b0c574b0" />
  
- Delete Post Page
  
<img width="1343" height="1644" alt="delete" src="https://github.com/user-attachments/assets/74b14bf3-c865-4ecc-92dd-73c640a99954" />

## ⚙️ Installation & Setup

1. **Clone the repository**

   ```bash
   git clone https://github.com/Alireza-Jafari-tech/Blog-app-with-ASP.NET-Core-Razor-Pages.git
   cd Blog-app-with-ASP.NET-Core-Razor-Pages
   ```

2. **Update the connection string** in `appsettings.json`:

   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=localhost;Database=BlogAppDb;Trusted_Connection=True;TrustServerCertificate=True"
   }
   ```

3. **Apply migrations and create the database**

   ```bash
   dotnet ef database update
   ```

4. **Run the application**

   ```bash
   dotnet run
   ```

Then open the app in your browser:
👉 [http://localhost:7000](http://localhost:7000)


## 📂 Project Structure

```bash
/Pages
 ├── Index.cshtml           → List of blog posts
 ├── Create.cshtml          → Create new post
 ├── Edit.cshtml            → Edit existing post
 ├── Delete.cshtml          → Delete confirmation
 └── Details.cshtml         → View full post details

/Data
 └── AppDbContext.cs        → EF Core database context

/Models
 └── Post.cs                → Blog Post entity model
```


## 🎯 Learning Goals

* Practice Razor Pages fundamentals
* Understand data binding and validation
* Implement CRUD with EF Core
* Configure and use SQL Server database
* Work with layouts and partials in Razor Pages


## 🧑‍💻 Usage

* Use the **Create** page to add new posts
* Use the **Index** page to browse all posts
* Use **Edit** to modify existing posts
* Use **Delete** to remove posts from the database


## 📝 License

This project is licensed under the **MIT License**.
See the [LICENSE](LICENSE) file for more details.


## 🤝 Contributing

This project is for learning purposes, but contributions are always welcome!
Feel free to **fork** the repo, **open issues**, or **submit pull requests**.


Would you like me to add some **example screenshots placeholders** and **badges for EF, SQL, and Razor Pages** like in your Book Catalog README (with matching image tags and alt texts)?
I can also write a **short project description paragraph** for the top of the GitHub page (the one shown under the repo title).
