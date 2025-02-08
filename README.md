# e-xam

**e-xam** is a conceptual digital examination platform designed for ITI to facilitate exam management for instructors and students.

This project was developed by our team as part of the [ITI](https://iti.gov.eg/home) Advanced SQL course within the Integrated Software Development & Architecture track.

## Team
- [@AhmedYasserMohammed](https://github.com/AhmedYasserMohammed)
- [@Heba-abdelwahab](https://github.com/Heba-abdelwahab)
- [@rahmaelsayedddd](https://github.com/rahmaelsayedddd)
- [@shroukzaghloul2024](https://github.com/shroukzaghloul2024)
- [@miinamaaher1](https://github.com/miinamaaher1)

## Technology

### Database: SQL Server
The application utilizes **Microsoft SQL Server** for database management.

### Backend: .NET
Built using **.NET technologies** for seamless integration and performance.

### Data Access: ADO.NET
Database connectivity is managed through **ADO.NET**, ensuring efficient data handling.

### User Interface: Windows Forms
![Instructor Home](screenshots/02%20features%20menus.png)
The UI is developed using **Windows Forms**, providing a structured and intuitive experience.


### Report Generation: Report Builder
Reports are generated using **Report Builder**. Since Report Builder was unavailable for .NET 9, we used a decompiled and recompiled version provided by **Ikosson** to ensure compatibility.

## Features
The platform supports two roles: **Instructor** and **Student**, each with unique and shared functionalities.

### Login
Users can securely log in based on their assigned roles.

![login](screenshots/00%20login.png)

## Instructor Features
![Instructor Home](screenshots/01%20instructor%20homepage.png)

### Add Question
Instructors can:

- Select a course they teach.
- Create **Multiple Choice (MCQ)** or **True/False (TF)** questions.
- Add questions to the question bank.

![Add Question](screenshots/04%20add%20question.png)

### Generate Exam
Instructors can:

- generate exams with randomized questions from the question bank.
- Customize exams based on preferences.

![Generate Exam 1](screenshots/19%20generate%20exam%20customize.png)

- Assign exams to a specific track with ease.

![Generate Exam 2](screenshots/20%20generate%20exam%20view.png)

## Course Details
Instructors can view topics for any of their assigned courses.

![Course Details](screenshots/08%20view%20topics.png)

### My Classes
Instructors can:

- View their assigned **tracks/courses**.
- Check the number of students enrolled in each class.

![My Classes](screenshots/09%20view%20classes.png)

### Track Stats
Instructors can view the **total scores** of their students for any track.

![Track Stats](screenshots/15%20track%20stats.png)

## Student Features
![Student Home](screenshots/21%20student%20homepage.png)

### My Stats
Students can view their **scores** across all enrolled courses.

![My Stats](screenshots/13%20student%20stats.png)

### My Courses
Students can browse all **courses** they are enrolled in.

![My Courses](screenshots/22%20student%20courses.png)

### My Exams
Students can:

- View available exams with status-based actions:
  - **Take** (Enabled) → If the exam is open.
  - **Take** (Disabled) → If the exam is scheduled but not yet available.
  - **View** → If they have already taken the exam (to review their answers).
  - **Missed** (Disabled) → If they missed the exam.

![My Exams](screenshots/23%20student%20exams.png)

### Take Exam
Students can:

- Start an exam when available.
- Select their answers and submit when finished.
- Use a built-in **timer**, which auto-submits upon expiration.

![Take Exam](screenshots/24%20take%20exam.png)

### Review Answers
Students can review their answers for past exams after submission.

![Review Answers](screenshots/11%20review%20answers.png)


## Setup & Usage Instructions

### Prerequisites

Ensure you have the following installed:
- **Microsoft SQL Server**
- **SQL Server Management Studio**
- **.NET 9 SDK**
- **Visual Studio (or any compatible IDE)**

### Setup Steps

1. **Clone the Repository**
   ```sh
   git clone <https://github.com/miinamaaher1/e-xam>
   cd e-xam
   ```
2. **Setup the Database**
   - Setup the database by either restoring the provided `e_xam_DB.bak` file 
   - or executing the `E_XAM_DB_SCRIPT_FULL.sql` to setup the database structure and sample data,
   - or execute the `E_XAM_DB_SCRIPT_DDL.sql` to only setup the database structure.

3. **Configure the Connectoin**
   - Update the **connection string** in the application configuration file `appsettings.json`.
   - Configure the data sourse `e_xam_DSC.xsd`.

4. **Build & Run the Application**
   - Open the solution in Visual Studio.
   - Restore dependencies using:
     ```sh
     dotnet restore
     ```
   - Build and run the project:
     ```sh
     dotnet run
     ```

### Usage

1. **Login** using instructor or student credentials.
2. **Instructors** can add questions, generate exams, and track student performance.
3. **Students** can view courses, take exams, and review results.