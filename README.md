# EServices
This repository contains the frontend and backend of the E-Services Portal solution. The aim of this solution is to develop fully functional website as an assessment for me regarding Maxima Group Company .Net Developer position.

## Technologies Used
<ul>
  <li>Blazor WebAssembly for frontend</li>
  <li>CSS and Bootstrap for styling</li>
  <li>ASP.Net Web API for backend</li>
  <li>.Net 7</li>
  <li>EF Core for data access</li>
  <li>Microsoft SQL Server (localdb) for database</li>
  <li>RestSharp for http requests handling</li>
  <li>Visual Studio 2022 for development</li>
  <li>C# everywhere you will find it</li>
</ul>


## Solution Parts
The solution consist of three parts
<ul>
  <li>EServices Portal</li>
  <li>EServices API</li>
  <li>Shared Project</li>
</ul>

### EServices Portal
This is the frontend part of the solution. I developed this part using Blazor WebAssembly and designed the project so that it became one page only. I used RestSharp to perform Http requests to the backend.

### EServices API
This is the backend part of the solution. I developed this part using ASP.Net Minimal APIs and EF Core for data access. I write the business logic so that it contains only one endpoint and also Open API is integrated in this solution for testing purpose. I tried to make it as simple as possible even the authentication and authorization I did it manually using C# logic. I also utilized Dependency Injection to Abstract data access layer functionality by creating IUserService and UserService.

### Shared Project
This is a shared class library used between frontend and backend. It contains the Dtos and the encoding logic.

## How to play EServices Solution
<ol>
  <li>Clone EServices repository</li>
  <li>Open EServices.sln with Visual Studio</li>
  <li>Make sure the solution build successfully and all dependencies are downloaded</li>
  <li>Make sure you are using localdb from Microsoft SQL server</li>
  <li>
    Perform database migration using the following approaches
    <ol>
      <li>Connect to localdb using Microsoft SQL Server Managment studio with creating a database named "EServicesDb" manually. Then run the script.sql inside Solution Items folder file against "EServicesDb" to apply all necessary migrations. The following screenshots demonstrate the process
        <ul>
          <li>![image](https://github.com/Khalid-Hassan-97/EServices/assets/54312650/15cc7844-660b-4602-b817-15d23b504e27)</li>
          <li>![image](https://github.com/Khalid-Hassan-97/EServices/assets/54312650/98ae527f-0aeb-4215-922f-963133298706)</li>
          <li>![image](https://github.com/Khalid-Hassan-97/EServices/assets/54312650/1c839d0b-1e88-497e-9ce3-1642427afff4)</li>
          <li>![image](https://github.com/Khalid-Hassan-97/EServices/assets/54312650/841bf95a-e749-4647-92ff-fe5aef2ceb9b)</li>
          <li>![image](https://github.com/Khalid-Hassan-97/EServices/assets/54312650/6dc61af3-da84-4623-99df-e34af65b454f)</li>
        </ul>
      </li>
      <li>Perform the migration using Visual Studio and here we don't need to create the database manually using Microsoft SQL Server Management Studio. All what we need to do is to open "Package Manager Console" then select Default Project as "EServicesAPI" and run "Update-Database" command. The following screenshot demonstrate the process
        <ul>
          <li>![image](https://github.com/Khalid-Hassan-97/EServices/assets/54312650/56f438fa-6f96-48a2-a37a-80c668d990bb)</li>
        </ul>
      </li>
    </ol>
  </li>
  <li></li>
  <li></li>
  <li></li>
  <li></li>
  <li></li>
</ol>
