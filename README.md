# ⚡ LESCO Billing System

A comprehensive **Electricity Billing Management System** built with **C# and Windows Forms** for the Lahore Electric Supply Company (LESCO).  
Manage customer accounts, generate bills, track payments, and administer tariff structures through an intuitive desktop application.

---

## 🚀 Features

- 👥 **Customer Management**: Register, update, and manage customer profiles
- 💰 **Automated Billing**: Generate bills based on meter readings and tariff rates
- 💳 **Payment Processing**: Record and track payment status
- ⚡ **Multi-Tier Tariff**: Support for Domestic/Commercial and Single/Three-Phase meters
- 📊 **Billing History**: View complete payment and consumption records
- 🔐 **Employee Portal**: Secure login system for LESCO staff
- 📄 **Data Persistence**: File-based storage using CSV/Text files
- 🧾 **Tax Calculation**: Automatic sales tax and fixed charges computation

---

## 🛠️ Tech Stack

**Language:** C#  
**Framework:** .NET Framework / .NET Core  
**UI:** Windows Forms (WinForms)  
**Storage:** File-based (CSV/Text files)  
**IDE:** Visual Studio 2019/2022  

---

## ⚙️ Installation & Setup

### Prerequisites

- Windows OS (Windows 7+)
- Visual Studio 2019/2022
- .NET Framework 4.7.2+ or .NET 6.0+

### Steps

1️⃣ **Clone the Repository**
```bash
git clone https://github.com/samar-2004/Lesco-Billing-System.git
cd Lesco-Billing-System
```

2️⃣ **Open in Visual Studio**

- Launch Visual Studio
- Open the `.sln` file

3️⃣ **Build & Run**
```bash
Build → Build Solution (Ctrl + Shift + B)
Debug → Start Debugging (F5)
```

---

## 📊 System Components

### Data Files

- **CustomersInfo.txt**: Customer records with ID, name, address, meter type
- **EmployeesData.txt**: Employee credentials for authentication
- **BillingInfo.txt**: Monthly billing records and payment status
- **TariffTaxInfo.txt**: Tariff rates, taxes, and fixed charges

### Key Features

**Bill Calculation:**
```
Total Bill = (Units × Unit Price) + Sales Tax + Fixed Charges
Due Date = Reading Date + 7 days
```

**Tariff Rates:**
- Single-Phase: Rs. 5 (Domestic), Rs. 15 (Commercial)
- Three-Phase: Rs. 8/12 (Domestic), Rs. 18/25 (Commercial)

---

## 💡 Usage

**For Employees:**
1. Login with username and password
2. Add/update customer information
3. Enter monthly meter readings
4. Generate bills automatically
5. Process payments and update records

**For Customers:**
1. Login with Customer ID and Date of Birth
2. View current and past bills
3. Check payment history

---

## 🤝 Contributing

1. Fork the repository
2. Create your feature branch (`git checkout -b feature-name`)
3. Commit your changes (`git commit -m 'Add feature'`)
4. Push to branch (`git push origin feature-name`)
5. Open a Pull Request

---

## 🧑‍💻 Author

👤 **Muhammad Samar Junaid**  
💼 Software Engineer 
📧 samarjunaid2004@gmail.com  
🌐 [GitHub](https://github.com/samar-2004) 
🔗 [LinkedIn](https://www.linkedin.com/in/muhammad-samar-junaid-b955121bb/)

---

## ⭐ Show Your Support

If you liked this project, don't forget to **star the repository** 🌟

---

**Powering Efficient Billing. Empowering LESCO.** ⚡💼
