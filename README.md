# WareHouse

A warehouse management desktop application built with **C# Windows Forms** and **SQL Server**. Supports multi-role access (Admin & Staff) for managing warehouses, storage units, bookings, and vouchers.

---

## Features

**Admin**
- Dashboard with live stats and charts (active warehouses, bookings, revenue, utilization)
- User management (add, edit, deactivate)
- Warehouse management
- Storage unit management
- Voucher management (percent/fixed discount, date range, usage limits)

**Staff**
- Booking creation with optional voucher
- Booking list with filter by status, date range, and warehouse

---

## Tech Stack

- **Language** — C# (.NET Framework 4.7.2)
- **UI** — Windows Forms
- **Database** — SQL Server (via ADO.NET)
- **ORM** — None (raw SQL with parameterized queries)

---

## Project Structure

```
WareHousePro/
├── Admin/              # Admin-only UserControls (Dashboard, Warehouse, StorageUnit, Voucher, UserManagement)
├── Staff/              # Staff UserControls (BookingCreation)
├── Public/             # Shared UserControls (BookingList)
├── core/
│   ├── network/        # DBHelper — centralized DB access
│   └── util/           # ValidationHelper, CodeBuilder
├── Form1.cs            # Login form
├── MainForm.cs         # Shell with role-based navigation
└── UserSession.cs      # Static session state
```

---

## Getting Started

### Prerequisites

- Visual Studio 2019 or later
- SQL Server (Express or full)
- .NET Framework 4.7.2

### Setup

**1. Clone the repo**
```bash
git clone https://github.com/your-org/WareHousePro.git
```

**2. Create the database**

Run the SQL script in `/database/init.sql` on your SQL Server instance. It will create the database, tables, and seed initial data.

**3. Update connection string**

In `WareHousePro/core/network/DBHelper.cs`, update the connection string to match your SQL Server instance:

```csharp
private const string connectionString = 
    "Server=YOUR_SERVER\\SQLEXPRESS;Database=StorageBookingProDB;Integrated Security=true;TrustServerCertificate=true";
```

**4. Build & Run**

Open `WareHousePro.sln` in Visual Studio, build the solution, and run.

### Default Login

| Username | Password | Role  |
|----------|----------|-------|
| admin    | admin123 | Admin |
| staff1   | staff123 | Staff |

---

## Notes

- Passwords are stored as plain text in this version — consider hashing (e.g. BCrypt) before deploying to production
- `BookingDetailForm` is currently a stub — not yet implemented
- Date filter in Booking List uses `@sd >= b.start_date AND @ed <= b.end_date` — adjust if you need overlap logic instead

---
