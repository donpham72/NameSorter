# Name Sorter

## Introduction
This is a .NET Core Console Application that sorts a list of names by last name, then by given name. 
A name must have at least 1 given name and may have up to 3 given names.

## Installation
1. Steps to install the project
1. Deploy the project by right-click on the NameSorter project in Solution Explorer and select Publish.
1. The resulting files are placed in a directory named Publish that is in a subdirectory of your project's .\bin\release\net8.0 subdirectory.
1. Deploy the complete set of application files in any way you like. For example, you can package them in a Zip file, use a simple copy command, or deploy them with any installation package of your choice.

## How to run the application
Executing the program in the following way;
name-sorter ./unsorted-names-list.txt

## Example Usage
Given a a file called unsorted-names-list.txt containing the following list of names;
1. Janet Parsons
1. Vaughn Lewis
1. Adonis Julius Archer
1. Shelby Nathan Yoder
1. Marin Alvarez
1. London Lindsey
1. Beau Tristan Bentley
1. Leo Gardner
1. Hunter Uriah Mathew Clarke
1. Mikayla Lopez
1. Frankie Conner Ritter

The result the sorted names will be;
1. Marin Alvarez
1. Adonis Julius Archer
1. Beau Tristan Bentley
1. Hunter Uriah Mathew Clarke
1. Leo Gardner
1. Vaughn Lewis
1. London Lindsey
1. Mikayla Lopez
1. Janet Parsons
1. Frankie Conner Ritter
1. Shelby Nathan Yoder

## What's contained in this project
- NameSorter (Console application) project: implements name sort by last name, then by given names
- Test project - (xUnit test): implements test cases
