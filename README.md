# 🦷 Dental Clinic Management System (DCMS)

<p align="center">
  <img src="https://readme-typing-svg.herokuapp.com?font=Fira+Code&size=28&pause=1000&color=2563EB&width=800&lines=Dental+Clinic+Management+System;C%23+Windows+Forms+Project;3-Tier+Architecture;Secure+Desktop+Application" alt="Typing Animation" />
</p>

<p align="center">
  <img src="https://img.shields.io/badge/C%23-Project-purple?style=for-the-badge&logo=c-sharp" alt="C#">
  <img src="https://img.shields.io/badge/.NET-Windows+Forms-blue?style=for-the-badge&logo=.net" alt=".NET">
  <img src="https://img.shields.io/badge/DB-SQL--Server-red?style=for-the-badge&logo=microsoft-sql-server" alt="SQL Server">
  <img src="https://img.shields.io/badge/Architecture-3--Tier-green?style=for-the-badge" alt="Architecture">
  <img src="https://img.shields.io/badge/Security-Windows+DPAPI-yellow?style=for-the-badge" alt="Security">
</p>

---

## 📝 Introduction
**Dental Clinic Management System (DCMS)** is a professional desktop application developed using **C# Windows Forms** and **SQL Server**. The system is built to simplify daily clinic operations by providing a secure, organized, and user-friendly management system. 

Engineered using **3-Tier Architecture** and strict **Object-Oriented Programming (OOP)** principles, the application ensures high data integrity, robust authentication, and optimal performance using **ADO.NET** and **Stored Procedures**. One of the key security implementations is safeguarding user credentials with **Hashing** and securing the "Remember Me" functionality via **Windows DPAPI (ProtectedData)**.

---

## 🖼️ Project Screenshots

### 🔐 Authentication & Role-Based Dashboards
| 🔑 Secure Login Interface |
| :---: |
| <img src="https://github.com/MrwnMoh/Dental-Clinic-Management-System/blob/main/Pic/Login.png" width="925" alt="Login Screen" /> |

| 👑 Admin Dashboard View | 🩺 Doctor Dashboard View |
| :---: | :---: |
| <img src="https://github.com/MrwnMoh/Dental-Clinic-Management-System/blob/main/Pic/Admin%20Dashboard.png" width="450" alt="Admin Dashboard" /> | <img src="https://github.com/MrwnMoh/Dental-Clinic-Management-System/blob/main/Pic/Docotr%20Dashboard.png" width="450" alt="Doctor Dashboard" /> |

### 🗂️ Core Registers & Management
| 👥 People Management Grid | 🩺 Patients Management Ledger |
| :---: | :---: |
| <img src="https://github.com/MrwnMoh/Dental-Clinic-Management-System/blob/main/Pic/People.png" width="450" alt="People Management" /> | <img src="https://github.com/MrwnMoh/Dental-Clinic-Management-System/blob/main/Pic/Patients.png" width="450" alt="Patients Management" /> |

### 👤 Users & Staff Configurations
| 🔒 User Accounts & Roles | 👨‍⚕️ Doctors Directory |
| :---: | :---: |
| <img src="https://github.com/MrwnMoh/Dental-Clinic-Management-System/blob/main/Pic/Users.png" width="450" alt="Users Management" /> | <img src="https://github.com/MrwnMoh/Dental-Clinic-Management-System/blob/main/Pic/Doctors.png" width="450" alt="Doctors Management" /> |

### 📅 Appointment & Billing Lifecycles
| 📋 Appointment Management Dashboard | 💳 Take Appointment & Billing Ledger |
| :---: | :---: |
| <img src="https://github.com/MrwnMoh/Dental-Clinic-Management-System/blob/main/Pic/Create%20Appointments.png" width="450" alt="Appointment Dashboard" /> | <img src="https://github.com/MrwnMoh/Dental-Clinic-Management-System/blob/main/Pic/Take%20Appointments.png" width="450" alt="Take Appointment" /> |

---

## 🚀 Key Features

### 🔐 1. Secure Authentication
* **Password Hashing:** User passwords are securely encrypted and stored using hashing algorithms to prevent unauthorized access.
* **Windows DPAPI Integration:** The "Remember Me" functionality utilizes Windows Data Protection API (`ProtectedData`) instead of plain text storage, isolating and protecting local credentials.
* **Input Validation:** Comprehensive validation rules across all forms to ensure data integrity and system security.

### 📊 2. Interactive Dashboard & Quick Actions
* **Clinic Statistics:** Provides a high-level real-time overview of clinic counters and performance numbers.
* **Profile Overview:** Displays clear developer/doctor profile metrics.
* **One-Click Actions:** Quick navigation terminals to add `People`, `Patients`, `Doctors`, `Users`, and `Appointments` instantly.

### 👥 3. Comprehensive Data Registers
* **People Management:** Grid control system to manage all registered individuals with advanced search, filtration, and CRUD (View/Edit/Delete) functionality based on contact info, blood type, country, and roles.
* **Patients Records:** Complete digital ledger to search, view profiles, edit, and delete detailed patient information.
* **Doctors Directory:** Detailed tracking of medical staff, specialized roles, and dental specialties alongside hiring and leaving parameters.

### 👤 4. Role-Based Access Control (RBAC) & Dashboard Dynamic Views
* **Role-Based Privileges:** Clear division of system operations between `Admin` and `Doctor` accounts.
* **Admin Dashboard View:** Full access to the system including all sidebar management modules (`Dashboard`, `People`, `Patients`, `Users`, `Doctors`, `Appointments`) and all quick action capability buttons.
* **Doctor Dashboard View:** Restricted, tailored view hiding sensitive administrative controls. Side menus for managing system users or deep staff directories are dynamically adapted, disabling restricted buttons (like *Add User* and *Add Doctor*) based on logged-in role credentials.
* **Status Controls:** Manage active and inactive accounts globally with dedicated dashboard counters monitoring users, admins, doctors, and active session layers.

### 📅 5. Appointment & Financial Processing
* **Scheduling Lifecycle:** Full management framework to schedule, update, complete, and cancel appointment states (`Pending`, `Completed`, `Cancelled`).
* **ID-Based Searches:** Immediate data resolution enabling quick lookups of patients and doctors via their unique system IDs.
* **Automatic Billing Processor:** Programmatic calculation engine managing treatment pricing to automatically compute `Subtotal`, `Discount`, and `Total Amount`.
* **Multi-Channel Payments:** Built-in checkout terminal supporting payment verification through `Cash` or `Card`.

### 🦷 6. Treatment Catalog
* Pre-configured and easily expandable lookup data handling treatments such as:
  * **Dental Examination**
  * **Teeth Cleaning**
  * **Dental Filling**
  * **Root Canal Treatment**
  * **Tooth Extraction**

---

## 🛠️ Technologies Used

* **Language:** C#
* **Framework:** .NET Windows Forms
* **Database:** Microsoft SQL Server
* **Data Access:** ADO.NET & Optimized Stored Procedures
* **UI Customization:** Guna UI2 Component Library
* **Architecture:** 3-Tier Layered Architecture & Object-Oriented Programming (OOP)
* **Security:** Windows Data Protection API (DPAPI - ProtectedData) & Password Hashing

---

## 👨‍💻 Author
**Marwan Mohammed**
> "Building secure, scalable, and beautifully engineered desktop solutions – Focused on C#, Advanced SQL Server, and Clean Software Architecture."
