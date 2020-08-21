# Local Business Lookup API 

#### C#, MySql & API practice for Epicodus, 08.21.2020

## By Jeff Kim

## Description

Pierre was just the beginning! In this project, we will be creating an API that will query a database populated by all of the local shops and restaurants in our fictional town. Developers will be able to use the API to get a list of all shops and restaurants, query the database for a shop/restaurant or a group of shops/restaurants based on their properties (such as type of shop or cuisine), add a new shop/restaurant to the directory (with authentication), edit the details of a shop/restaurant (with authentication), or delete a shop/restaurant from the directory (with authentication).

This project uses C#, MySQL, Entity Framework, and MVC to create a web API that interacts with a database and has full CRUD functionality. This project includes JWT Token authentication and uses Swagger to provide easy-to-use documentation that will show users and developers how to make use of this API and how to make successful requests.

## Specifications

| Behavior | Input | Output |  Completed(Y/N?)  |
| -------- | ----- | ------ | -------- |
| Create an object called Shop with  auto-implementing properties for its Name, Type, and Phone Number |  |  | Y |
| Create an object called Restaurant with  auto-implementing properties for its Name, Cuisine, and Phone Number | | | Y |
| Allow users to view a list of all Shops through an API Get request | | | Y |
| Allow users to view a list of all Restaurants through an API GET request | | | Y |
| Allow users to view a list of Shops filtered by Shop properties | | | Y |
| Allow users to view a list of Restaurants filtered by Restaurant properties | | | Y |
| Allow authorized users to create a new Shop object through an API POST request |  |  | Y |
| Allow authorized users to create a new Restaurant object through an API POST request |  |  | Y |
| Allow authorized users to edit a Shop object through an API PUT request | | | Y |
| Allow authorized users to edit a Restaurant object through an API PUT request | | | Y |
| Allow authorized users to delete a Shop object through an API DELETE request | | | Y |
| Allow authorized users to delete a Restaurant object through an API DELETE request | | | Y |
| Create a database with tables for Shop and Restaurant objects using Entity Framework and code first development and database migrations | | | Y |
| Restrict unauthenticated users from Creating, Editing, or Deleting Shop/Restaurant objects | | | Y |

## Setup/Installation Requirements

**Requirements:**
* [.NET Core SDK 2.2](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer)
* [MySQL Server 8.0.19](https://dev.mysql.com/downloads/file/?id=484919)
* [MySQL Workbench 8.0.19](https://dev.mysql.com/downloads/file/?id=484919)
* Entity Framework

**To use this program:**

1. Open your preferred browser.
2. Navigate to https://github.com/jkbutserious/BusinessLookup.Solution.git.
3. Click the **Code** button and click **Download ZIP** to clone the repository to your computer.
4. Open the Windows PowerShell console, VS Code Bash terminal, or the MacOS Terminal and use the ``cd [YOUR DOWNLOAD FILEPATH]/BusinessLookup.Solution/BusinessLookup`` command to navigate to the Blockbuster subdirectory.
5. Use the ``dotnet restore`` command to install the necessary packages on your computer.
6. Use the ``dotnet run`` command to run the program.
7. Use an API 
8. Ensure that the following code is present in your *appsettings.json* file:

    ```
    {
      "ConnectionStrings": {
          "DefaultConnection": "Server=localhost;Port=3306;database=jeff_kim;uid=root;pwd=epicodus;"
      }
    }
    ```

9. If you have any issues running this program, please reach out to the developer or troubleshoot at your own risk.

To recreate the database using MySQL and Entity Framework Core:

_**Note**: These instructions assume that you have installed and set up your MySQL Server according to Epicodus's guidelines, as well as Entity Framework Core. For more information, see [Installing and Configuring MySQL](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql) and [Configuration for Entity Framework Core](https://www.learnhowtoprogram.com/c-and-net/database-basics-c2449db9-5bd8-4303-af8d-7ed7259f79a7/configuration-for-entity-framework-core)._

1. Open Windows PowerShell, the MacOS Terminal, or your VS Code terminal and use the command ``cd [YOUR DOWNLOAD FILEPATH]/BusinessLookup.Solution/BusinessLookup``.
2. Ensure that the Migrations folder is included in your cloned repository.
3. Use the ``dotnet ef database update`` command to apply the latest database migration.
4. Use MySQL Workbench or your preferred terminal to verify the database schema.

**Using the JSON Web Token**

You will need to authenticate using a JSON Web Token (JWT) in order to use the POST, PUT, and DELETE functionality of this API. To authenticate, use an API development tool, such as Postman and follow these instructions:

1. In Postman, create a POST request using this URL: ``http://localhost:5000/users/authenticate``
2. In the **Body** tab of the request, select the **raw** output type and use the drop-down menu to change the format to JSON.
3. Include the following data in the body of the request:
    ```
    {
      "username": "test",
      "password": "test"
    }
    ```
4. In the response, copy the token and click the **Authorization** tab. Use the **Type** drop-down to select **Bearer Token** and paste the token into the **Token** field.

**API Swagger Documentation**

For a full set of documentation for this API, including HTTP Request syntax, parameters, example queries, and sample JSON response data, use the [Swagger Documentation](https://app.swaggerhub.com/apis-docs/jeffkim/business-lookup/1.0#/).

**To contribute to this project:**

1. Open your preferred browser.
2. Navigate to https://github.com/jkbutserious/BusinessLookup.Solution.
3. Log into or sign up for your GitHub account.
4. Click the **Fork** button to copy the repository and all source code.
5. From your forked repository, you can download or clone the repository, by clicking the **Code** button.
  * To clone the repository in Visual Studio Code's terminal, use the command

    ```git clone https://github.com/[YOUR-USER-NAME-HERE]/BusinessLookup.Solution```
  * To clone the repository in GitHub Desktop, click the **Open in Desktop** option
  * To download the repository, click the **Download ZIP** option, save the archive to your computer, and extract it to the folder of your choice
6. Use your preferred code editor to edit the appropriate model and view files. New classes should be added in the Models subdirectory and should use the ``Blockbuster.Models`` namespace. **Note**: the Blockbuster.csproj file is a C# project file and should not be edited.
7. Use the ``dotnet ef migrations add [YOUR MIGRATION NAME HERE]`` to add a new database migration. 

    You can also export your database schema from MySQL Workbench by using the **Data Export** option on the **Administration** tab of your database, select the schema you want to export, select the **Dump Structure and Data** option from the dropdown menu, and click the **Start Export** button. Make sure to name the file _jeff_kim.sql_ and add the file to your repository in the top-level directory.
8. Save any changes you make in your code editor and use your preferred git solution to commit your changes.
9. Push your changes to your forked repository.

#### Additional Setup/Installation Notes:

* No additional code is necessary to view this project.   

## Known Bugs

_No known issues. Please contact me if you have any problems._


## Support and contact details

To report any issues with this page or to contribute to this project, contact Jeff Kim at kim2jy@hotmail.com.

## Technologies Used

* C#
* .NET Core 2.2
* MySQL Server 8.0.19
* MySQL Workbench 8.0.19
* Entity Framework
* JWT
* MVC
* Visual Studio Code 
* Git and Git BASH 


### License

Copyright © 2020 Jeffrey Kim

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.