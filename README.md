# Console-Cost-of-Living-Calculator

## Description
Welcome to my Cost-of-Living Calculator! This is a simple Console app built in .NET 5 that I designed to help me better visualize, manage, and calculate my living expenses. 
When I was looking for viable projects to test my command of basic C# syntax and types, I repeatedly came across the observation that a good project solves a simple problem.
Well, for me, keeping tabs on how much was being spent on groceries versus going to utilities and the like each month was something that I had been neglecting to give its just due. 
And that is the primary service this calculator renders!

## Current Features
* Allows users to calculate monthly totals for:
  * rent
  * utilities
    * water and electric
    * heating  
  * groceries
    * food groceries
    * non-food groceries
  * gas
  * take-out
  * all 
* Breakdown of monthly expenses by:
  * week
  * day  
* Allows users to calculate as many expenses as they like:
  *  can continuously cycle through each category, storing each monthly total
  *  one finished, can invoke 'all' total to sum up all of the different stored totals together 

## Intended Improvements
Right now, this app greatly expedites the calculations of my month bills and expenses, but I am still obligated to record these values manually somewhere else. It would be great to
expand this app by connecting it to a database that, upon request, stores the monthly totals after each calculation.
