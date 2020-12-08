# Triangle Tracker

#### Triangle Tracker Console Application, 12-8-2020

#### By Agata Kolodziej & Ellie Lambert

## Description

It is a console app that will take three numbers and return what type of triangle (if any) they form.

## Specifications

<details>
  <summary>Expand Specs</summary>

### Describe: Triangle()

| Test                                                                           | Expect                                                                                        |
| ------------------------------------------------------------------------------ | --------------------------------------------------------------------------------------------- |
| It will prompt the user to enter 3 numbers for each side of a triangle         | Triangle("Please enter three numbers to see what type of triangle they form").toEqual(3,3,3); |
| It will return "Equilateral" if all three sides are equal                      | Triangle(3,3,3).toEqual("Equilateral");                                                       |
| It will return "Isosceles" if exactly two sides are equal                      | Triangle(3,3,2).toEqual("Isosceles");                                                         |
| It will return "Scalene" if no sides are equal are equal                       | Triangle(1,3,1).toEqual("Isosceles");                                                         |
| It will return "Not a triangle" if one side is greater than two sides combined | Triangle(2,2,8).toEqual("Not a triangle");                                                    |

</details>

## Setup/Installation Requirements

##### Software Requirements

1. Internet browser
2. A code editor such as VSCode to view and edit the code

##### View Online

- To view in browser click the GH-Pages link: [Name of App](URL)
- what to do when open online

##### Open Locally

- Click on the link to my repository: [My Repository](URL)
- Click on the green "Code" button and copy the repository URL
- Open your terminal and use the command `git clone REPO URL HERE` into the directory you would like to clone the repository
- Open in text editor to view code and make changes

---dotnet restore instructions dotnet run build script?---

## Known Bugs

TODO

## Support and Contact Details

If any errors or bugs occur use Chrome DevTools or please email me, <agatakolohe@gmail.com>

## Technologies Used

- C# 7.3
- .NET Core 2.2
- REPL
- VS Code
- GitHub

### License

This software is licensed under the [MIT License](https://choosealicense.com/licenses/mit/).

Copyright (c) 2020 Agata Kolodziej & Ellie Lambert
