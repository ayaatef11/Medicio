## Medicio 🏥
Medicio is a modern, fully responsive healthcare web application designed for managing medical services, displaying doctors, and booking appointments. Built with the latest technologies, it provides a seamless user experience with a clean and professional design.

## 🚀 Features
- 🏥 Doctors & Departments – Browse medical professionals and hospital departments.
- 📅 Appointment Booking – Users can schedule appointments easily.
- 📸 Gallery & Testimonials – Showcases medical facilities and patient feedback.
- 📊 Dynamic Services & Pricing – Display healthcare services with pricing plans.
- 🌍 Responsive Design – Fully optimized for all screen sizes.

## 🛠️ Technologies Used
- Frontend (Angular 19)
- TypeScript – Core language for Angular development.
- Angular Router – Handles navigation between pages.
- Bootstrap & SCSS – For styling and responsive design.
- Ngx-Spinner – Loading animations for a better UX.
- Ngx-Toastr – Notifications and alert messages.
- Backend (.NET Core & Entity Framework Core)
- ASP.NET Core Web API – Backend API for handling requests.
- Entity Framework Core – ORM for database management.
- SQL Server – Relational database for storing data.
## 📦 Project Structure

```
/src
 ├── app
 │   ├── components (UI Components)
 │   ├── core (Core Functionalities)
 │   ├── services (API Services)
 │   ├── models (Data Models)
 │   ├── routes (Routing Configuration)
 ├── assets (Static Files)
 ├── environments (Configurations)
```

## 📌 Design Patterns & Best Practices

- Standalone Components – Utilized Angular 19’s new approach.
- Dependency Injection – Improves code reusability and scalability.
## 🛠️ Setup & Installation
- 1️⃣ Clone the Repository
```
git clone https://github.com/ayaatef11/Medicio.git
cd Medicio
```
- 2️⃣ Install Dependencies
For the frontend:
```
npm install
```
For the backend:
`dotnet restore `
- 3️⃣ Configure Environment Variables
Update the API URL in environment.ts and appsettings.json with the correct backend URL.

- 4️⃣ Run the Application
Frontend
`ng serve --open`
Backend
`dotnet run`
## 📜 API Endpoints
Endpoint	Method	Description
/api/doctors	GET	Fetch all doctors
/api/appointments	GET	Create a new appointment
/api/departments
/api/services
/api/pricing
/api/testmoinals
## 👨‍💻 Contributing
Contributions are welcome! If you find any issues, feel free to submit a PR or open an issue.

## 📄 License
This project is open-source and available under the MIT License.

