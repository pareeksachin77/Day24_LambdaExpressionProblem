// See https://aka.ms/new-console-template for more information
using LambdaExpressionProblem;
using System;

Console.WriteLine("Lambda Expression Demo");

List<Person> ListPersonInCity = new List<Person>();
LambdaSample.AddRecords(ListPersonInCity);
//LambdaSample.Retrieving_TopTwo_Records_ForAge_LessThanSixty(ListPersonInCity);
//LambdaSample.CheckingForTeenagerPerson(ListPersonInCity);
//LambdaSample.AllPersonAverageAge(ListPersonInCity);
//LambdaSample.CheckNameExistOrNot(ListPersonInCity);
//LambdaSample.Skip_Records_ForAges_LessThan_Sixty(ListPersonInCity);
LambdaSample.Remove_Specific_Name_From_List(ListPersonInCity);
