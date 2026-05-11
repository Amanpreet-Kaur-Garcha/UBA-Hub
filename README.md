# UBA HUB – Unnat Bharat Abhiyan Management System
UBA HUB is a desktop-based management system developed to streamline the documentation, tracking, and reporting of village outreach activities conducted under the Unnat Bharat Abhiyan (UBA) initiative.

The application helps institutions manage activity records, coordinator details, multimedia uploads, and report generation in a centralized and organized manner.

## Features
- Role-based workflow for Village Coordinators and Organising Teams
- Activity record management with CRUD operations
- Dynamic filtering using Village, Activity, and Year
- Image and video upload support
- Crystal Report generation for formatted activity reports
- Search and update functionality
- User-friendly Windows Forms interface

## Tech Stack
- VB.NET
- MS Access Database
- Crystal Reports
- Windows Forms

## Modules
### 1. Dashboard
Central navigation panel connecting all modules.

### 2. Village Coordinator Module
Allows coordinators to:
- Add activity details
- Upload images/videos
- Store outreach records in database

### 3. Organising Team Module
Allows organizing members to:
- Search records
- Update Need and Final Description fields
- Finalize activity reports

### 4. Activities Module
Supports:
- Filtering records
- Editing and deleting entries
- Viewing complete details
- Generating Crystal Reports

## Database
The system uses MS Access (.accdb) as the backend database for storing:
- Coordinator information
- Activity records
- Multimedia file paths
- Final reports

## Key Learning Outcomes

- Database connectivity using OleDb
- CRUD operation implementation
- Dynamic filtering and searching
- Report generation with Crystal Reports
- Windows Forms UI design

## Challenges Faced
- Integrating Crystal Reports with dynamic data
- Implementing multi-filter search functionality
- Managing media uploads and validation
- Maintaining data consistency across modules

## Screenshots
Dashboard:
<img width="573" height="434" alt="HomePageUBA_HUB" src="https://github.com/user-attachments/assets/3e8fda0e-bc8e-4f38-a27a-5ba344416e2f" />

Coordinator Form:
<img width="570" height="536" alt="VC_DataEntryInForm" src="https://github.com/user-attachments/assets/64357ad3-cc5d-4bc3-ad46-89a8a9b79da3" />

Activities Form:
<img width="568" height="540" alt="ACT_FilledDetailsALL" src="https://github.com/user-attachments/assets/e415fa3c-2f0b-492b-9cb0-7f3e20f04b32" />

Crystal Report Preview:
<img width="610" height="790" alt="image" src="https://github.com/user-attachments/assets/10fc1c19-cb8e-4ed7-b5e3-946e76eeea22" />
<img width="614" height="792" alt="image" src="https://github.com/user-attachments/assets/fab6d0ca-f00f-45db-b2b3-4de6d26bdb18" />
<img width="610" height="793" alt="image" src="https://github.com/user-attachments/assets/5ea738c5-15b8-4ba4-8c13-f704c5de29ef" />

## How to Run
1. Open the project in Visual Studio 2015
2. Configure the MS Access database path
3. Build and run the application (UBA_HUB_PROJECT.sln)
