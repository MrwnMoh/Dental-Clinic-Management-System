# 🦷 Dental Clinic Management System (DCMS)

<p align="center">
  <img src="https://readme-typing-svg.herokuapp.com?font=Fira+Code&size=28&pause=1000&color=2563EB&width=800&lines=Dental+Clinic+Management+System;C%23+WinForms+Project;3-Tier+Architecture;Secure+Desktop+Solution" alt="Typing Animation" />
</p>

<p align="center">
  <img src="https://img.shields.io/badge/C%23-Project-purple?style=for-the-badge&logo=c-sharp" alt="C#">
  <img src="https://img.shields.io/badge/.NET-Windows+Forms-blue?style=for-the-badge&logo=.net" alt=".NET WinForms">
  <img src="https://img.shields.io/badge/DB-SQL--Server-red?style=for-the-badge&logo=microsoft-sql-server" alt="SQL Server">
  <img src="https://img.shields.io/badge/Security-Windows+DPAPI-10B981?style=for-the-badge" alt="Windows DPAPI">
  <img src="https://img.shields.io/badge/Architecture-3--Tier-green?style=for-the-badge" alt="Architecture">
</p>

---

> [!CAUTION]
> **Important Note:** This project is for **Showcase Only**. Cloning the repository will not work out of the box because it is tightly coupled with a local SQL Server database, specific infrastructure setups, and local connection strings. It is shared here to demonstrate **Advanced System Architecture, Premium UI/UX Design, and Complex Healthcare Business Logic.**

---

## 📝 Introduction
**Dental Clinic Management System (DCMS)** is a secure, organized, and user-friendly desktop application developed using **C# Windows Forms** and **SQL Server**. The project is built using a **3-Tier Architecture** and **Object-Oriented Programming (OOP)** principles, ensuring a clear separation of concerns, high code maintainability, and advanced data security handler implementations.

The system completely automates daily clinic operations, encompassing secure user authentication pipelines, digital patient records management, staff directories, comprehensive appointment scheduling, and automated billing processors.

---

## 🖼️ Project Screenshots

### 🔐 Security & Identity Setup
| 🔑 Secure Login Interface | 📊 Interactive Dashboard Overview |
| :---: | :---: |
| <img src="https://github.com/MrwnMoh/DCMS/blob/main/Pics/Login.png" width="450" alt="Login Screen" /> | <img src="https://github.com/MrwnMoh/DCMS/blob/main/Pics/Dashboard.png" width="450" alt="Dashboard" /> |

### 🗂️ Core Registers & Master Data
| 👥 People Management Grid | 🩺 Patients Management Ledger |
| :---: | :---: |
| <img src="https://github.com/MrwnMoh/DCMS/blob/main/Pics/People%20Management.png" width="450" alt="People Management" /> | <img src="https://github.com/MrwnMoh/DCMS/blob/main/Pics/Patients.png" width="450" alt="Patients Management" /> |

### 👤 User Roles & Clinical Staff
| 🔒 User Accounts Control | 👨‍⚕️ Doctors Directory |
| :---: | :---: |
| <img src="https://github.com/MrwnMoh/DCMS/blob/main/Pics/Users.png" width="450" alt="Users and Roles" /> | <img src="https://github.com/MrwnMoh/DCMS/blob/main/Pics/Doctors.png" width="450" alt="Doctors Management" /> |

### 📅 Booking & Invoicing Lifecycles
| 📋 Appointment Management Dashboard | 💳 Billing & Financial Calculations |
| :---: | :---: |
| <img src="https://github.com/MrwnMoh/DCMS/blob/main/Pics/Appointments.png" width="450" alt="Appointment Management" /> | <img src="https://github.com/MrwnMoh/DCMS/blob/main/Pics/Billing.png" width="450" alt="Billing and Payments" /> |

---

## 🚀 Main Features

### 🔐 1. Multi-Layer Security & Identity Handler
* **Advanced Session Protection:** Secured user login infrastructure featuring comprehensive input validation routines to ensure data integrity.
* **Cryptographic Credential Safeguards:** Passwords are fully protected and securely stored using robust **Hashing** mechanics.
* **Secure Enterprise "Remember Me":** Implemented securely using **Windows DPAPI (ProtectedData)** to fully prevent plain-text storage of credential assets locally.
* **Role-Based Access Control (RBAC):** Restricts interface accessibility based on institutional roles (`Admin` / `Doctor`) along with active/inactive state controls.

### 📊 2. Clinical Administration & Records Management
* **Dynamic Clinic Analytics:** Real-time summary statistics counter on the main interface displaying system users, admins, doctors, and active profiles.
* **Granular Records Directory:** normalizes and partitions institutional registers into unified `People`, digital `Patients` tracking, and `Doctors` directories (including hiring/leaving milestones).
* **Treatment Catalog:** Fully manageable diagnostic pricing module supporting core procedures: **Dental Examination**, **Teeth Cleaning**, **Dental Filling**, **Root Canal Treatment**, and **Tooth Extraction**.

### 📅 3. Appointment Lifecycle & Automated Billing
* **Booking Pipeline Tracking:** Centralized pipeline allowing operators to seamlessly schedule, update, complete, and cancel clinical appointments.
* **Relational Record Search:** Allows immediate patient and doctor lookups directly utilizing unique `ID` keys.
* **Automated Billing Processor:** Automatically handles algorithmic fee tracking by parsing individual treatment costs to calculate a `Subtotal`, deduct `Discounts`, and finalize the `Total Amount`.
* **Dual-Channel Payment Terminal:** Complete payment logging supporting both cash registers (`Cash`) and transaction cards (`Card`).

---

## 📂 Project Structure & Tech Stack

| Component | Responsibility / Technology Used |
| :--- | :--- |
| **Presentation Layer** | **C# .NET Windows Forms** utilizing **Guna UI2** components for building interactive, user-friendly, and modern front-end dashboards. |
| **Business Logic Layer** | Fully driven by **Object-Oriented Programming (OOP)**, managing core validations, calculations, and security configurations like **Windows DPAPI**. |
| **Data Access Layer** | Highly optimized **ADO.NET** pipelines utilizing database **Stored Procedures** to safely execute parameterized statements. |
| **Database Server** | **Microsoft SQL Server** for structured relational data storage and secure indexing. |

---

## 👨‍💻 Author
**Marwan Mohammed**
> "Building secure, scalable, and beautifully engineered desktop solutions – Focused on C#, Advanced SQL Server, and Clean 3-Tier Software Architecture."
