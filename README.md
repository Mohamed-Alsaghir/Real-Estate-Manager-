# Real Estate Manager

A C# application that manages real estate data using a layered architecture (GUI, BLL, DAL) with Entity Framework Core and LINQ.

---

## 🧩 Project Overview

This application allows users to manage real estate items (e.g., residential and commercial properties) using a structured three-layer architecture:

- **Presentation Layer (GUI)** – A Windows Forms interface that allows interaction with the system.
- **Business Logic Layer (BLL)** – Contains the core logic for data operations.
- **Data Access Layer (DAL)** – Handles database interactions using Entity Framework Core (Code First).

The project supports adding, removing, and editing properties with data stored in a local SQL database.

---

## 📁 Folder Structure
Real-Estate-Manager/
├── Ass5GUIPL/ # GUI – Windows Forms interface
├── Ass5BLL/ # Business Logic Layer
├── Ass5DAL/ # Data Access Layer (EF Core)
├── Ass5GUIPL.sln # Visual Studio solution file
├── README.md # This file



---

## 🚀 Features

- 🏠 Manage real estate data with categories, addresses, and types
- 🧠 Clean separation of concerns via layered architecture
- 💾 Data persistence using Entity Framework Core (Code First)
- 🧹 LINQ queries for filtering, grouping, and sorting
- 🎯 Easy to expand with subclasses like `Apartment`, `Hotel`, etc.

---

## ⚙️ Technologies Used

- **C# (.NET)**
- **Windows Forms**
- **Entity Framework Core**
- **LINQ**
- **LocalDB / SQL Server Express (via Visual Studio)**

---

## 🛠️ How to Run the Project

### 🧱 Prerequisites

- Visual Studio 2022 or later
- .NET SDK 6 or later
- LocalDB (comes with Visual Studio)

### ▶️ Steps

1. **Clone the repository**:
   ```bash
   git clone https://github.com/Mohamed-Alsaghir/Real-Estate-Manager-.git
