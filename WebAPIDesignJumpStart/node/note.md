[Related Course Link @ MVA](https://www.microsoftvirtualacademy.com/en-US/training-courses/web-api-design-jump-start-8689)

The goal with REST and the goal with [OData](http://www.odata.org/) is to have consistency.

2 Advantages to Use REST:
* It uses the HTTP mechanism;
* Easy for mobile devices to consume since its returned data type ( JSON is small in size and easy to deal with than XML ).


2 Quiz about OData:
* Which format does OData use to represent results?
  
  Atom

* You have an OData source that has a collection named Products. Which URL will retrieve the product that has an identifier of 20?

  http://www.contoso.com/OData/OData.svc/Products(20)


**In Web API, a resource is typically a controller. 
Avoid exposing business logic, that means make the process the noun.**

In Web API's verbs, PUT means to replace while PATCH means to update.

Web API Help Page: Install-Package Microsoft.Asp.Net.WebApi.HelpPage

If the Web API project did not include MVC, add a call to AreaRegistration.RegisterAllAreas in WebApiConfig







  
