-- =============================================
-- WareHousePro — Database Init & Seed
-- SQL Server
-- Run this on a fresh SQL Server instance
-- =============================================

USE master;
GO

IF EXISTS (SELECT name FROM sys.databases WHERE name = 'StorageBookingProDB')
    DROP DATABASE StorageBookingProDB;
GO

CREATE DATABASE StorageBookingProDB;
GO

USE StorageBookingProDB;
GO

-- =============================================
-- TABLES
-- =============================================

CREATE TABLE roles (
    role_id     INT IDENTITY(1,1) PRIMARY KEY,
    role_code   VARCHAR(20) NOT NULL UNIQUE
);

CREATE TABLE users (
    user_id         INT IDENTITY(1,1) PRIMARY KEY,
    username        VARCHAR(50) NOT NULL UNIQUE,
    password_hash   VARCHAR(255) NOT NULL,
    role_id         INT NOT NULL REFERENCES roles(role_id),
    is_active       BIT NOT NULL DEFAULT 1,
    created_at      DATETIME NOT NULL DEFAULT GETDATE()
);

CREATE TABLE warehouses (
    warehouse_id    INT IDENTITY(1,1) PRIMARY KEY,
    warehouse_code  VARCHAR(20) NOT NULL UNIQUE,
    name            VARCHAR(100) NOT NULL,
    city            VARCHAR(100) NOT NULL,
    is_active       BIT NOT NULL DEFAULT 1
);

CREATE TABLE storage_unit_types (
    type_id         INT IDENTITY(1,1) PRIMARY KEY,
    type_name       VARCHAR(50) NOT NULL UNIQUE,
    min_capacity    INT NOT NULL DEFAULT 0,
    max_capacity    INT NOT NULL DEFAULT 99999
);

CREATE TABLE storage_units (
    unit_id             INT IDENTITY(1,1) PRIMARY KEY,
    warehouse_id        INT NOT NULL REFERENCES warehouses(warehouse_id),
    type_id             INT NOT NULL REFERENCES storage_unit_types(type_id),
    unit_code           VARCHAR(20) NOT NULL UNIQUE,
    capacity            INT NOT NULL,
    base_price_per_day  DECIMAL(18,2) NOT NULL,
    is_active           BIT NOT NULL DEFAULT 1
);

CREATE TABLE vouchers (
    voucher_id      INT IDENTITY(1,1) PRIMARY KEY,
    code            VARCHAR(50) NOT NULL UNIQUE,
    discount_type   VARCHAR(10) NOT NULL CHECK (discount_type IN ('Percent', 'Fixed')),
    discount_value  DECIMAL(18,2) NOT NULL,
    max_usage       INT NOT NULL DEFAULT 1,
    used_count      INT NOT NULL DEFAULT 0,
    valid_from      DATETIME NOT NULL,
    valid_to        DATETIME NOT NULL,
    is_active       BIT NOT NULL DEFAULT 1
);

CREATE TABLE bookings (
    booking_id          INT IDENTITY(1,1) PRIMARY KEY,
    booking_code        VARCHAR(20) NOT NULL UNIQUE,
    warehouse_id        INT NOT NULL REFERENCES warehouses(warehouse_id),
    unit_id             INT NOT NULL REFERENCES storage_units(unit_id),
    requested_capacity  INT NOT NULL,
    start_date          DATETIME NOT NULL,
    end_date            DATETIME NOT NULL,
    status_code         VARCHAR(20) NOT NULL DEFAULT 'REQUESTED'
                            CHECK (status_code IN ('REQUESTED','CONFIRMED','IN_USE','COMPLETED','CANCELLED')),
    created_by          INT NOT NULL REFERENCES users(user_id),
    created_at          DATETIME NOT NULL DEFAULT GETDATE()
);

CREATE TABLE booking_vouchers (
    id          INT IDENTITY(1,1) PRIMARY KEY,
    booking_id  INT NOT NULL REFERENCES bookings(booking_id),
    voucher_id  INT NOT NULL REFERENCES vouchers(voucher_id)
);

CREATE TABLE booking_pricing (
    pricing_id  INT IDENTITY(1,1) PRIMARY KEY,
    booking_id  INT NOT NULL REFERENCES bookings(booking_id),
    base_total  DECIMAL(18,2) NOT NULL,
    discount    DECIMAL(18,2) NOT NULL DEFAULT 0,
    final_total DECIMAL(18,2) NOT NULL,
    created_at  DATETIME NOT NULL DEFAULT GETDATE()
);
GO

-- =============================================
-- SEED DATA
-- =============================================

-- Roles
INSERT INTO roles (role_code) VALUES ('ADMIN'), ('STAFF');

-- Users (plain text password — swap with hashed in production)
INSERT INTO users (username, password_hash, role_id, is_active, created_at) VALUES
('admin',  'admin123', 1, 1, GETDATE()),
('staff1', 'staff123', 2, 1, GETDATE()),
('staff2', 'staff123', 2, 1, GETDATE());

-- Storage Unit Types
INSERT INTO storage_unit_types (type_name, min_capacity, max_capacity) VALUES
('Small',   1,   100),
('Medium',  101, 500),
('Large',   501, 2000),
('Freezer', 1,   300);

-- Warehouses
INSERT INTO warehouses (warehouse_code, name, city, is_active) VALUES
('WH-001', 'Gudang Jakarta Utara',  'Jakarta',  1),
('WH-002', 'Gudang Surabaya Timur', 'Surabaya', 1),
('WH-003', 'Gudang Bandung Tengah', 'Bandung',  1);

-- Storage Units
INSERT INTO storage_units (warehouse_id, type_id, unit_code, capacity, base_price_per_day, is_active) VALUES
(1, 1, 'SU-001', 50,   75000,  1),
(1, 2, 'SU-002', 200,  150000, 1),
(1, 3, 'SU-003', 1000, 400000, 1),
(1, 4, 'SU-004', 80,   200000, 1),
(2, 1, 'SU-005', 30,   65000,  1),
(2, 2, 'SU-006', 300,  175000, 1),
(2, 3, 'SU-007', 800,  350000, 1),
(3, 1, 'SU-008', 90,   80000,  1),
(3, 2, 'SU-009', 450,  160000, 1),
(3, 4, 'SU-010', 150,  220000, 0); -- inactive unit

-- Vouchers
INSERT INTO vouchers (code, discount_type, discount_value, max_usage, used_count, valid_from, valid_to, is_active) VALUES
('DISKON10',   'Percent', 10,     100, 0,  GETDATE(), DATEADD(MONTH, 3, GETDATE()), 1),
('DISKON20',   'Percent', 20,     50,  0,  GETDATE(), DATEADD(MONTH, 1, GETDATE()), 1),
('HEMAT50K',   'Fixed',   50000,  200, 0,  GETDATE(), DATEADD(MONTH, 6, GETDATE()), 1),
('NEWUSER100K','Fixed',   100000, 30,  0,  GETDATE(), DATEADD(MONTH, 2, GETDATE()), 1),
('EXPIRED',    'Percent', 15,     10,  10, DATEADD(MONTH, -3, GETDATE()), DATEADD(MONTH, -1, GETDATE()), 0);

-- Bookings (sample — using user_id=2 as staff1)
INSERT INTO bookings (booking_code, warehouse_id, unit_id, requested_capacity, start_date, end_date, status_code, created_by, created_at) VALUES
('BK-001', 1, 1, 40,  DATEADD(DAY, -10, GETDATE()), DATEADD(DAY, -3,  GETDATE()), 'COMPLETED', 2, DATEADD(DAY, -12, GETDATE())),
('BK-002', 1, 2, 150, DATEADD(DAY, -5,  GETDATE()), DATEADD(DAY,  5,  GETDATE()), 'IN_USE',    2, DATEADD(DAY, -6,  GETDATE())),
('BK-003', 2, 5, 25,  DATEADD(DAY,  2,  GETDATE()), DATEADD(DAY,  10, GETDATE()), 'CONFIRMED', 2, GETDATE()),
('BK-004', 3, 8, 80,  DATEADD(DAY,  5,  GETDATE()), DATEADD(DAY,  15, GETDATE()), 'REQUESTED', 3, GETDATE()),
('BK-005', 1, 3, 500, DATEADD(DAY, -15, GETDATE()), DATEADD(DAY, -8,  GETDATE()), 'CANCELLED', 2, DATEADD(DAY, -16, GETDATE()));

-- Booking Pricing (for completed/in-use bookings)
INSERT INTO booking_pricing (booking_id, base_total, discount, final_total, created_at) VALUES
(1, 525000,  0,      525000,  DATEADD(DAY, -12, GETDATE())),
(2, 750000,  75000,  675000,  DATEADD(DAY, -6,  GETDATE())),
(3, 520000,  0,      520000,  GETDATE()),
(4, 1200000, 120000, 1080000, GETDATE()),
(5, 2800000, 0,      2800000, DATEADD(DAY, -16, GETDATE()));

-- Booking Vouchers (booking 2 pakai DISKON10, booking 4 pakai HEMAT50K)
INSERT INTO booking_vouchers (booking_id, voucher_id) VALUES (2, 1), (4, 3);

-- Update used_count voucher yang dipakai
UPDATE vouchers SET used_count = 1 WHERE voucher_id = 1;
UPDATE vouchers SET used_count = 1 WHERE voucher_id = 3;

GO

PRINT 'Database StorageBookingProDB berhasil dibuat dan di-seed.';
