# ArticleBlogWebApi

## Prerequisites

-   [.NET Core SDK 3.0 or later](https://www.microsoft.com/net/download/all)
-   [Visual Studio 2019 Preview](https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=community&ch=pre&rel=16&utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=inline+link&utm_content=download+vs2019preview)  with the  **ASP.NET and web development**  workload
-   [MongoDB](https://docs.mongodb.com/manual/tutorial/install-mongodb-on-windows/)

## Using

 1. Firstly, download MongoDB to your computer and complete the setup
    steps.
 2.  Download the repository.
 3.  Edit the content of the appSettings.json file.
	 

>          "CollectionName": "Articles",
>         	"ConnectionString": "mongodb://localhost:27017",
>         	"DatabaseName": "ArticlesDb"    

 4. If all steps are completed, run the project and go to url 

>  localhost:5000/swagger     (5000-> or your another ports)

6. Let's add article samples to the database with the help of SwaggerUI: Example usage:
 
 *POST​/api​/Article*
> {
		  "title": "DemoTitle",
		  "description": "Description",
		  "category": "Category",
		  "author": "Author"
}

7. Now, Let's list, search, edit and delete some data from SwaggerUI 
>    *Get​/api​/Article*

>    Get​/api​/Article/{id}*

>    Put​/api​/Article/{id}*

>    Delete​/api​/Article/{id}*
## Questions
 - DB Layer was used as Singleton with the help of Dependency Injection (DI)
 - Net.Core - Web API2 - MongoDB - SwaggerUI was used within the project. I use these technologies regularly.
- Additional features such as comment, like, elastic search can be added
